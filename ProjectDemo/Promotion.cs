using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDemo
{
    public partial class Promotion : Form
    {
        public Promotion()
        {
            InitializeComponent();
        }

        public void ErrorMessage(string msg, string caption, TextBox textBox)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Focus();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.threeUniqueDataBaseDataSet);

        }

        private void Promotion_Load(object sender, EventArgs e)
        {
 
        }

        private void HighButton_Click(object sender, EventArgs e)
        {
            decimal maxSalary;
            try
            {
                maxSalary = (decimal)employeeTableAdapter.HighSalary();
                MessageBox.Show("High Salary : " + maxSalary.ToString("c"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LessButton_Click(object sender, EventArgs e)
        {
            decimal LessSalary;
            try
            {
                LessSalary = (decimal)employeeTableAdapter.MinSalary();
                MessageBox.Show("Less Salary : " + LessSalary.ToString("c"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            int count;
            try
            {
                count = (int)employeeTableAdapter.TotalEmp();
                MessageBox.Show("Total Employee : " + count.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(ShowAll.Checked || ManagerRadio.Checked || SalaryRadio.Checked || AgeRadio.Checked || BetweenHIREDRadio.Checked || StartWithARadio.Checked || OrderByDOBRadio.Checked)
                {
                    if (SalaryRadio.Checked)
                    {
                        employeeTableAdapter.LessThanOrEqual(threeUniqueDataBaseDataSet.Employee);
                    }
                    else if (AgeRadio.Checked)
                    {
                        employeeTableAdapter.AgeLessThan35(threeUniqueDataBaseDataSet.Employee);
                    }
                    else if (StartWithARadio.Checked)
                    {
                        employeeTableAdapter.StartWithA(threeUniqueDataBaseDataSet.Employee);
                    }
                    else if (OrderByDOBRadio.Checked)
                    {
                        employeeTableAdapter.SortByDOB(threeUniqueDataBaseDataSet.Employee);
                    }
                    else if (BetweenHIREDRadio.Checked)
                    {
                        employeeTableAdapter.HIREDATEQUERY(threeUniqueDataBaseDataSet.Employee);
                    }
                    else if (ManagerRadio.Checked)
                    {
                        employeeTableAdapter.LikeManager(threeUniqueDataBaseDataSet.Employee);
                    }
                    else
                    {
                        employeeTableAdapter.Fill(threeUniqueDataBaseDataSet.Employee);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Radio Button !", "Selected Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PromotionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NewSalaryTextBox.Text != "")
                {
                    if (NewJobTextBox.Text != "")
                    {
                        if (IDTextBox.Text != "")
                        {
                            string check = employeeTableAdapter.SearchID(threeUniqueDataBaseDataSet.Employee, IDTextBox.Text).ToString();
                            int found = int.Parse(check);
                            if (found != 1)
                            {
                                ErrorMessage("The ID Not Found", "Error", IDTextBox);
                            }
                            else
                            {
                                employeeTableAdapter.UpdateQuery(decimal.Parse(NewSalaryTextBox.Text), NewJobTextBox.Text, IDTextBox.Text);
                                this.employeeTableAdapter.Fill(threeUniqueDataBaseDataSet.Employee);
                                MessageBox.Show("Promotion successfuly");
                                NewSalaryTextBox.Text = "";
                                NewJobTextBox.Text = "";
                                IDTextBox.Text = "";
                            }
                        }
                        else
                        {
                            
                            ErrorMessage("Please Enter ID !", "iD Missing", IDTextBox);
                        }
                    }
                    else
                    {
                        ErrorMessage("Please Enter New Job !", "Job Missing", NewJobTextBox);
                    }
                }
                else
                {
                    ErrorMessage("Please Enter New Salary !", "Salary Missing", NewSalaryTextBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string check = employeeTableAdapter.SearchID(threeUniqueDataBaseDataSet.Employee, SearchTextBox.Text).ToString();
                int found = int.Parse(check);
                if(found != 1)
                {
                    ErrorMessage("The ID Not Found", "Error", SearchTextBox);
                    this.employeeTableAdapter.Fill(threeUniqueDataBaseDataSet.Employee);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(SearchTextBox.Text != "")
            {
                SearchButton.Enabled = true;
            }
            else
            {
                SearchButton.Enabled = false;
            }
        }

        private void guidelineToolStrip_Click(object sender, EventArgs e)
        {
            Guideline guideline = new Guideline();
            guideline.FirstLabel.Text = "In the top left form You have a promotion GroupBox with three textbox , First textbox for the new salary and seconde one for new postion or job and last one for who want to do promotion you must enter EmpID";
            guideline.SecondeLabel.Text = "In the down left You will See EmpId GroupBox To Search For Sepecific EmployeeId";
            guideline.ThirdLabel.Text = "Other GruopBox To sort the Gridview by specefic query , and three button For High & Min salary with Count Employee Button";
            guideline.Show();

        }

        private void exitToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
