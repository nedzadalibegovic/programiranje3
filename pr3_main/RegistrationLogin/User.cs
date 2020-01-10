using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace RegistrationLogin {
    public class User : INotifyPropertyChanged {
        public int ID { get; private set; } = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] AccountPicture { get; set; }
        public virtual List<Role> Roles { get; set; } = new List<Role>();

        public event PropertyChangedEventHandler PropertyChanged;

        public User() { }

        public User(int id, string first, string last, string username, string password, byte[] picture) {
            ID = id;
            FirstName = first;
            LastName = last;
            Username = username;
            Password = password;
            AccountPicture = picture;
        }

        public User(User user) {
            if (user == null) {
                return;
            }

            ID = user.ID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Password = user.Password;
            AccountPicture = user.AccountPicture;
            Roles = user.Roles;
        }

        public static byte[] ImageToByteArray(Image img) {
            if (img == null) {
                return null;
            }

            MemoryStream stream = new MemoryStream();
            img.Save(stream, img.RawFormat);

            return stream.ToArray();
        }

        public static Image ByteArrayToImage(byte[] array) {
            if (array == null) {
                return null;
            }

            MemoryStream stream = new MemoryStream();
            stream.Write(array, 0, array.Length);

            return Image.FromStream(stream);
        }

        public void Update(int id, string first, string last, string username, string password, byte[] image, List<Role> roles) {
            if (id != ID) {
                return;
            }

            FirstName = first;
            LastName = last;
            Username = username;
            Password = password;
            AccountPicture = image;
            Roles = roles;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("User.Update"));
        }

        public void Update(User modified) {
            Update(modified.ID, modified.FirstName, modified.LastName, modified.Username, modified.Password, modified.AccountPicture, modified.Roles);
        }

        public bool ValidateCredentials(string username, string password) {
            return username == Username && password == Password;
        }
    }
}
