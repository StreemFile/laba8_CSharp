using System;

namespace laba8.Two
{
    public class Docent : ITeacher
    {
        private bool wantsToBecomeProfessor;

        public Docent(bool wantsToBecomeProfessor)
        {
            this.wantsToBecomeProfessor = wantsToBecomeProfessor;
        }

        public Docent()
        {
        }

        public bool WantsToBecomeProfessor
        {
            get => wantsToBecomeProfessor;
            set => wantsToBecomeProfessor = value;
        }

        public int GetSalary()
        {
            return 10000;
        }

        public void Introduce()
        {
            Console.WriteLine("Доброго дня, я доцент!");
        }

        public void BecomeProfessor()
        {
            if (wantsToBecomeProfessor)
            {
                Console.WriteLine("Потрібно ще трохи повчитись.");
            }
            else
            {
                Console.WriteLine("Я не хочу бути професором.");
            }
        }
    }
}