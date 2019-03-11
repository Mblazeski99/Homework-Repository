using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class06
{
    class Pound
    {
        public string Name { get; set; }

        private int dogCount = 0;

        private bool found = false;

        internal Dog[] dogArr = new Dog[0];

        internal string AddDog(Dog dog)
        {
            Array.Resize(ref dogArr, dogArr.Length + 1);
            dogArr[dogCount] = dog;
            dogCount += 1;
            return $"the dog {dog} was added in the pound";
        }

        public Dog[] GetHungryDogs()
        {         
            return dogArr;
        }

        public Dog FindByBreed(string breed)
        {
            foreach (Dog dogBreed in dogArr)
            {
                if (dogBreed.Breed == breed)
                {
                    found = true;
                    return dogBreed;
                }
            }
            if (found == false)
            {
                Console.WriteLine($"There is no {breed} try this one?");
            }
            return dogArr[1];
        }

        public string[] FeedTheDogs()
        {
            string[] doggoResponses = new string[dogArr.Length];
            for(int j = 0; j< dogArr.Length; j++)
            {
                doggoResponses[j] = dogArr[j].Eat();
            }
            return doggoResponses;
        }
    }
}
