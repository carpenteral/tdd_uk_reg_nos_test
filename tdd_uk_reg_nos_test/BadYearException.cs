using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_uk_reg_nos_test
{
    public  class BadYearException : Exception
    {
        public BadYearException( string msg ) : base( msg )
        {
        }
    }
}
