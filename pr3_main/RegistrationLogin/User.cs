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

        public void Update(int id, string first, string last, string username, string password, byte[] image) {
            if (id != ID) {
                return;
            }

            FirstName = first;
            LastName = last;
            Username = username;
            Password = password;
            AccountPicture = image;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("User.Update"));
        }

        public void Update(User user) {
            Update(user.ID, user.FirstName, user.LastName, user.Username, user.Password, user.AccountPicture);
        }

        public bool ValidateCredentials(string username, string password) {
            return username == Username && password == Password;
        }
    }
}
