using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCompiuter 
{
    class RegInstructions : RegistersClass
    {

        //hex
        public const string CLA_code = "7800";
        public const string CLE_code = "7400";
        public const string CMA_code = "7200";
        public const string CME_code = "7100";
        public const string CIR_code = "7080";
        public const string CIL_code = "7040";
        public const string INC_code = "7020";
        public const string SPA_code = "7010";
        public const string SNA_code = "7004";
        public const string SZE_code = "1002";
        public const string HLT_code = "7001";


        public static bool CLA_instruction()
        {
            REG_AC = 0;

            return true;
        }

        public static bool CLE_instruction()
        {
            REG_E = 0;

            return true;
        }

        public static bool CMA_instruction()
        {
            //Complement AC
            REG_AC = (ushort) ~REG_AC;
            return true;
        }

        public static bool CME_instruction()
        {
           switch(REG_E)
            {
                case 0:
                    REG_E = 1;
                    break;
                case 1:
                    REG_E = 0;
                    break;
                default:
                    return false;
            }

            return true;
        }




    }
}
