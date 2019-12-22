using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RegistrationLogin {
    static class Database {
        public static BindingSource Users { get; set; } = new BindingSource();
        private static string LastQuery { get; set; }

        public static event Action<User> UserLoggedIn;
        public static event Action UserRegistered;
        public static event Action UserUpdated;

        static Database() {
            using (var context = new RLDbContext()) {
                Users.DataSource = context.Users.ToList();
            }

            UserRegistered += OnChange;
            UserUpdated += OnChange;
        }

        private static void OnChange() {
            using (var context = new RLDbContext()) {
                Query(LastQuery);
            }
        }

        public static void Register(string first, string last, string username, string password, byte[] picture) {
            using (var context = new RLDbContext()) {
                User user = new User() {
                    FirstName = first,
                    LastName = last,
                    Username = username,
                    Password = password,
                    AccountPicture = picture
                };

                context.Users.Add(user);
                context.SaveChanges();

                UserRegistered?.Invoke();
            }
        }

        public static void Update(int id, User user) {
            using (var context = new RLDbContext()) {
                var found = context.Users.Find(id);

                found?.Update(user);
                context.SaveChanges();

                UserUpdated?.Invoke();
            }
        }

        public static bool TryGetUser(int id, out User user) {
            using (var context = new RLDbContext()) {
                var found = context.Users.Find(id);

                if (found != null) {
                    user = new User(found);
                } else {
                    user = null;
                }

                return user != null;
            }
        }

        public static User Login(string username, string password) {
            using (var context = new RLDbContext()) {
                int id = ((List<User>)Users.DataSource).SingleOrDefault(x => x.ValidateCredentials(username, password))?.ID ?? -1;

                if (TryGetUser(id, out User user)) {
                    UserLoggedIn?.Invoke(user);
                }

                return user;
            }
        }

        public static void Query(string query) {
            LastQuery = query;

            using (var context = new RLDbContext()) {
                if (string.IsNullOrEmpty(query)) {
                    Users.DataSource = context.Users.ToList();
                } else {
                    Users.DataSource = context.Users.Where(user => user.FirstName.ToLower().Contains(query.ToLower()) || user.LastName.ToLower().Contains(query.ToLower())).ToList();
                }
            }
        }
    }
}
