using System;
using Dates;

namespace laba8.One
{
    public abstract class Animal
    {
        protected string name;
        protected Date lastVeterinarianVisit;

        public abstract void ProduceSound();

        public abstract void Eat();

        protected Animal(string name, Date lastVeterinarianVisit)
        {
            this.name = name;
            this.lastVeterinarianVisit = lastVeterinarianVisit;
        }

        protected Animal()
        {
        }

        public void VisitVeterinarian()
        {
            lastVeterinarianVisit = Date.Now;
        }

        public bool FindByVisitVeterinatianDate(Date visitDate)
        {
            if (lastVeterinarianVisit.Equals(visitDate))
            {
               return true;
            }

            return false;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Date LastVeterinarianVisit
        {
            get => lastVeterinarianVisit;
            set => lastVeterinarianVisit = value;
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}, " +
                   $"\n{nameof(lastVeterinarianVisit)}: {lastVeterinarianVisit}";
        }
    }
}