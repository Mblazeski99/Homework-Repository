using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class06
{
    class Program
    {
        static void Main(string[] args)
        {
            var pound = new Pound();
            pound.Name = "Vardarishte";

            var fido = new Dog("Fido");
            fido.Breed = "poodle";

            var rex = new Dog("Rex");

            pound.AddDog(fido);
            pound.AddDog(rex);

            fido.Play();

            //rex.Play();

            string[] responses = pound.FeedTheDogs();
            foreach(string response in responses)
            {
                Console.WriteLine(response);
            }

            Dog[] hungryDogs = pound.GetHungryDogs();
            foreach(Dog doggo in hungryDogs)
            {
                if(doggo.isHungry)
                {
                    Console.WriteLine($"{doggo.Name} is hungry");
                }
            }

            var poodle = pound.FindByBreed("poodle");

            Console.WriteLine($"{poodle.Name} is a {poodle.Breed}");

            Console.ReadKey();
        }
    }
}
