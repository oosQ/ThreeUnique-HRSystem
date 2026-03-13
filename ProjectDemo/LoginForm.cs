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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        // *** User:admin    Pass:root  *** //

        private void OfflineLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm main = new MainForm();
            main.serviceToolStripMenuItem.Enabled = false;
            main.PromotionButton.Enabled = false;
            main.FiredButton.Enabled = false;
            main.UpdateButton.Enabled = false;
            main.RecruitmenButton.Enabled = false;
            main.ShowDialog();
        }

        private void PasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasscheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(UserTextBox.Text != "")
                {
                    if(PasswordTextBox.Text != "")
                    {
                        string checkUser = adminRegTableAdapter.SearchUser(threeUniqueDataBaseDataSet.adminReg, UserTextBox.Text).ToString();
                        int foundUser = int.Parse(checkUser);

                        string checkPass = adminRegTableAdapter.SearchPass(threeUniqueDataBaseDataSet.adminReg, PasswordTextBox.Text).ToString();
                        int foundPass = int.Parse(checkPass);

                        if (foundUser == 1 )
                        {
                            if(foundPass == 1)
                            {
                                MessageBox.Show("Login Successfully !");
                                UserTextBox.Text = "";
                                PasswordTextBox.Text = "";
                                MainForm main = new MainForm();
                                main.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show(" Wrong Password !", "Wrong Pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username Not Found !", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Password !", "Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PasswordTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Username", "Username Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserTextBox.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
