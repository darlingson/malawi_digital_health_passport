using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace malawi_digital_health_passport;

    public class User
    {
    public User()
    {
    }

    public User(string name,string user_id,string password,string email) {
        Name = name;
        User_id = user_id;
        Password = password;
        Email = email;
    }
        public string Name { get; set; }
        public string User_id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }

