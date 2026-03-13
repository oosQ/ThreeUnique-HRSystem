using ProjectDemo.ThreeUniqueDataBaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectDemo
{
    public partial class FiredEmp : Form
    {
        public FiredEmp()
        {
            InitializeComponent();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            try
            {
                employeeBindingSource1.MoveFirst();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                employeeBindingSource1.MoveNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            try
            {
                employeeBindingSource1.MovePrevious();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            try
            {
                employeeBindingSource1.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string msg, Reason , name;
            string check = employeeTableAdapter.SearchID(threeUniqueDataBaseDataSet.Employee, EmployeeIdTextBox.Text).ToString();
            int found = int.Parse(check);
            try
            {
                if (ReasonComboBox.SelectedIndex != -1)
                {
                    Reason = ReasonComboBox.SelectedItem.ToString();
                    if(EmployeeIdTextBox.Text != "")
                    {
                        name = EmployeeIdTextBox.Text;
                        if(found == 1)
                        {
                            if (SureCheckBox.Checked)
                            {
                                employeeTableAdapter.DeleteQuery(EmployeeIdTextBox.Text);
                                msg = "The Reason is : " + Reason + "\n" + "Employee Id : " + name + "\n" + "Comment : " + CommentTextBox.Text;
                                MessageBox.Show("Fired succesfully ! \n " + msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.employeeTableAdapter.Fill(this.threeUniqueDataBaseDataSet.Employee);
                                ReasonComboBox.SelectedIndex = -1;
                                EmployeeIdTextBox.Text = "";
                                CommentTextBox.Text = "";
                                SureCheckBox.Checked = false;
                                RequiredLabel.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Please Check The checkbox !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The ID Not Found !", "Id Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Id !", "Id Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EmployeeIdTextBox.Focus();
                    }
                }
                else
                {
                    RequiredLabel.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FiredEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'threeUniqueDataBaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.threeUniqueDataBaseDataSet.Employee);

        }

        private void changeBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.BackColor;
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void exitToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guidelineToolStrip_Click(object sender, EventArgs e)
        {
            Guideline guideline = new Guideline();
            guideline.FirstLabel.Text = "In the first Top we have a Fired Tool To Fired Employee , Reason wich required , Employee same required , comment not required and You Must check the checkbox ";
            guideline.SecondeLabel.Text = "Then we have details for all employee in detialView ";
            guideline.ThirdLabel.Text = "Last thing we have controls to detailview \"Make Sure you click the button save to save your change \"";
            guideline.Show();
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.threeUniqueDataBaseDataSet.Employee);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                employeeBindingSource.EndEdit();
                employeeTableAdapter.Update(threeUniqueDataBaseDataSet.Employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
