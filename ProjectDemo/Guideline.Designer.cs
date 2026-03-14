namespace ProjectDemo
{
    partial class Guideline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SecondeLabel = new System.Windows.Forms.Label();
            this.ThirdLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "How To Use ?";
            // 
            // FirstLabel
            // 
            this.FirstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FirstLabel.Location = new System.Drawing.Point(77, 125);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(499, 90);
            this.FirstLabel.TabIndex = 1;
            // 
            // SecondeLabel
            // 
            this.SecondeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondeLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SecondeLabel.Location = new System.Drawing.Point(77, 240);
            this.SecondeLabel.Name = "SecondeLabel";
            this.SecondeLabel.Size = new System.Drawing.Size(499, 90);
            this.SecondeLabel.TabIndex = 2;
            // 
            // ThirdLabel
            // 
            this.ThirdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThirdLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ThirdLabel.Location = new System.Drawing.Point(77, 347);
            this.ThirdLabel.Name = "ThirdLabel";
            this.ThirdLabel.Size = new System.Drawing.Size(499, 90);
            this.ThirdLabel.TabIndex = 3;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CloseButton.Location = new System.Drawing.Point(214, 450);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(206, 45);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Guideline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(659, 528);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ThirdLabel);
            this.Controls.Add(this.SecondeLabel);
            this.Controls.Add(this.FirstLabel);
            this.Controls.Add(this.label1);
            this.Name = "Guideline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guideline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.Label FirstLabel;
        public System.Windows.Forms.Label SecondeLabel;
        public System.Windows.Forms.Label ThirdLabel;
    }
}