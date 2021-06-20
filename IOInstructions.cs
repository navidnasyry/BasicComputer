using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCompiuter
{
    class IOInstructions : RegistersClass
    {
        public const string INP_code = "F800";
        public const string OUT_code= "F400";
        public const string SKI_code = "F200";
        public const string SKO_code = "F100";
        public const string ION_code = "F080";
        public const string IOF_code = "F040";



        public static void INP()
        {
            REG_FGI = 0;
            REG_AC = REG_INPR;//AC[0:7] <= INPR

        }

        public static void OUT()
        {
            REG_OUTR = (byte)REG_AC;
            REG_FGO = 0;

        }


        public static void SKI()
        {
            if (REG_FGI == 1)
                REG_PC += 1;
        }

        public static void SKO()
        {
            if (REG_FGO == 1)
                REG_PC += 1;
        }

        public static void ION()
        {
            REG_IEN = 1;
        }

        public static void IOF()
        {
            REG_IEN = 0;
        }



    }
}
