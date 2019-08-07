
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class Student : Person
    {
        public int Id { get; set; }
        public Student(string pFName, string pSName, int pYOB, int sId) : base(pFName, pSName, pYOB)
        {
            Id = sId;
        }

    }
}
