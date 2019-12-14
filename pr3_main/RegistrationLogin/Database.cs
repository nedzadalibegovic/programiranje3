using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RegistrationLogin {
    static class Database {
        public static BindingList<User> Users { get; set; } = new BindingList<User>();

        public static event Action<User> UserRegistered;
        public static event Action<User> UserLoggedIn;
        public static event Action<User> UserUpdated;

        static Database() {
            Users.Add(new User("Nedzad", "Alibegovic", "nedzad", "qwerty", null));
            Users.Add(new User("Harun", "Sabljakovic", "harun", "qwertz", null));
            Users.Add(new User("Haris", "Mlaco", "haris", "qweasd", null));
            Users.Add(new User("Adis", "Kubat", "adis", "azerty", null));
        }

        public static void Register(User user) {
            Users.Add(user);
            UserRegistered?.Invoke(user);
        }

        public static User Login(string username, string password) {
            User user = Users.FirstOrDefault(x => x.ValidateCredentials(username, password));

            if (user != null) {
                UserLoggedIn?.Invoke(user);
            }

            return user;
        }

        public static List<User> QueryString(string query) {
            return Users.Where(user => user.FirstName.ToLower().Contains(query.ToLower()) || user.LastName.ToLower().Contains(query.ToLower())).ToList();
        }

        public static void Update(User user, string first, string last, string username, string password, byte[] image) {
            Users.FirstOrDefault(x => x == user)?.Update(first, last, username, password, image);
            Users.ResetBindings();
            UserUpdated?.Invoke(user);
        }
    }
}
