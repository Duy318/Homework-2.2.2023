using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, null)
        {

        }

        public override string ProduceSound() => "Meow";
    }
}