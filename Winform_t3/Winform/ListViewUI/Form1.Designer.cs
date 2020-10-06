namespace ListViewUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item1",
            "2",
            "3"}, 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item2",
            "2",
            "3"}, 1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item3",
            "2",
            "3"}, 2);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item4",
            "2",
            "3"}, 3);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lsvShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeSML = new System.Windows.Forms.ImageList(this.components);
            this.smallIML = new System.Windows.Forms.ImageList(this.components);
            this.btnShowSelectedItem = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvShow
            // 
            this.lsvShow.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lsvShow.CheckBoxes = true;
            this.lsvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvShow.HideSelection = false;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            this.lsvShow.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lsvShow.LargeImageList = this.largeSML;
            this.lsvShow.Location = new System.Drawing.Point(68, 50);
            this.lsvShow.Name = "lsvShow";
            this.lsvShow.Size = new System.Drawing.Size(609, 388);
            this.lsvShow.SmallImageList = this.smallIML;
            this.lsvShow.TabIndex = 0;
            this.lsvShow.UseCompatibleStateImageBehavior = false;
            this.lsvShow.View = System.Windows.Forms.View.Details;
            this.lsvShow.SelectedIndexChanged += new System.EventHandler(this.lsvShow_SelectedIndexChanged);
            this.lsvShow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvShow_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Column1";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Column2";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Column3";
            this.columnHeader3.Width = 147;
            // 
            // largeSML
            // 
            this.largeSML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeSML.ImageStream")));
            this.largeSML.TransparentColor = System.Drawing.Color.Transparent;
            this.largeSML.Images.SetKeyName(0, "luffy1.jpg");
            this.largeSML.Images.SetKeyName(1, "luffy2.png");
            this.largeSML.Images.SetKeyName(2, "luffy3.jpg");
            // 
            // smallIML
            // 
            this.smallIML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallIML.ImageStream")));
            this.smallIML.TransparentColor = System.Drawing.Color.Transparent;
            this.smallIML.Images.SetKeyName(0, "luffy1.jpg");
            this.smallIML.Images.SetKeyName(1, "luffy2.png");
            this.smallIML.Images.SetKeyName(2, "luffy3.jpg");
            this.smallIML.Images.SetKeyName(3, "luffy4.jpg");
            // 
            // btnShowSelectedItem
            // 
            this.btnShowSelectedItem.Location = new System.Drawing.Point(845, 116);
            this.btnShowSelectedItem.Name = "btnShowSelectedItem";
            this.btnShowSelectedItem.Size = new System.Drawing.Size(170, 84);
            this.btnShowSelectedItem.TabIndex = 1;
            this.btnShowSelectedItem.Text = "Show item selected";
            this.btnShowSelectedItem.UseVisualStyleBackColor = true;
            this.btnShowSelectedItem.Click += new System.EventHandler(this.btnShowSelectedItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(845, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 84);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowSelectedItem);
            this.Controls.Add(this.lsvShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList smallIML;
        private System.Windows.Forms.ImageList largeSML;
        private System.Windows.Forms.Button btnShowSelectedItem;
        private System.Windows.Forms.Button btnDelete;
    }
}

