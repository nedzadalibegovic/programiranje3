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
        public static byte[] ImageToByteArray(Image imageIn) {
            using (MemoryStream ms = new MemoryStream()) {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn) {
            using (MemoryStream ms = new MemoryStream(byteArrayIn)) {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
    }
}
