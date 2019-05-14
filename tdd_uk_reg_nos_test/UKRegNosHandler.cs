using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_uk_reg_nos_test
{
    class UKRegNosHandler
    {
        public  String  nextRegCode( String currentValue )
        {
            String result = "";

            int regNo = Int32.Parse( currentValue );
            if (regNo > 50)
            {
                regNo -= 49;
                result = regNo.ToString("D2").Substring(0, 2);
            }
            else
            {
                if (regNo == 50)
                    throw new BadYearException("2050 is an invalid year");
                else
                {
                    regNo += 50;
                    result = regNo.ToString("D2");
                }
            }

            return result;
        }
    }
}
