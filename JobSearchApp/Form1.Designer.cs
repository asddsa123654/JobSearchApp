namespace JobSearchApp
{
    partial class Form1
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
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            this.comboBoxSalary = new System.Windows.Forms.ComboBox();
            this.numericUpDownExperience = new System.Windows.Forms.NumericUpDown();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.ItemHeight = 16;
            this.listBoxJobs.Location = new System.Drawing.Point(41, 168);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(120, 84);
            this.listBoxJobs.TabIndex = 0;
            // 
            // comboBoxSalary
            // 
            this.comboBoxSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalary.FormattingEnabled = true;
            this.comboBoxSalary.Location = new System.Drawing.Point(498, 45);
            this.comboBoxSalary.Name = "comboBoxSalary";
            this.comboBoxSalary.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSalary.TabIndex = 1;
            this.comboBoxSalary.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalary_SelectedIndexChanged);
            // 
            // numericUpDownExperience
            // 
            this.numericUpDownExperience.Location = new System.Drawing.Point(218, 168);
            this.numericUpDownExperience.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownExperience.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExperience.Name = "numericUpDownExperience";
            this.numericUpDownExperience.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownExperience.TabIndex = 2;
            this.numericUpDownExperience.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnShowResults
            // 
            this.btnShowResults.Location = new System.Drawing.Point(207, 319);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(75, 23);
            this.btnShowResults.TabIndex = 3;
            this.btnShowResults.Text = "button1";
            this.btnShowResults.UseVisualStyleBackColor = true;
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(357, 266);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(100, 22);
            this.textBoxResults.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.numericUpDownExperience);
            this.Controls.Add(this.comboBoxSalary);
            this.Controls.Add(this.listBoxJobs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxJobs;
        private System.Windows.Forms.ComboBox comboBoxSalary;
        private System.Windows.Forms.NumericUpDown numericUpDownExperience;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.TextBox textBoxResults;
    }
}

