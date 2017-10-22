using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Zoo
    {
        public List<Animal> Animals { get; set; }
        public string name { get; private set; }
        public List<Cage> Cages { get; set; }
        public Zookeeper Zookeeper { get; set; }

        public Zoo(string name)
        {
            this.name = name;
        }

        public void AddAnimal(Animal a)
        {
            if(Animals == null)
            {
                Animals = new List<Animal>();
            }
            Animals.Add(a);
        }

        public void AddCage(Cage ca)
        {
            if(Cages == null)
            {
                Cages = new List<Cage>();
            }
            Cages.Add(ca);
        }
    }
}
