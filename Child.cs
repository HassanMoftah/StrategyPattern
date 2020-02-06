using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Child
    {
        Hair Hair;
        public string Name;
        public int Age { get; set; }
        public Child(Hair hair,string name, int age)
        {
            this.Hair = hair;
            this.Name=name;
            this.Age = age;
        }
        public void SetHairCut(Hair hair)
        {
            this.Hair = hair;
        }
        public void Display()
        {
            Console.WriteLine($"{this.Name} is {this.Age} years old with  {this.Hair.HairCut()}");
        }
    }
}
