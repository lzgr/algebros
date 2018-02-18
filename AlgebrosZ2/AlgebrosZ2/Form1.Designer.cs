namespace AlgebrosZ2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamNameTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.getTokButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eng = new System.Windows.Forms.RadioButton();
            this.cro = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teamname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // teamNameTB
            // 
            this.teamNameTB.Location = new System.Drawing.Point(102, 21);
            this.teamNameTB.Name = "teamNameTB";
            this.teamNameTB.Size = new System.Drawing.Size(100, 22);
            this.teamNameTB.TabIndex = 2;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(102, 59);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(100, 22);
            this.passTB.TabIndex = 3;
            // 
            // getTokButton
            // 
            this.getTokButton.Location = new System.Drawing.Point(15, 98);
            this.getTokButton.Name = "getTokButton";
            this.getTokButton.Size = new System.Drawing.Size(175, 32);
            this.getTokButton.TabIndex = 4;
            this.getTokButton.Text = "Get Authorization token";
            this.getTokButton.UseVisualStyleBackColor = true;
            this.getTokButton.Click += new System.EventHandler(this.getTokButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eng);
            this.groupBox1.Controls.Add(this.cro);
            this.groupBox1.Location = new System.Drawing.Point(227, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // eng
            // 
            this.eng.AutoSize = true;
            this.eng.Location = new System.Drawing.Point(15, 60);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(75, 21);
            this.eng.TabIndex = 1;
            this.eng.Text = "English";
            this.eng.UseVisualStyleBackColor = true;
            // 
            // cro
            // 
            this.cro.AutoSize = true;
            this.cro.Checked = true;
            this.cro.Location = new System.Drawing.Point(15, 33);
            this.cro.Name = "cro";
            this.cro.Size = new System.Drawing.Size(82, 21);
            this.cro.TabIndex = 0;
            this.cro.TabStop = true;
            this.cro.Text = "Croatian";
            this.cro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 142);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getTokButton);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.teamNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Algebros login form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teamNameTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button getTokButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton eng;
        private System.Windows.Forms.RadioButton cro;
    }
}

