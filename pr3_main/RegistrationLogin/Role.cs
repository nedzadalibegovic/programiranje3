using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationLogin {
    public class Role {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<User> Users { get; set; } = new List<User>();

        public override string ToString() {
            return Name;
        }
    }
}
