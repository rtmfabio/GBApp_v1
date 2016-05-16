using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBApp.Models
{
    sealed class User
    {
        private static User _instance = new User();
        private String id;
        private String name;
        public String Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public User()
        {

        }
        public User(String _id, String _name)
        {
            Id = _id;
            Name = _name;
        }

        static internal User Instance()
        {
            return _instance;
        }

    }
    

}
