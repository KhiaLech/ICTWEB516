using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class Teacher : Staff
    {
        public string Expertise { get; set; }

        public Teacher(string pFName, string pSName, int pYOB, string sUser, string tExp) : base(pFName, pSName, pYOB, sUser)
        {
            Expertise = tExp;
        }

    }
}
