namespace AlgebrosZ1
{
    partial class Slijedeci
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
            this.nxtTask = new System.Windows.Forms.Label();
            this.nxtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Next task:";
            // 
            // nxtTask
            // 
            this.nxtTask.AutoSize = true;
            this.nxtTask.Location = new System.Drawing.Point(90, 13);
            this.nxtTask.Name = "nxtTask";
            this.nxtTask.Size = new System.Drawing.Size(0, 17);
            this.nxtTask.TabIndex = 1;
            // 
            // nxtButton
            // 
            this.nxtButton.Location = new System.Drawing.Point(16, 44);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(131, 36);
            this.nxtButton.TabIndex = 2;
            this.nxtButton.Text = "Open next task";
            this.nxtButton.UseVisualStyleBackColor = true;
            this.nxtButton.Click += new System.EventHandler(this.nxtButton_Click);
            // 
            // Slijedeci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(474, 93);
            this.Controls.Add(this.nxtButton);
            this.Controls.Add(this.nxtTask);
            this.Controls.Add(this.label1);
            this.Name = "Slijedeci";
            this.Text = "Next task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nxtTask;
        private System.Windows.Forms.Button nxtButton;
    }
}