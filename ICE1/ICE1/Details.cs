using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE1
{
    class Details
    {
        public Details(string name, string age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age + " Gender: " + Gender;
        }
    }
}
