using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Animal
    {

        public int Age { get; set; }
        public String Name { get; set; }
        public List<Type> RequiredEnviroments { get; set; }
        public Cage Cage { get; set; }

        public  Animal  (int age, String name)
        {
            Age = age;
            Name = name;
            RequiredEnviroments = new List<Type>();
        }
    }
}
