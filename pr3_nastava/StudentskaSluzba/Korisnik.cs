using System;
using System.Drawing;
using System.IO;

namespace StudentskaSluzba {
    public class Korisnik {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] AccountImage { get; set; }

        public void Validate() {
            if (Password.Length < 3) {
                throw new ApplicationException("Password nije ispravan!");
            }
        }

        // https://stackoverflow.com/a/3801289
        public static byte[] ImageToByteArray(Image img) {
            if (img == null) {
                return null;
            }

            using (MemoryStream stream = new MemoryStream()) {
                img.Save(stream, img.RawFormat);
                return stream.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArray) {
            if (byteArray == null) {
                return null;
            }

            MemoryStream stream = new MemoryStream(byteArray);
            return Image.FromStream(stream);
        }
    }
}
