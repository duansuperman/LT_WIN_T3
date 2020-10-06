namespace ComboboxUI
{
    partial class Form2
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
            this.cbCategoryFood = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbCategoryFood
            // 
            this.cbCategoryFood.FormattingEnabled = true;
            this.cbCategoryFood.Location = new System.Drawing.Point(129, 156);
            this.cbCategoryFood.Name = "cbCategoryFood";
            this.cbCategoryFood.Size = new System.Drawing.Size(189, 28);
            this.cbCategoryFood.TabIndex = 0;
            this.cbCategoryFood.SelectedValueChanged += new System.EventHandler(this.cbCategoryFood_SelectedValueChanged);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(424, 156);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(184, 28);
            this.cbFood.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.cbCategoryFood);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategoryFood;
        private System.Windows.Forms.ComboBox cbFood;
    }
}