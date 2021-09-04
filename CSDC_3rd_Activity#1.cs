using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alegroso_Activity1
{
    public partial class EmployeeRegistrationForm : Form
    {

        //initialize

        private string SkillsText;
        private string CivilStat;


        private int SelectedRow;
        private int SelectedColumn;


        //textboxes
      

        //dropdown
        // private ComboBox DropGender = new ComboBox();

        // CheckBoxes
        //private CheckBox ChkBDAD = new CheckBox();
        //private CheckBox ChkBWAD = new CheckBox();
        //private CheckBox ChkBMAD = new CheckBox();

        // radio
        //private RadioButton RSignle = new RadioButton();
        //private RadioButton RMarried = new RadioButton();
        //private RadioButton RDivoreced = new RadioButton();
        //private RadioButton RWidowed = new RadioButton();

        




        public EmployeeRegistrationForm()
        {
            InitializeComponent();
        }


        private void clear()
        {
            txtBLn.Clear();
            txtBFn.Clear();
            txtBAdd.Clear();
            DTPBd.ResetText();
            txtBAge.Clear();
            DropGender.ResetText();
            ChkBDAD.Checked = false;
            ChkBWAD.Checked = false;
            ChkBMAD.Checked = false;
            RSingle.Checked = false;
            RMarried.Checked = false;
            RDivorced.Checked = false;
            RWidowed.Checked = false;
            SkillsText = "";
            CivilStat = "";

           
        }

        private void cancel()
        {
            txtBLn.Clear();
            txtBFn.Clear();
            txtBAdd.Clear();
            DTPBd.ResetText();
            txtBAge.Clear();
            DropGender.ResetText();
            ChkBDAD.Checked = false;
            ChkBWAD.Checked = false;
            ChkBMAD.Checked = false;
            RSingle.Checked = false;
            RMarried.Checked = false;
            RDivorced.Checked = false;
            RWidowed.Checked = false;
            SkillsText = "";
            CivilStat = "";

           
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            //General Error Handling

            // checking if everything is filled
            
            if (txtBLn.Text == "" || txtBFn.Text == "" || txtBAdd.Text == "" ||  txtBAge.Text == "" || DropGender.Text == "" )
            {
                MessageApp("Oops, Looks like you didn't fill up everything uWu", "error");
            } else
            {
               // MessageApp("wew " + txtBLn.TextLength, "error");
                addtoDB();
            }

            //&& ChkBDAD.Checked && ChkBWAD.Checked && ChkBMAD.Checked && RSingle.Checked && RMarried.Checked && RWidowed.Checked && RDivorced.Checked


        }

        private void MessageApp(string m, string s)
        {
            MessageBox.Show(m, s);
        }

        private void addtoDB()
        {
            // Skills array to one Text
            if (ChkBDAD.Checked)
            {
                SkillsText += " Desktop App Development ";
                //SkillsList.Add(ChkBDAD.Name);
            }
            if (ChkBMAD.Checked)
            {
                SkillsText += " Mobile App Development ";
                // SkillsList.Add(ChkBMAD.Name);
            }
            if (ChkBWAD.Checked)
            {
                SkillsText += " Web App Development ";
                // SkillsList.Add(ChkBWAD.Name);
            }


            // Civil Chec
            if (RSingle.Checked)
            {
                CivilStat = RSingle.Text;
            }
            if (RMarried.Checked)
            {
                CivilStat = RMarried.Text;
            }
            if (RWidowed.Checked)
            {
                CivilStat = RWidowed.Text;
            }
            if (RDivorced.Checked)
            {
                CivilStat = RDivorced.Text;
            }



            //Add the data's on the Rows
            dataGridView1.Rows.Add(txtBLn.Text, txtBFn.Text, txtBAdd.Text, DTPBd.Value, txtBAge.Text.ToString(), DropGender.SelectedItem, SkillsText, CivilStat);

            MessageApp("Successfully added to database", "success");
            clear();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            MessageApp("Cleared", "success");
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageApp("Cancelled", "success");
            cancel();
        }

        private void DataRefresh(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            MessageApp("Refreshed", "success");
            
        }

        private void SelectDataGrid(object sender, EventArgs e)
        {
            Int32 selectedCellCount =
dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                for (int i = 0;
                i < selectedCellCount; i++)
                {
                    SelectedRow = dataGridView1.SelectedCells[i].RowIndex;
                    SelectedColumn = dataGridView1.SelectedCells[i].ColumnIndex;


                }

                MessageApp("Selected Cell " + dataGridView1.Rows[SelectedRow].Cells[SelectedColumn].Value, "success");
               
            }
        }

        private void DataClear(object sender, EventArgs e)
        {
            Int32 selectedCellCount =
dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                for (int i = 0;
                i < selectedCellCount; i++)
                {
                    SelectedRow = dataGridView1.SelectedCells[i].RowIndex;
                    SelectedColumn = dataGridView1.SelectedCells[i].ColumnIndex;


                }
                dataGridView1.Rows[SelectedRow].Cells[SelectedColumn].Value = "";

                MessageApp("Cleared", "success");
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
