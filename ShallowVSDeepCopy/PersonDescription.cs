using System;
using System.Collections.Generic;
using System.Text;

namespace ShallowVSDeepCopy
{
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
