using System;
using Dates;

namespace laba8.One
{
    public class Dog : Animal
    {
        private bool isTeachedToBringTapochki;

        public Dog()
        {
        }

        public Dog(string name, Date lastVeterinarianVisit, bool isTeachedToBringTapochki) : base(name, lastVeterinarianVisit)
        {
            this.isTeachedToBringTapochki = isTeachedToBringTapochki;
        }

        public bool IsTeachedToBringTapochki
        {
            get => isTeachedToBringTapochki;
            set => isTeachedToBringTapochki = value;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("ГАВ");
        }

        public override void Eat()
        {
            Console.WriteLine("ГАВ ЯКА СМАЧКА КІСТОЧКА");
        }

        public void BringTapochki()
        {
            if (isTeachedToBringTapochki)
            {
                Console.WriteLine("ХАЗЯЇН ВОТ ТВОЇ ТАПКИ ГАВ");
            }
            else
            {
                Console.WriteLine("НЕЗНАЙОМА КОМАНДА ГАВ");
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, " +
                   $"\n{nameof(isTeachedToBringTapochki)}: {isTeachedToBringTapochki}";
        }
    }
}