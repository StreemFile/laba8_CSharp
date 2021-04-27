using System;
using Dates;

namespace laba8.One
{
    public class Cat : Animal
    {
        private bool hasMother;

        public Cat()
        {
        }

        public Cat(string name, Date lastVeterinarianVisit, bool hasMother) : base(name, lastVeterinarianVisit)
        {
            this.hasMother = hasMother;
        }

        public bool HasMother
        {
            get => hasMother;
            set => hasMother = value;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("МЯУ");
        }

        public override void Eat()
        {
            Console.WriteLine("МЯУ ЯКА ВКУСНА РИБКА");
        }

        public void HasMotherMeme()
        {
            if (hasMother)
            {
                Console.WriteLine("\n - КІТ ТИ МАМУ МАВ? " +
                                  "\n - МЯУ" +
                                  "\n - А ТАТА МАВ?" +
                                  "\n - МЯУУ" +
                                  "\n - А БРАТА МАВ?" +
                                  "\n МЯУ");
            }
            else
            {
                Console.WriteLine("\nНЕ МЯУ");
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, " +
                   $"\n{nameof(hasMother)}: {hasMother}";
        }
    }
}