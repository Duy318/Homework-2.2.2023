using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string token = Console.ReadLine();

            List<Animal> animals = new List<Animal>();

            while (token != "Beast!")
            {
                string animalType = token;

                string[] animalInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string animalName = animalInfo[0];
                int animalAge = int.Parse(animalInfo[1]);
                string animalGender = animalInfo[2];

                if (animalAge <= 0 || (animalGender != "Male" && animalGender != "Female"))
                {
                    Console.WriteLine("Invalid input!");

                    token = Console.ReadLine();

                    continue;
                }

                Animal animal = null;

                switch (animalType)
                {
                    case "Cat":
                        animal = new Cat(animalName, animalAge, animalGender);
                        break;

                    case "Dog":
                        animal = new Dog(animalName, animalAge, animalGender);
                        break;

                    case "Frog":
                        animal = new Frog(animalName, animalAge, animalGender);
                        break;

                    case "Tomcat":
                        animal = new Tomcat(animalName, animalAge);
                        break;

                    case "Kitten":
                        animal = new Kitten(animalName, animalAge);
                        break;
                }

                animals.Add(animal);

                token = Console.ReadLine();
            }

            foreach (Animal animal in animals)
                Console.WriteLine(animal);
        }
    }
}