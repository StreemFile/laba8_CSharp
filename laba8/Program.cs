using System;
using System.Collections.Generic;
using System.Linq;
using Dates;
using laba8.One;
using laba8.Three;
using laba8.Two;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            // One();
            // Two();
            Three();
        }

        private static void One()
        {
            Console.WriteLine("-----------------DOG-----------------");
            Dog dog = new Dog("Барсік",
                              new Date(2021, 02, 21),
                              true);
            Console.WriteLine(dog.ToString());
            dog.BringTapochki();

            Console.WriteLine("-----------------CAT-----------------");
            Cat cat = new Cat("Василь",
                              new Date(2019, 05, 03),
                              true);
            Console.WriteLine(cat.ToString());
            cat.HasMotherMeme();

            Console.WriteLine("-----------------ARRAY-----------------");
            List<Animal> animals = new List<Animal>
                                   {
                                       dog,
                                       new Dog("Лакі",
                                               new Date(2021, 01, 17),
                                               false),
                                       cat,
                                       new Cat("Пес",
                                               new Date(2021, 01, 17),
                                               false)
                                   };
            animals.Where(item =>
                              item.FindByVisitVeterinatianDate(
                               new Date(2021, 01, 17))
                              )
                   .ToList()
                   .ForEach(item => Console.WriteLine(item.ToString()));
            
            animals.Sort();
        }

        private static void Two()
        {
            Console.WriteLine("----------DOCENT----------");
            Docent docent = new Docent(true);
            docent.BecomeProfessor();
            Console.WriteLine("----------PROFESSOR----------");
            Professor professor = new Professor(true);
        }

        private static void Three()
        {
            Tree tree1 = new Tree(100, 170, "Яблуня");
            Tree tree2 = new Tree(250, 200, "Дуб");
            Console.WriteLine(tree1.CompareTo(tree2));
            Console.WriteLine(tree2.CompareByHeightAndPrice(tree1));
            List<Tree> trees = new List<Tree>
                               {
                                   tree1,
                                   tree2,
                                   new Tree(120,130,"Ялинка"),
                                   new Tree(140,200,"Груша"),
                                   new Tree(350,150,"Сакура"),
                                   new Tree(170,210,"Слива"),
                               };

            trees = IEnumerable.Sort(trees);
            trees.ForEach(Console.WriteLine);

        }
    }
}