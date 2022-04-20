using System;

namespace HomeWork20._04._22_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Xelilbey", "Xelilbeyli", 28, "Male", true, 75);
            Console.WriteLine(student.GetInfo());
        }

    }
    class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;
        public bool isGraduated;
        public byte Point;
        public Student(string name, string surname, byte age, string gender, bool graduated, byte point)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Point = point;
            isGraduated = graduated;
            if (graduated = true)
            {
                Console.WriteLine("Imtahannan kecdiniz");
            }
            if (point >= 80)
            {
                Console.WriteLine("ikinci imtahana kecemeye sans qazandiz");
            }
            else
            {
                Console.WriteLine("imtahannan kesildiniz");
            }
        }
        public string GetInfo()
        {

            return $"Name:{Name} Surname: {Surname} Age: {Age} Gender: {Gender} Point: {Point} Is Graduated: {isGraduated} ";

        }
    }
}
