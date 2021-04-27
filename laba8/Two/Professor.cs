using System;
using System.Runtime.CompilerServices;
using laba8.One;

namespace laba8.Two
{
    public class Professor : ITeacher
    {
        private bool isDocentAbuser;

        public Professor()
        {
        }

        public Professor(bool isDocentAbuser)
        {
            this.isDocentAbuser = isDocentAbuser;
        }

        public bool IsDocentAbuser
        {
            get => isDocentAbuser;
            set => isDocentAbuser = value;
        }

        public int GetSalary()
        {
            return 15000;
        }

        public void Introduce()
        {
            Console.WriteLine("Доброго дня, я професор!");
        }

        public void AbuseDocent()
        {
            if (isDocentAbuser)
            {
                Console.WriteLine("Ха, тупий доцент!");
            }
            else
            {
                Console.WriteLine("Я не абюзер!");
            }
        }
    }
}