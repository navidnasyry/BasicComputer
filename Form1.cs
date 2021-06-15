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

            for(int i=0; i<1024; i++)
            {
                datagrid_ram.Rows.Add("" , Convert.ToString(i), "", "");
            }


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
                saveFileDialog2.CheckPathExists = true;

                


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
    }
}
