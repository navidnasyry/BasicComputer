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
        public const string SNA_code = "7008";
        public const string SZE_code = "7002";
        public const string SZA_code = "7004";
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


        public static bool CIR_instruction()
        {
            byte right_bit = 0;
            ushort add_e = 0;

            //is last bit 1 ?
            if (REG_AC % 2 == 1)
            {
                right_bit = 1;
            }

            // is E 1 ?
            if (REG_E >= 1)
            {
                add_e = 32768;
            }

            REG_AC = (ushort)(REG_AC >> 1);// shift right
            REG_AC += add_e;
            REG_E = right_bit; // fill E

            return true;
        }


        public static bool CIL_instruction()
        {
            //string bitwise_str = Convert.ToString(REG_AC);
            //ushort left_bit =(ushort) Convert.ToUInt16(bitwise_str, 2);
            byte left_bit= 0;
            if (REG_AC >= 32768)
            {
                left_bit = 1;
            }
            else
            {
                left_bit = 0;
            }


            REG_AC = (ushort)(REG_AC << 1);
            REG_AC += REG_E;
            REG_E = left_bit;



            return true;
        }

        public static bool INC_instruction()
        {
            REG_AC += 1;

            return true;
        }

        public static bool SPA_instruction()
        {
            // AC[15] == 0
            if (REG_AC < 32768)
            {
                REG_PC += 1;
            }
            return true;
        }

        public static bool SNA_instruction()
        {
            if (REG_AC >= 32768)
            {
                REG_PC += 1;
            }

            return true;
        }


        public static bool SZA_instruction()
        {
            if (REG_AC == 0)
            {
                REG_PC += 1;
            }

            return true;
        }
         

        public static bool SZE_instruction()
        {
            if (REG_E == 0)
            {
                REG_PC += 1;
            }

            return true;
        }


        public static bool HLT_instruction()
        {
            REG_S = 0;
            // and ??

            return true;
        }
    }
}
