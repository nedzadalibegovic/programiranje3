using System;
using System.ComponentModel;
using System.Linq;

namespace RegistrationLogin {
    static class Database {
        public static BindingList<User> Users { get; } = new BindingList<User>();
        public static int StartId { get; } = 100;

        public static event Action<User> UserLoggedIn;
        public static event Action UserRegistered;
        public static event Action UserUpdated;

        static Database() {
            Users.Add(new User(StartId++, "John", "Doe", "john.doe", "qwerty", null));
            Users.Add(new User(StartId++, "Jane", "Doe", "jane.doe", "qwertz", null));
        }

        public static void Register(string first, string last, string username, string password, byte[] picture) {
            int id = Users.Max(x => x.ID) + 1;
            var user = new User(id, first, last, username, password, picture);

            Users.Add(user);
            UserRegistered?.Invoke();
        }

        public static void Update(int id, User user) {
            var found = Users.SingleOrDefault(x => x.ID == id);

            found?.Update(user);
            Users.ResetItem(Users.IndexOf(found));
            UserUpdated?.Invoke();
        }

        public static bool TryGetUser(int id, out User user) {
            var found = Users.SingleOrDefault(x => x.ID == id);

            user = new User(found);

            return user != null;
        }

        public static User Login(string username, string password) {
            User user = Users.FirstOrDefault(x => x.ValidateCredentials(username, password));

            if (user != null) {
                UserLoggedIn?.Invoke(user);
            }

            return user;
        }

        public static BindingList<User> Query(string query) {
            var queryResult = Users.Where(user => user.FirstName.ToLower().Contains(query.ToLower()) || user.LastName.ToLower().Contains(query.ToLower())).ToList();

            return new BindingList<User>(queryResult);
        }
    }
}
