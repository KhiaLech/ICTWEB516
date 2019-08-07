using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class Admin : Staff
    {
        public int OfficeNo { get; set; }

        public Admin(string pFName, string pSName, int pYOB, string sUser, int aOffNo) : base(pFName, pSName, pYOB, sUser)
        {
            OfficeNo = aOffNo;
        }

    }
}
