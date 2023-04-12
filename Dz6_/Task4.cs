using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz6_
{
    abstract class Worker
    {
        public string PIB {set; get;}
        public int age { set; get;}
        public int height { get; set; }
        public int weight { get; set; }

        public void Input()
        {
            Console.Write("\nEnter PIB: ");
            PIB = Console.ReadLine();
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter weight: ");
            weight = int.Parse(Console.ReadLine());
        }

        public virtual void Print()
        {
        }
    }

    class President : Worker
    {
        public int experience { set; get; }
        public int educations { get; set; }
        public int language { get; set; }

        public void InputP()
        {
            Input();
            Console.Write("Enter work experience (in age): ");
            experience = int.Parse(Console.ReadLine());
            Console.Write("Enter number of educations: ");
            educations = int.Parse(Console.ReadLine());
            Console.Write("Enter number of language which you know: ");
            language = int.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine($"\nPIB: {PIB}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Work experience: {experience}");
            Console.WriteLine($"Number of educations: {educations}");
            Console.WriteLine($"Number of language: {language}");
        }
    }
    class Security : Worker
    {
        public int experience { set; get; }
        public int educations { get; set; }
        public int language { get; set; }

        public void InputS()
        {
            Input();
            Console.Write("Enter work experience (in age): ");
            experience = int.Parse(Console.ReadLine());
            Console.Write("Enter number of educations: ");
            educations = int.Parse(Console.ReadLine());
            Console.Write("Enter number of language which you know: ");
            language = int.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine($"\nPIB: {PIB}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Work experience: {experience}");
            Console.WriteLine($"Number of educations: {educations}");
            Console.WriteLine($"Number of language: {language}");
        }
    }
    class Manager : Worker
    {
        public int experience { set; get; }
        public int educations { get; set; }
        public int language { get; set; }

        public void InputM()
        {
            Input();
            Console.Write("Enter work experience (in age): ");
            experience = int.Parse(Console.ReadLine());
            Console.Write("Enter number of educations: ");
            educations = int.Parse(Console.ReadLine());
            Console.Write("Enter number of language which you know: ");
            language = int.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine($"\nPIB: {PIB}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Work experience: {experience}");
            Console.WriteLine($"Number of educations: {educations}");
            Console.WriteLine($"Number of language: {language}");
        }
    }
    class Engineer : Worker
    {
        public int experience { set; get; }
        public int educations { get; set; }
        public int language { get; set; }

        public void InputE()
        {
            Input();
            Console.Write("Enter work experience (in age): ");
            experience = int.Parse(Console.ReadLine());
            Console.Write("Enter number of educations: ");
            educations = int.Parse(Console.ReadLine());
            Console.Write("Enter number of language which you know: ");
            language = int.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine($"\nPIB: {PIB}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Work experience: {experience}");
            Console.WriteLine($"Number of educations: {educations}");
            Console.WriteLine($"Number of language: {language}");
        }
    }
}
