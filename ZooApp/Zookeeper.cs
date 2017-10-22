using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Zookeeper
    {
        public string Name { get; set; }
        public void AssignAnimalToCage(Animal animal, List<Cage> cages)
        {
            foreach(var currCage in cages)
            {
                if(currCage.Enviroments.Count < animal.RequiredEnviroments.Count) { continue; }
                int count = 0;
                foreach(var currReqEnv in animal.RequiredEnviroments)
                {
                    foreach(var currEnv in currCage.Enviroments)
                    {
                        if (currReqEnv.Equals(currEnv.GetType()))
                        {
                            count++;
                            if(count == animal.RequiredEnviroments.Count && currCage.Animal == null)
                            {
                                animal.Cage = currCage;
                                currCage.Animal = animal;
                                return;
                            }
                            break;
                        }
                    }
                }
                
            }
        }
    }
}
