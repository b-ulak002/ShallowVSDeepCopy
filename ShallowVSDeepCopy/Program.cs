using System;

namespace ShallowVSDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            Person p1 = new Person(15, "Bob", "Henry");
            Person p2 = (Person)p1.ShallowCopy();

            p2.desc.FirstName = "Jack";
            p2.Age = 10;

            Console.WriteLine($"p1 Firstname = {p1.desc.FirstName}");
            Console.WriteLine($"p2 Firstname = {p2.desc.FirstName}");
            Console.WriteLine($"p1 age = {p1.Age}");
            Console.WriteLine($"p2 age = {p2.Age}");

            Console.WriteLine("\nDeep Copy");
            Person p3 = new Person(12, "Tim", "Bauer");
            Person p4 = p3.DeepCopy();
            p4.desc.FirstName = "Shane";
            
            p4.Age = 20;
            Console.WriteLine(p3.Age);
            Console.WriteLine(p4.Age);
            Console.WriteLine($"p3 Firstname = {p3.desc.FirstName}");
            Console.WriteLine($"p4 Firstname = {p4.desc.FirstName}");

        }
    }

    class Person
    {
        public int Age;
        public PersonDescription desc;
        public Person(int age, string f, string l)
        {
            this.Age = age;
            desc = new PersonDescription(f, l);
        }
        public object ShallowCopy()
        {
            //creates a shallow copy of the current object
            return this.MemberwiseClone();
        }
        public Person DeepCopy()
        {
            Person deepCopyPerson = new Person(this.Age, desc.FirstName, desc.LastName);
            return deepCopyPerson;
        }
    }
    class PersonDescription
    {
        public string FirstName;
        public string LastName;

        public PersonDescription(string f, string l)
        {
            this.FirstName = f;
            this.LastName = l;
        }
    }
}

        
