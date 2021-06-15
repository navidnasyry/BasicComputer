using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BasicCompiuter
{
    class RegistersClass
    {
        private static Int32 AC; // 16 bit
        private static Int32 DR; // 16 bit
        private static Int32 AR; // 12 bit
        private static Int32 IR; // 16 bit
        private static Int32 PC; // 12 bit
        private static Int32 TR; // 16 bit
        private static Int32 INPR; // 8 bit
        private static Int32 OUTR; // 8 bit



        public static Int32 REG_AC {
            get
            {
                return AC;

            }
            set
            {
                if (value >= 0 && value <= 65535)
                {
                    AC = value;
                }
                else
                {
                    MessageBox.Show("AC is 16 Bit !!", "Error");
                }

            }

        }

        public static Int32 REG_DR
        {
            get
            {
                return DR;

            }
            set
            {
                if (value >= 0 && value <= 65535)
                {
                    DR = value;
                }
                else
                {
                    MessageBox.Show("DR is 16 Bit !!", "Error");
                }

            }

        }

        public static Int32 REG_AR
        {
            get
            {
                return AR;

            }
            set
            {
                if (value >= 0 && value <= 4095)
                {
                    AR = value;
                }
                else
                {
                    MessageBox.Show("AR is 12 Bit !!", "Error");
                }

            }

        }

        public static Int32 REG_IR
        {
            get
            {
                return IR;

            }
            set
            {
                if (value >= 0 && value <= 65535)
                {
                    IR = value;
                }
                else
                {
                    MessageBox.Show("IR is 16 Bit !!", "Error");
                }

            }

        }


        public static Int32 REG_PC
        {
            get
            {
                return PC;

            }
            set
            {
                if (value >= 0 && value <= 4095)
                {
                    PC = value;
                }
                else
                {
                    MessageBox.Show("PC is 12 Bit !!", "Error");
                }

            }

        }


        public static Int32 REG_TR
        {
            get
            {
                return TR;

            }
            set
            {
                if (value >= 0 && value <= 65535)
                {
                    TR = value;
                }
                else
                {
                    MessageBox.Show("TR is 16 Bit !!", "Error");
                }

            }

        }


        public static Int32 REG_INPR
        {
            get
            {
                return INPR;

            }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    INPR = value;
                }
                else
                {
                    MessageBox.Show("INPR is 8 Bit !!", "Error");
                }

            }

        }


        public static Int32 REG_OUTR
        {
            get
            {
                return OUTR;

            }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    OUTR = value;
                }
                else
                {
                    MessageBox.Show("OUTR is 8 Bit !!", "Error");
                }

            }

        }



    }
}
