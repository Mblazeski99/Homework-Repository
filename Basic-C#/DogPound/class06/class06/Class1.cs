using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class06
{
    class Dog
    {
        public string Name { get; private set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public bool isHungry { get; private set; }

        public Dog(string name)
        {
            Name = name;
            Breed = "Mongrel";
            isHungry = false;
        }

        public string Eat(string food = "Dog food")
        {
            if (isHungry)
            {
                isHungry = false;
                return $"{Name} is eating {food}";
            }
            else
            {
                return $"{Name} is not hungry it wants to play";
            }


        }

        public string Play()
        {
            if (isHungry)
            {
                return $"{Name} is hungry it doesn't want to chase its tail";
            }
            else
            {
                isHungry = true;
                return $"{Name} is playin on its own";
            }


        }

        public string Play(string toy)
        {
            if (isHungry)
            {
                return $"{Name} is hungry it doesn't want to chase its tail";
            }
            else
            {
                isHungry = true;
                return $"{Name} is playin with its {toy}";
            }
        }
    }
}
