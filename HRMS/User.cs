using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRMS
{
    public class User
    {
        private string ID;
        private string Name;
        private string Position;
        public User(string id,string name,string position)
        {
            ID = id;
            Name = name;
            Position = position;
        }
        public User()
        {

        }
        public void SetUser(string  id, string name, string position)
        {
            ID = id;
            Name = name;
            Position = position;
        }
        public string getid()
        {
            return ID;
        }
        public string getname()
        {
            return Name;
        }
        public string getposition()
        {
            return Position;
        }
    }
}
