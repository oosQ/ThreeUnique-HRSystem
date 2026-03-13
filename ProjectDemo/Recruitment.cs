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
    public partial class Recruitment : Form
    {
        public Recruitment()
        {
            InitializeComponent();
        }

        private void Recruitment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'threeUniqueDataBaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.threeUniqueDataBaseDataSet.Employee);

        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.threeUniqueDataBaseDataSet);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Guideline guideline = new Guideline();
            guideline.FirstLabel.Text = "In the first Top we have a Recruitment Tool To Recruitment Employee  ";
            guideline.SecondeLabel.Text = "Then we have enter the all details for the employee we wont to recruitment";
            guideline.ThirdLabel.Text = "Last thing press the 'Add New Employee button' after that we can see the employee inside the table in the end of The form \" Don't Forget to press save navigator\" ";
            guideline.Show();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            // Random class to generate a Employee ID           
            Random Random = new Random();
            int RandomNum = Random.Next(10000, 99999);
            string EmployeeID = "E-00" + RandomNum.ToString();

                if (fname_textBox.Text != "" && Lname_textBox.Text != "" && dob_textBox.Text != "" && jop_textBox.Text != "" && hiredate_textBox.Text != "" && salary_textBox.Text != "" && dob_textBox.Text != "")
                {
                try
                {
                    ThreeUniqueDataBaseDataSet.EmployeeRow Rows;
                    Rows = threeUniqueDataBaseDataSet.Employee.NewEmployeeRow();
                    Rows.EmpID = EmployeeID;
                    Rows.First_Name = fname_textBox.Text;
                    Rows.Last_Name = Lname_textBox.Text;
                    Rows.Age = int.Parse(age_textBox.Text);
                    Rows.Job = jop_textBox.Text;
                    Rows.HIREDATE = DateTime.Parse(hiredate_textBox.Text);
                    Rows.Salary = decimal.Parse(salary_textBox.Text);
                    Rows.Phone = phone_textBox.Text;
                    Rows.Email = email_textBox.Text;
                    Rows.DOB = DateTime.Parse(dob_textBox.Text);
                    Rows.Address = address_textBox.Text;
                    threeUniqueDataBaseDataSet.Employee.Rows.Add(Rows);

                    MessageBox.Show("The Emplyee Was Successfully Added ", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    fname_textBox.Text = "";
                    Lname_textBox.Text = "";
                    age_textBox.Text = "";
                    dob_textBox.Text = "";
                    jop_textBox.Text = "";
                    hiredate_textBox.Text = "";
                    salary_textBox.Text = "";
                    dob_textBox.Text = "";
                    phone_textBox.Text = "";
                    email_textBox.Text = "";
                    address_textBox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                }
                else
                {
                    MessageBox.Show("Please Enter The Required Details !", "Required Field Missing ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
