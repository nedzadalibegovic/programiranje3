﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationLogin {
    class User {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { private get; set; }

        public User(string FirstName, string LastName, string Username, string Password) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Username = Username;
            this.Password = Password;
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
            Users.Add(new User("Nedzad", "Alibegovic", "nedzad", "qwerty"));
            Users.Add(new User("Harun", "Sabljakovic", "harun", "qwertz"));
            Users.Add(new User("Haris", "Mlaco", "haris", "qweasd"));
            Users.Add(new User("Adis", "Kubat", "adis", "azerty"));
        }

        public static void Register(User user) {
            Users.Add(user);
            UserRegistered(user);
        }

        public static User Login(string username, string password) {
            User user = Users.Find(x => x.ValidateCredentials(username, password));

            if (user != null) {
                UserLoggedIn(user);
            }

            return user;
        }
    }
}