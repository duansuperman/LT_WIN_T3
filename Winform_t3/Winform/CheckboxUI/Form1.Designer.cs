namespace CheckboxUI
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
            this.ckbMale = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ckbMale
            // 
            this.ckbMale.AutoSize = true;
            this.ckbMale.Location = new System.Drawing.Point(241, 150);
            this.ckbMale.Name = "ckbMale";
            this.ckbMale.Size = new System.Drawing.Size(69, 24);
            this.ckbMale.TabIndex = 0;
            this.ckbMale.Text = "Male";
            this.ckbMale.ThreeState = true;
            this.ckbMale.UseVisualStyleBackColor = true;
            this.ckbMale.CheckedChanged += new System.EventHandler(this.ckbMale_CheckedChanged);
            this.ckbMale.CheckStateChanged += new System.EventHandler(this.ckbMale_CheckStateChanged);
            this.ckbMale.Click += new System.EventHandler(this.ckbMale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbMale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbMale;
    }
}

