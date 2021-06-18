using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BasicCompiuter
{
    class RamInstructions : RegistersClass
    {

        //private static DataGridView my_ram;
        public const string AND_code = "0";
        public const string AND_code_I = "8";
        public const string ADD_code = "1";
        public const string ADD_code_I = "9";
        public const string LDA_code = "2";
        public const string LDA_code_I = "A";
        public const string STA_code = "3";
        public const string STA_code_I = "B";
        public const string BUN_code = "4";
        public const string BUN_code_I = "C";
        public const string BSA_code = "5";
        public const string BSA_code_I = "D";
        public const string ISZ_code = "6";
        public const string ISZ_code_I = "E";

      

        public static ushort AND(ushort reg_value, DataGridView my_ram )// input = AR , RAM
        {
            //DataGridViewRow selected_row = my_ram.Rows[address_reg];
            //REG_DR = Convert.ToUInt16(selected_row.Cells["Hex"].Value.ToString(), 16);
            REG_DR = reg_value;
            REG_SC = 0;
            REG_AC = (ushort) (REG_AC & REG_DR);
            return REG_AC;

        }
         
        public static ushort ADD(ushort reg_value, DataGridView my_ram)
        {
            //how can I control signed numbers ?

            //DataGridViewRow selected_row = my_ram.Rows[address_reg];
            //REG_DR = Convert.ToUInt16(selected_row.Cells["Hex"].Value.ToString(), 16);
            REG_DR = reg_value;
            REG_SC = 0;
            int temp;
            if (REG_DR + REG_AC > 65535)
            {
                REG_E = 1;
                temp = REG_AC + REG_DR - 65536;
            }
            else
            {
                REG_E = 0;
                temp = REG_AC + REG_DR;
            }

            REG_AC = (ushort)temp;


            return REG_AC;
        }

        public static ushort LDA(ushort reg_value, DataGridView my_ram)
        {
            //DataGridViewRow selected_row = my_ram.Rows[address_reg];
            //REG_DR = Convert.ToUInt16(selected_row.Cells["Hex"].Value.ToString(), 16);
            REG_DR = reg_value;
            REG_SC = 0;
            REG_AC = REG_DR;
            //Console.WriteLine("REG AC = " + REG_AC);
            //Console.WriteLine("REG AR = " + address_reg);
            //Console.WriteLine(selected_row.Cells["Hex"].Value.ToString());

            return REG_AC;

        }

        public static ushort STA(ushort address_reg, DataGridView my_ram)
        {
            my_ram.Rows[address_reg].Cells["Hex"].Value = Convert.ToString(REG_AC, 16);
            REG_SC = 0;
            return REG_AC;
        }

        public static ushort BUN(ushort address_reg, DataGridView my_ram)
        {
            REG_SC = 0;
            REG_PC = address_reg;
            return REG_PC;
        }


        public static ushort BSA(ushort address_reg, DataGridView my_ram)
        {
            my_ram.Rows[address_reg].Cells["Hex"].Value = Convert.ToString(REG_PC, 16);
            //REG_AR = 1;
            REG_PC = REG_AR;
            REG_PC++;
            REG_SC = 0;
            return REG_PC;
        }


        public static ushort ISZ(ushort reg_variable, DataGridView my_ram)
        {
            //DataGridViewRow selected_row = my_ram.Rows[reg_varia];
            //REG_DR = Convert.ToUInt16(selected_row.Cells["Hex"].Value.ToString(), 16);
            REG_DR = reg_variable;

            
            if (reg_variable == 0)
            {
                REG_PC += 1;

            }
            REG_SC = 0;


            return REG_PC;

        }






    }
}
