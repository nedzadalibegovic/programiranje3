using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationLogin {
    class User {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { private get; set; }
        public Image AccountPicture { get; set; }

        public User(string first, string last, string username, string password, Image image) {
            FirstName = first;
            LastName = last;
            Username = username;
            Password = password;
            AccountPicture = image;
        }

        public bool ValidateCredentials(string Username, string Password) {
            return Username == this.Username && Password == this.Password;
        }
    }

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
