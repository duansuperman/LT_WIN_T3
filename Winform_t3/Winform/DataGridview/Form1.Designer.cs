namespace DataGridview
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
            this.dtgvPerson = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPerson
            // 
            this.dtgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPerson.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PersonName,
            this.Age});
            this.dtgvPerson.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvPerson.Location = new System.Drawing.Point(50, 100);
            this.dtgvPerson.Name = "dtgvPerson";
            this.dtgvPerson.RowHeadersWidth = 62;
            this.dtgvPerson.RowTemplate.Height = 28;
            this.dtgvPerson.Size = new System.Drawing.Size(676, 299);
            this.dtgvPerson.TabIndex = 0;
            this.dtgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPerson_CellClick);
            this.dtgvPerson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgvPerson_KeyDown);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "Name";
            this.PersonName.MinimumWidth = 8;
            this.PersonName.Name = "PersonName";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 499);
            this.Controls.Add(this.dtgvPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}

