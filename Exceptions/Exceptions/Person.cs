using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class Person
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string pFName, string pSName, int pYOB)
        {
            FName = pFName;
            SName = pSName;
            YearOfBirth = pYOB;

        }
    }
}
