using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_2
{
    internal class Player// there are three public private internal
    {
        //Properties
        public string Username { get; set; }
        public string Role { get; set; }
        public int Level { get; set; }
        //constructor helps set up defaults
        public Player(string _username, string _role, int _level)
        {
            Username = _username;
            Role = _role;
            Level = _level;

        }
        //overloading is two methods with same name but different parameters
        public Player()
        {
            Username = "New User";
            Role = "Unassigned";
            Level = 1;
        }

        //Methods
        public string GetDetails()
        {
            return $"Username: {Username} Role: {Role} Level: {Level}";

        }
    }
}

