using System;
using System.Collections.Generic;
using System.Text;

namespace ShallowVSDeepCopy
{
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
}

    


