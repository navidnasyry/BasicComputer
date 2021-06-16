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

        private void Btn_compile_Click(object sender, EventArgs e)
        {

            //click Compile btn :)))
            string all_code = txt_code.Text;
            string[] command_array = all_code.Split('\n');
            foreach (string line in command_array)
            {
                Console.WriteLine(line);

                RegistersClass.REG_PC += 1;


                if (line == "")
                    continue;

                if (line[0] == '/' && line[1] == '/')//comment :)
                    continue;

                string line_v2 = line.Replace("\n", "").Replace("\r", "");
                string[] command = line_v2.Split(' ');

                if (command[0] == "ORG")
                {
                    string hex_value = command[1];
                    int decValue = Convert.ToInt32(hex_value, 16);
                    RegistersClass.REG_PC = (ushort)decValue;


                }
                else if (command[0] == "CLA")
                {
                    RegInstructions.CLA_instruction();
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CLA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;


                }
                else if (command[0] == "CLE")
                {
                    RegInstructions.CLE_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CLE_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;

                }

                else if (command[0] == "CMA")
                {
                    RegInstructions.CMA_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CMA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }

                else if (command[0] == "CME")
                {
                    RegInstructions.CME_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CME_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }

                else if (command[0] == "CIR")
                {
                    RegInstructions.CIR_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CIR_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }


                else if (command[0] == "CIL")
                {
                    RegInstructions.CIL_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.CIL_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }


                else if (command[0] == "INC")
                {
                    RegInstructions.INC_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.INC_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }

                else if (command[0] == "SPA")
                {
                    RegInstructions.SPA_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SPA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }


                else if (command[0] == "SNA")
                {
                    RegInstructions.SNA_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SNA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }


                else if (command[0] == "SZA")
                {
                    RegInstructions.SZA_instruction();

                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SZA_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }


                else if (command[0] == "SZE")
                {
                    RegInstructions.SZE_instruction();


                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.SZE_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }


                else if (command[0] == "HLT")
                {
                    RegInstructions.HLT_instruction();


                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["HEX"].Value = RegInstructions.HLT_code;
                    datagrid_ram.Rows[RegInstructions.REG_PC].Cells["Instruction"].Value = line_v2;
                }

                else
                {
                    MessageBox.Show("Syntax Error !!", "Error", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                    break;
                }

                Update_register_values();
            }

        }



        private void Update_register_values()
        {
            txt_AC.Text = Convert.ToString(RegistersClass.REG_AC);
            txt_SC.Text = Convert.ToString(RegistersClass.REG_SC);
            txt_DR.Text = Convert.ToString(RegistersClass.REG_DR);
            txt_AR.Text = Convert.ToString(RegistersClass.REG_AR);
            txt_IR.Text = Convert.ToString(RegistersClass.REG_IR);
            txt_PC.Text = Convert.ToString(RegistersClass.REG_PC);
            txt_TR.Text = Convert.ToString(RegistersClass.REG_TR);
            txt_INPR.Text = Convert.ToString(RegistersClass.REG_INPR);
            txt_OUTR.Text = Convert.ToString(RegistersClass.REG_OUTR);
            txt_E.Text = Convert.ToString(RegistersClass.REG_E);
            txt_S.Text = Convert.ToString(RegistersClass.REG_S);
            txt_I.Text = Convert.ToString(RegistersClass.REG_I);
            txt_R.Text = Convert.ToString(RegistersClass.REG_R);
            txt_IEN.Text = Convert.ToString(RegistersClass.REG_IEN);
            txt_FGI.Text = Convert.ToString(RegistersClass.REG_FGI);
            txt_FGO.Text = Convert.ToString(RegistersClass.REG_FGO);




        }
    }
}
