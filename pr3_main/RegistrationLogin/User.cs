using System.Drawing;
using System.IO;

namespace RegistrationLogin {
    public class User {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { private get; set; }
        public byte[] AccountPicture { get; set; }

        public User(string first, string last, string username, string password, byte[] image) {
            FirstName = first;
            LastName = last;
            Username = username;
            Password = password;
            AccountPicture = image;
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

            using (MemoryStream stream = new MemoryStream()) {
                stream.Write(array, 0, array.Length);
                return Image.FromStream(stream);
            }
        }

        public void Update(string first, string last, string username, string password, byte[] image) {
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
}
