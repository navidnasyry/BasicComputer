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
        private static ushort AC; // 16 bit
        private static ushort DR; // 16 bit
        private static ushort AR; // 12 bit
        private static ushort IR; // 16 bit
        private static ushort PC; // 12 bit
        private static ushort TR; // 16 bit
        private static byte INPR; // 8 bit
        private static byte OUTR; // 8 bit
        private static byte E; // 1 bit



        public static ushort REG_AC {
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

        public static ushort REG_DR
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

        public static ushort REG_AR
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

        public static ushort REG_IR
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


        public static ushort REG_PC
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


        public static ushort REG_TR
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


        public static byte REG_INPR
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


        public static byte REG_OUTR
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



        public static byte REG_E
        {
            get
            {
                return E;

            }
            set
            {
                if (value >= 0 && value <= 1)
                {
                    E = value;
                }
                else
                {
                    MessageBox.Show("E is 1 Bit !!", "Error");
                }

            }

        }

    }
}
