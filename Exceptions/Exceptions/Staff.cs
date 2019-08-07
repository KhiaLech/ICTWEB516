using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
   public class Staff: Person
    {
        public string Username { get; set; }

        public Staff(string pFName, string pSName, int pYOB, string sUser) : base (pFName, pSName, pYOB)
        {
            Username = sUser;
        }

    }
}
