namespace ListViewUI
{
    partial class fStudent
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
            this.lsvStudent = new System.Windows.Forms.ListView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteMultiple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvStudent
            // 
            this.lsvStudent.HideSelection = false;
            this.lsvStudent.Location = new System.Drawing.Point(37, 41);
            this.lsvStudent.Name = "lsvStudent";
            this.lsvStudent.Size = new System.Drawing.Size(561, 401);
            this.lsvStudent.TabIndex = 100;
            this.lsvStudent.UseCompatibleStateImageBehavior = false;
            this.lsvStudent.SelectedIndexChanged += new System.EventHandler(this.lsvStudent_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(748, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 26);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(748, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(748, 176);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(206, 26);
            this.txtAge.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(765, 256);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 40);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(870, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(654, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteMultiple
            // 
            this.btnDeleteMultiple.Location = new System.Drawing.Point(654, 323);
            this.btnDeleteMultiple.Name = "btnDeleteMultiple";
            this.btnDeleteMultiple.Size = new System.Drawing.Size(186, 40);
            this.btnDeleteMultiple.TabIndex = 5;
            this.btnDeleteMultiple.Text = "Delete multiple";
            this.btnDeleteMultiple.UseVisualStyleBackColor = true;
            this.btnDeleteMultiple.Click += new System.EventHandler(this.btnDeleteMultiple_Click);
            // 
            // fStudent
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 504);
            this.Controls.Add(this.btnDeleteMultiple);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lsvStudent);
            this.Name = "fStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.fStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvStudent;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteMultiple;
    }
}