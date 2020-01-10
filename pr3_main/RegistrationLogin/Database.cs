using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RegistrationLogin {
    static class Database {
        public static BindingSource Users { get; set; } = new BindingSource();
        public static BindingSource Roles { get; set; } = new BindingSource();
        private static RLDbContext Context { get; set; } = new RLDbContext();
        private static string LastQuery { get; set; }

        public static event Action<User> UserLoggedIn;
        public static event Action UsersChanged;

        static Database() {
            Users.DataSource = Context.Users.ToList();
            Roles.DataSource = Context.Roles.ToList();

            UsersChanged += () => Query(LastQuery);
        }

        public static void Register(string first, string last, string username, string password, byte[] picture, List<Role> roles) {
            User user = new User() {
                FirstName = first,
                LastName = last,
                Username = username,
                Password = password,
                AccountPicture = picture,
                Roles = roles
            };

            Context.Users.Add(user);
            Context.SaveChanges();

            UsersChanged?.Invoke();
        }

        public static void Update(int id, User modifiedUser) {
            var found = Context.Users.Find(id);

            found?.Update(modifiedUser);

            Context.SaveChanges();

            UsersChanged?.Invoke();
        }

        public static bool TryGetUser(int id, out User user) {
            var found = Context.Users.Find(id);

            if (found != null) {
                user = new User(found);
            } else {
                user = null;
            }

            return user != null;
        }

        public static User Login(string username, string password) {
            int id = Context.Users.SingleOrDefault(x => x.ValidateCredentials(username, password))?.ID ?? -1;

            if (TryGetUser(id, out User user)) {
                UserLoggedIn?.Invoke(user);
            }

            return user;
        }

        public static void Query(string query) {
            LastQuery = query;

            if (string.IsNullOrEmpty(query)) {
                Users.DataSource = Context.Users.ToList();
            } else {
                Users.DataSource = Context.Users.Where(user => user.FirstName.ToLower().Contains(query.ToLower()) || user.LastName.ToLower().Contains(query.ToLower())).ToList();
            }
        }
    }
}
