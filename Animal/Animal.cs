using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public virtual string ProduceSound() => null;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{GetType().Name}");
            stringBuilder.AppendLine($"{Name} {Age} {Gender}");
            stringBuilder.AppendLine($"{ProduceSound()}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}