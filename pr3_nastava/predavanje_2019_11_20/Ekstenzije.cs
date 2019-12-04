﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace predavanje_2019_11_20 {
    public static class Ekstenzije {
        public static string Enkripcija(this string sadrzaj) {
            using (SHA256 sha = SHA256.Create()) {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(sadrzaj));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
