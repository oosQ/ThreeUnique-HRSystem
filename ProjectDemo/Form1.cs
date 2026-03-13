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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void changeBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = this.BackColor;
            ColorDialog.ShowDialog();
            this.BackColor = ColorDialog.Color;
        }

        private void changeFont_Click(object sender, EventArgs e)
        {
            FontDialog.Font = this.TitleLabel.Font;
            FontDialog.ShowDialog();
            this.TitleLabel.Font = FontDialog.Font;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult myResponse = MessageBox.Show("Are you sure you want to exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (myResponse == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PromotionButton_Click(object sender, EventArgs e)
        {
            Promotion promotion = new Promotion();
            promotion.ShowDialog();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxCompany aboutBoxCompany = new AboutBoxCompany();
            aboutBoxCompany.Show();
        }

        private void FiredButton_Click(object sender, EventArgs e)
        {
            FiredEmp firedForm = new FiredEmp();
            firedForm.ShowDialog();
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promotion promotion = new Promotion();
            promotion.ShowDialog();
        }

        private void fireEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiredEmp firedForm = new FiredEmp();
            firedForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateForm update = new UpdateForm();
            update.ShowDialog();
        }

        private void RecruitmenButton_Click(object sender, EventArgs e)
        {
            Recruitment recruitment = new Recruitment();
            recruitment.ShowDialog();
        }

        private void updateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm update = new UpdateForm();
            update.ShowDialog();
        }

        private void RecruitmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recruitment recruitment = new Recruitment();
            recruitment.ShowDialog();
        }
    }
}
