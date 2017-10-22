using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo("Schönbrunn");

            Animal a = new Animal(10, "Bambu");
            a.RequiredEnviroments.Add(typeof(Water));
            a.RequiredEnviroments.Add(typeof(Steppe));

            zoo.AddAnimal(a);

            zoo.AddAnimal(new Animal(7, "Tricksi")
            {
                RequiredEnviroments = new List<Type>() { typeof(Water), typeof(Steppe) }
            });

            zoo.AddCage(new Cage()
            {
                Size = 200,
                Enviroments = new List<Enviroment>() { new Water() }
            });

            zoo.AddCage(new Cage()
            {
                Size = 200,
                Enviroments = new List<Enviroment>() { new Steppe() }
            });

            zoo.AddCage(new Cage()
            {
                Size = 200,
                Enviroments = new List<Enviroment>() { new Water(), new Steppe() }
            });

            zoo.Zookeeper = new Zookeeper();

            zoo.Zookeeper.AssignAnimalToCage(zoo.Animals[0], zoo.Cages);
        }
    }
}
