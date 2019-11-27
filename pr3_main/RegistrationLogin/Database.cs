using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationLogin {
    static class Database {
        public static List<User> Users { get; set; } = new List<User>();
        public static BindingSource bindingSource { get; set; } = new BindingSource();

        public static event Action<User> UserRegistered;
        public static event Action<User> UserLoggedIn;
        public static event Action<User> UserUpdated;

        static Database() {
            Users.Add(new User("Nedzad", "Alibegovic", "nedzad", "qwerty", null));
            Users.Add(new User("Harun", "Sabljakovic", "harun", "qwertz", null));
            Users.Add(new User("Haris", "Mlaco", "haris", "qweasd", null));
            Users.Add(new User("Adis", "Kubat", "adis", "azerty", null));

            bindingSource.DataSource = Users;
        }

        public static void Register(User user) {
            //Users.Add(user);
            //bindingSource.ResetBindings(false);

            bindingSource.Add(user);
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

        public static void Update(User user, string first, string last, string username, string password, byte[] image) {
            Users.Find(x => x == user).Update(first, last, username, password, image);
            bindingSource.ResetBindings(false);

            UserUpdated?.Invoke(user);
        }
    }
}
