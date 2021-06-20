using System;
using System.IO;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCompiuter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IDictionary<string, string> Variables = new Dictionary<string, string>();
        private IDictionary<string, int> Variables_address = new Dictionary<string, int>();
        private uint step_level = 0;
        private uint start_step = 0;
        private string[] command_array;

        private void Form1_Load(object sender, EventArgs e)
        {
            //set default numbers in Ram table
           // datagrid_ram.Rows.Add(1024);

            for(int i=0; i<4096; i++)
            {
                datagrid_ram.Rows.Add("" , Convert.ToString(i, 16), "", "0000");
                //datagrid_ram.Rows[i].Cells["Hex"].Value = "2222";


            }
            
            //DataGridViewRow row = datagrid_ram.Rows[10];
            //Console.WriteLine(row.Cells["Hex"].Value.ToString());
            //Console.WriteLine(row.Cells["Address"].Value.ToString());

            //int row1 = datagrid_ram.Rows.Count;
            //Console.WriteLine(row1);

            


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please Enter Your Code", "Error");

            }
            else
            {
                //saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
                //saveFileDialog2.ShowDialog();
                saveFileDialog2.Title = "Save File";
                saveFileDialog2.DefaultExt = "txt";
                saveFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog2.FilterIndex = 2;
                //saveFileDialog2.CheckFileExists = true;
                //saveFileDialog2.CheckPathExists = true;

                


                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                 
                    string save_file_name = saveFileDialog2.FileName;
                    Console.WriteLine(save_file_name);
                    // Write to the file name selected.
                    // ... You can write the text from a TextBox instead of a string literal.
                    File.WriteAllText(save_file_name, txt_code.Text );
                    string[] split_name = save_file_name.Split('\\');
                    lbl_current_file_name.Text = split_name[split_name.Length - 1];

                    //txt_code.Text = saveFileDialog1.FileName;
                }



            }

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            //saveFileDialog2.ShowDialog();
            saveFileDialog2.Title = "Load File";
            saveFileDialog2.DefaultExt = "txt";
            saveFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog2.FilterIndex = 2;
            saveFileDialog2.CheckFileExists = true;
            saveFileDialog2.CheckPathExists = true;




            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {

                string save_file_name = saveFileDialog2.FileName;
                Console.WriteLine(save_file_name);
                // Write to the file name selected.
                // ... You can write the text from a TextBox instead of a string literal.
                //File.WriteAllText(save_file_name, txt_code.Text);
                txt_code.Text = File.ReadAllText(save_file_name);
                string[] split_name = save_file_name.Split('\\');
                lbl_current_file_name.Text = split_name[split_name.Length - 1];

                //txt_code.Text = saveFileDialog1.FileName;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
        private void reset()
        {

            for (int i = 0; i < 4096; i++)
            {
                datagrid_ram.Rows[i].Cells["HEX"].Value = "0000";
                datagrid_ram.Rows[i].Cells["Instruction"].Value = "";
                datagrid_ram.Rows[i].Cells["Label"].Value = "";
                datagrid_ram.Rows[i].Cells["Address"].Value = Convert.ToString(i, 16);
            }

            RegistersClass.REG_SC = 0; // 4 bit
            RegistersClass.REG_AC = 0; // 16 bit // i should cast to short when use it.
            RegistersClass.REG_DR = 0; // 16 bit // i should cast to short when use it.
            RegistersClass.REG_AR = 0; // 12 bit
            RegistersClass.REG_IR = 0; // 16 bit 
            RegistersClass.REG_PC = 0; // 12 bit 
            RegistersClass.REG_TR = 0; // 16 bit // i should cast to short when use it.
            RegistersClass.REG_INPR = 0; // 8 bit  // i should cast to short when use it.?
            RegistersClass.REG_OUTR = 0; // 8 bit  // i should cast to short when use it.?
            RegistersClass.REG_E = 0; // 1 bit
            RegistersClass.REG_S = 0; // 1 bit
            RegistersClass.REG_I = 0; // 1 bit
            RegistersClass.REG_R = 0; // 1 bit
            RegistersClass.REG_IEN = 0; // 1 bit
            RegistersClass.REG_FGI = 0; // 1 bit
            RegistersClass.REG_FGO = 0;

            Variables.Clear();
            Variables_address.Clear();

            Update_register_values();
        }

        private void Btn_compile_Click(object sender, EventArgs e)
        {
            reset();
            //click Compile button :)))
            string all_code = txt_code.Text;
            //RegistersClass.REG_INPR =Convert.ToByte(txt_input.Text);
            int number = 0;
            if (!int.TryParse(txt_input.Text, out number))
            {
                MessageBox.Show("Invalid input :/", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RegistersClass.REG_INPR = (byte)number;

            if (all_code == "")
            {
                MessageBox.Show("Please Enter Code !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command_array = all_code.Split('\n');


            foreach (string line in command_array)
            {
                Console.WriteLine(line);

                RegistersClass.REG_PC += 1;

                Console.WriteLine(line);
                if (line == "")
                    continue;

                if (line[0] == '/' && line[1] == '/')//comment :)
                {
                    RegistersClass.REG_PC -= 1;
                    continue;
                }

                string line_v2 = line.Replace("\n", "").Replace("\r", "").Replace(",","");
                string[] command = line_v2.Split(' ');
                int index = 0;
                if (Variables_address.ContainsKey(command[0]))
                {
                    index = 1;
                    line_v2 = line_v2.Replace(command[0], "");
                }
             



                if (command[0] == "ORG")//my code must start with ORG :)
                {
                    string hex_value = command[1];
                    int decValue = Convert.ToInt32(hex_value, 16);
                    RegistersClass.REG_PC = (ushort)decValue;
                    start_step = (uint)(decValue);
                    step_level = 0;
                    datagrid_ram.Rows[(int)start_step].Selected = true;

                    if (!Find_variables())
                    {
                        MessageBox.Show("Syntax Error !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else if (command[index] == "CLA")
                {
                    RegInstructions.CLA_instruction();
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CLA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];



                }
                else if (command[index] == "CLE")
                {
                    RegInstructions.CLE_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CLE_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;

                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

                }

                else if (command[index] == "CMA")
                {
                    RegInstructions.CMA_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CMA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }

                else if (command[index] == "CME")
                {
                    RegInstructions.CME_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CME_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }

                else if (command[index] == "CIR")
                {
                    RegInstructions.CIR_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CIR_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }


                else if (command[index] == "CIL")
                {
                    RegInstructions.CIL_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CIL_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

                }


                else if (command[index] == "INC")
                {
                    RegInstructions.INC_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.INC_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }

                else if (command[index] == "SPA")
                {
                    RegInstructions.SPA_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SPA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }


                else if (command[index] == "SNA")
                {
                    RegInstructions.SNA_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SNA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }


                else if (command[index] == "SZA")
                {
                    RegInstructions.SZA_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SZA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }


                else if (command[index] == "SZE")
                {
                    RegInstructions.SZE_instruction();


                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SZE_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;



                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }


                else if (command[index] == "HLT")
                {
                    RegInstructions.HLT_instruction();


                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.HLT_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }

                else if (command[index] == "AND")
                {
                    string var_name = command[index+1];
                    RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                    short reg_value_un = Convert.ToInt16(Variables[var_name]);
                    ushort reg_value = (ushort)reg_value_un;

                    RamInstructions.AND(reg_value, datagrid_ram);
                    string var_address_hex = Convert.ToString(Variables_address[var_name], 16);

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.AND_code + var_address_hex;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

                }
                else if (command[index] == "ADD")
                {

                    string var_name = command[index+1];
                    RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                    short reg_value_un = Convert.ToInt16(Variables[var_name]);
                    ushort reg_value = (ushort)reg_value_un;
                    RamInstructions.ADD(reg_value, datagrid_ram);
                    string var_address_hex = Convert.ToString(Variables_address[var_name], 16);

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.ADD_code + var_address_hex;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

                }
                else if (command[index] == "LDA")
                {

                    string var_name = command[index+1];
                    RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                    short reg_value_un = Convert.ToInt16(Variables[var_name]);
                    ushort reg_value = (ushort)reg_value_un;
                    RamInstructions.LDA(reg_value , datagrid_ram);
                    string var_address_hex = Convert.ToString(Variables_address[var_name], 16);

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.LDA_code + var_address_hex;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

                }
                else if (command[index] == "STA")
                {

                    string var_name = command[index+1];
                    RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                    Variables[var_name] = Convert.ToString(RegistersClass.REG_AC);
                    RamInstructions.STA(RegistersClass.REG_AR, datagrid_ram);
                    string var_address_hex = Convert.ToString(Variables_address[var_name], 16);

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.STA_code + var_address_hex;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }
                else if (command[index] == "BUN")// BUN (HEX Address)
                {
                    string label = command[index+1];
                    int dec_addr = Variables_address[label];
                    ushort address = (ushort)dec_addr;
                    RamInstructions.BUN(address, datagrid_ram);

                    string var_address_hex = Convert.ToString(Variables_address[label], 16);


                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.BUN_code + var_address_hex;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;

                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

                }
                else if (command[index] == "BSA")
                {
                    string label = command[index + 1];
                    int dec_addr = Variables_address[label];
                    ushort address = (ushort)dec_addr;
                    RamInstructions.BSA(address, datagrid_ram);

                    string var_address_hex = Convert.ToString(Variables_address[label], 16);

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.BSA_code + var_address_hex;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }
                else if (command[index] == "ISZ")
                {

                    string var_name = command[index+1];
                    string var_address_hex = Convert.ToString(Variables_address[var_name], 16);

                    RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                    short reg_variable_v1 =Convert.ToInt16(Variables[var_name]);
                    ushort reg_variable = (ushort)reg_variable_v1;
                    reg_variable += 1;
                    Variables[var_name] = Convert.ToString(reg_variable);
                    RamInstructions.ISZ(reg_variable, datagrid_ram);


                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.BSA_code + var_address_hex;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;



                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }
                else if (command[index] == "INP")
                {
                    IOInstructions.INP();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.INP_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }

                else if (command[index] == "OUT")
                {

                    IOInstructions.OUT();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.OUT_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;



                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }
                else if (command[index] == "SKI")
                {

                    IOInstructions.SKI();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.SKI_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

                }
                else if (command[index] == "SKO")
                {

                    IOInstructions.SKO();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.SKO_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

                }
                else if (command[index] == "ION")
                {

                    IOInstructions.ION();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.ION_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
                }
                else if (command[index] == "IOF")
                {

                    IOInstructions.IOF();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.IOF_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                    if (index == 1)
                        datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

                }

                else if (command.Length == 3 && (command.Contains("HEX") || command.Contains("DEC")))
                {
                    string variable_key = command[0];
                    string variable_base = command[1];
                    string variable_value = Variables[variable_key];// base 10
                    string variable_value_hex;
                    //if (variable_base == "HEX")
                    //{
                        int base_10 = Convert.ToInt16(variable_value);
                        base_10 = (ushort)base_10;
                        variable_value = Convert.ToString(base_10, 16);
                        variable_value_hex = variable_value;
                    //}
                   // else
                   // {
                    //    short var_int = Convert.ToInt16(variable_value);
                     //   variable_value_hex = Convert.ToString(var_int, 16);
                    //}
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = variable_value_hex;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = variable_base+" "+variable_value;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = variable_key;

                }

                else if (command[0] == "END")
                {


                    MessageBox.Show("Compile successfully", "GOOD :)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                }
                
                else
                {



                    MessageBox.Show("Syntax Error !!", "Error", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                    break;
                }

                Update_register_values();
            }

        }


        private bool Find_variables()
        {
            try
            {
                Variables.Clear();
           // int index_of_table = RegistersClass.REG_PC;
                int index = 0;
                while (true)
                {

                    command_array[index] = command_array[index].Replace("\n", "").Replace("\r", "");
                    if (command_array[index] == "HLT")
                    {
                        break;

                    }

                if (command_array[index].Contains(','))
                {
                    string line = command_array[index];
                    line = line.Replace(",", "").Replace("\n", "").Replace("\r", "");

                    if (line.Contains("HEX") || line.Contains("DEC"))
                   {

                            string[] line_array = line.Split(' ');


                            string variable_key = line_array[0];
                            string variable_base = line_array[1];
                            string variable_value = line_array[2];
                            if (variable_base == "HEX")
                            {
                                int base_10 = Convert.ToInt16(variable_value, 16);
                                variable_value = Convert.ToString(base_10);
                            }

                            Variables.Add(variable_key, variable_value);
                            Variables_address.Add(variable_key, index + RegistersClass.REG_PC);
                            //command_array[index] = variable_base + " " + variable_value;

                    }
                    else
                    {
                        string[] line_array = line.Split(' ');
                        string variable_key = line_array[0];
                        Variables_address.Add(variable_key, index + RegistersClass.REG_PC);

                    }

                }

                    index++;
                }
                index++;
                while (true)
                {
                    if (command_array[index] == "END")
                        break;

                    string line = command_array[index];
                    line = line.Replace(",", "").Replace("\n", "").Replace("\r", "");

                    string[] line_array = line.Split(' ');

                    string variable_key = line_array[0];
                    string variable_base = line_array[1];
                    string variable_value = line_array[2];
                    if (variable_base == "HEX")
                    {
                        int base_10 = Convert.ToInt16(variable_value, 16);
                        variable_value = Convert.ToString(base_10);
                    }

                    Variables.Add(variable_key, variable_value);
                    Variables_address.Add(variable_key, index + RegistersClass.REG_PC);

                    //command_array[index] = "";
                    index++;
                }
             }
            catch
            {

                return false;
            }

            foreach (KeyValuePair<string, string> ele1 in Variables)
            {
                Console.WriteLine("{0} and {1}",
                            ele1.Key, ele1.Value);
            }
            foreach (KeyValuePair<string, int> ele1 in Variables_address)
            {
                Console.WriteLine("{0} and {1}",
                            ele1.Key, ele1.Value);
            }

            return true;
        }

        private void Update_register_values()
        {
            txt_AC.Text = Convert.ToString(RegistersClass.REG_AC, 16);
            txt_SC.Text = Convert.ToString(RegistersClass.REG_SC, 16);
            txt_DR.Text = Convert.ToString(RegistersClass.REG_DR, 16);
            txt_AR.Text = Convert.ToString(RegistersClass.REG_AR, 16);
            txt_IR.Text = Convert.ToString(RegistersClass.REG_IR, 16);
            txt_PC.Text = Convert.ToString(RegistersClass.REG_PC, 16);
            txt_TR.Text = Convert.ToString(RegistersClass.REG_TR, 16);
            txt_INPR.Text = Convert.ToString(RegistersClass.REG_INPR, 16);
            txt_OUTR.Text = Convert.ToString(RegistersClass.REG_OUTR, 16);
            txt_E.Text = Convert.ToString(RegistersClass.REG_E, 16);
            txt_S.Text = Convert.ToString(RegistersClass.REG_S, 16);
            txt_I.Text = Convert.ToString(RegistersClass.REG_I, 16);
            txt_R.Text = Convert.ToString(RegistersClass.REG_R, 16);
            txt_IEN.Text = Convert.ToString(RegistersClass.REG_IEN, 16);
            txt_FGI.Text = Convert.ToString(RegistersClass.REG_FGI, 16);
            txt_FGO.Text = Convert.ToString(RegistersClass.REG_FGO, 16);




        }


        private void Btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Btn_next_step_Click(object sender, EventArgs e)
        {
            if (start_step == 0)
            {
                RegistersClass.REG_SC = 0; // 4 bit
                RegistersClass.REG_AC = 0; // 16 bit // i should cast to short when use it.
                RegistersClass.REG_DR = 0; // 16 bit // i should cast to short when use it.
                RegistersClass.REG_AR = 0; // 12 bit
                RegistersClass.REG_IR = 0; // 16 bit 
                RegistersClass.REG_PC = 0; // 12 bit 
                RegistersClass.REG_TR = 0; // 16 bit // i should cast to short when use it.
                RegistersClass.REG_INPR = 0; // 8 bit  // i should cast to short when use it.?
                RegistersClass.REG_OUTR = 0; // 8 bit  // i should cast to short when use it.?
                RegistersClass.REG_E = 0; // 1 bit
                RegistersClass.REG_S = 0; // 1 bit
                RegistersClass.REG_I = 0; // 1 bit
                RegistersClass.REG_R = 0; // 1 bit
                RegistersClass.REG_IEN = 0; // 1 bit
                RegistersClass.REG_FGI = 0; // 1 bit
                RegistersClass.REG_FGO = 0;
            }

            string line = command_array[step_level];

            Console.WriteLine(line);

            RegistersClass.REG_PC += 1;

            Console.WriteLine(line);

            if (line == "")
                return;

            if (line[0] == '/' && line[1] == '/')//comment :)
            {
                RegistersClass.REG_PC -= 1;
                return;
            }

            string line_v2 = line.Replace("\n", "").Replace("\r", "").Replace(",", "");
            string[] command = line_v2.Split(' ');
            int index = 0;
            if (Variables_address.ContainsKey(command[0]))
            {
                index = 1;
                line_v2 = line_v2.Replace(command[0], "");

            }

            if (command[0] == "ORG")//my code must start with ORG :)
            {
                string hex_value = command[1];
                int decValue = Convert.ToInt32(hex_value, 16);
                RegistersClass.REG_PC = (ushort)decValue;
                start_step = (uint)(decValue);
                step_level = 0;
                /*if (!Find_variables())
                {
                    MessageBox.Show("Syntax Error !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }*/

            }
            else if (command[index] == "CLA")
            {
                RegInstructions.CLA_instruction();
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CLA_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];



            }
            else if (command[index] == "CLE")
            {
                RegInstructions.CLE_instruction();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CLE_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;

                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

            }

            else if (command[index] == "CMA")
            {
                RegInstructions.CMA_instruction();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CMA_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }

            else if (command[index] == "CME")
            {
                RegInstructions.CME_instruction();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CME_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }

            else if (command[index] == "CIR")
            {
                RegInstructions.CIR_instruction();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CIR_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }


            else if (command[index] == "CIL")
            {
                RegInstructions.CIL_instruction();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CIL_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

            }


            else if (command[index] == "INC")
            {
                RegInstructions.INC_instruction();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.INC_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }

            else if (command[index] == "SPA")
            {
                RegInstructions.SPA_instruction();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SPA_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }


            else if (command[index] == "SNA")
            {
                RegInstructions.SNA_instruction();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SNA_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }


            else if (command[index] == "SZA")
            {
                RegInstructions.SZA_instruction();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SZA_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }


            else if (command[index] == "SZE")
            {
                RegInstructions.SZE_instruction();


                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SZE_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;



                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }


            else if (command[index] == "HLT")
            {
                RegInstructions.HLT_instruction();


                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.HLT_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }

            else if (command[index] == "AND")
            {
                string var_name = command[index + 1];
                RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                short reg_value_un = Convert.ToInt16(Variables[var_name]);
                ushort reg_value = (ushort)reg_value_un;

                RamInstructions.AND(reg_value, datagrid_ram);
                string var_address_hex = Convert.ToString(Variables_address[var_name], 16);

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.AND_code + var_address_hex;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

            }
            else if (command[index] == "ADD")
            {

                string var_name = command[index + 1];
                RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                short reg_value_un = Convert.ToInt16(Variables[var_name]);
                ushort reg_value = (ushort)reg_value_un;
                RamInstructions.ADD(reg_value, datagrid_ram);
                string var_address_hex = Convert.ToString(Variables_address[var_name], 16);

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.ADD_code + var_address_hex;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

            }
            else if (command[index] == "LDA")
            {

                string var_name = command[index + 1];
                RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                short reg_value_un = Convert.ToInt16(Variables[var_name]);
                ushort reg_value = (ushort)reg_value_un;
                RamInstructions.LDA(reg_value, datagrid_ram);
                string var_address_hex = Convert.ToString(Variables_address[var_name], 16);

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.LDA_code + var_address_hex;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

            }
            else if (command[index] == "STA")
            {

                string var_name = command[index + 1];
                RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                Variables[var_name] = Convert.ToString(RegistersClass.REG_AC);
                RamInstructions.STA(RegistersClass.REG_AR, datagrid_ram);
                string var_address_hex = Convert.ToString(Variables_address[var_name], 16);

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.STA_code + var_address_hex;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }
            else if (command[index] == "BUN")// BUN (HEX Address)
            {
                string label = command[index + 1];
                int dec_addr = Variables_address[label];
                ushort address = (ushort)dec_addr;
                RamInstructions.BSA(address, datagrid_ram);

                string var_address_hex = Convert.ToString(Variables_address[label], 16);


                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RamInstructions.STA_code + var_address_hex;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;

                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

            }
            else if (command[index] == "BSA")
            {




                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }
            else if (command[index] == "ISZ")
            {

                string var_name = command[index + 1];
                RegistersClass.REG_AR = (ushort)Variables_address[var_name];
                short reg_variable_v1 = Convert.ToInt16(Variables[var_name]);
                ushort reg_variable = (ushort)reg_variable_v1;
                reg_variable += 1;
                Variables[var_name] = Convert.ToString(reg_variable);
                RamInstructions.ISZ(reg_variable, datagrid_ram);



                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }
            else if (command[index] == "INP")
            {
                IOInstructions.INP();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.INP_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }

            else if (command[index] == "OUT")
            {

                IOInstructions.OUT();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.OUT_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;



                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }
            else if (command[index] == "SKI")
            {

                IOInstructions.SKI();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.SKI_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

            }
            else if (command[index] == "SKO")
            {

                IOInstructions.SKO();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.SKO_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

            }
            else if (command[index] == "ION")
            {

                IOInstructions.ION();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.ION_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];
            }
            else if (command[index] == "IOF")
            {

                IOInstructions.IOF();

                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = IOInstructions.IOF_code;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                if (index == 1)
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = command[0];

            }

            else if (command.Length == 3 && (command.Contains("HEX") || command.Contains("DEC")))
            {
                string variable_key = command[0];
                string variable_base = command[1];
                string variable_value = Variables[variable_key];// base 10
                string variable_value_hex;
                //if (variable_base == "HEX")
                //{
                int base_10 = Convert.ToInt16(variable_value);
                base_10 = (ushort)base_10;
                variable_value = Convert.ToString(base_10, 16);
                variable_value_hex = variable_value;
                //}
                // else
                // {
                //    short var_int = Convert.ToInt16(variable_value);
                //   variable_value_hex = Convert.ToString(var_int, 16);
                //}
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = variable_value_hex;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = variable_base + " " + variable_value;
                datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Label"].Value = variable_key;

            }


            else if (command[0] == "END")
            {

                step_level = 0;
                datagrid_ram.Rows[(int)step_level + (int)start_step].Selected = false;
                datagrid_ram.Rows[(int)step_level + (int)start_step + 1].Selected = false;
                datagrid_ram.Rows[(int)step_level + (int)start_step - 1].Selected = false;

                MessageBox.Show("End :))", "GOOD :)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                return;
            }

            /*else
            {
                MessageBox.Show("Syntax Error !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }*/

            Update_register_values();

            ////////////////////////////////////////////////////////////////////////////
            datagrid_ram.Rows[(int)step_level + (int)start_step].Selected = false;

            datagrid_ram.Rows[(int)step_level + (int)start_step + 1].Selected = true;
            step_level++;

        }


    }
}
