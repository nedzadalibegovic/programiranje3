using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationLogin {
    static class Database {
        public static List<User> Users { get; set; } = new List<User>();

        public static event Action<User> UserRegistered;
        public static event Action<User> UserLoggedIn;

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
            User user = Users.Find(x => x.ValidateCredentials(username, password));

            if (user != null) {
                UserLoggedIn?.Invoke(user);
            }

            return user;
        }

        public static List<User> QueryString(string query) {
            return Users.FindAll(user => user.FirstName.ToLower().Contains(query.ToLower()) || user.LastName.ToLower().Contains(query.ToLower()));
        }
    }
}
