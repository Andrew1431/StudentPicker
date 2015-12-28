namespace StudentPicker
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grade9ClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grade10ClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grade11ClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grade12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstUnselected = new System.Windows.Forms.ListBox();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.trackEntries = new System.Windows.Forms.TrackBar();
            this.lblEntries = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shuffleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grade9ClassToolStripMenuItem,
            this.grade10ClassToolStripMenuItem,
            this.grade11ClassToolStripMenuItem,
            this.grade12ToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // grade9ClassToolStripMenuItem
            // 
            this.grade9ClassToolStripMenuItem.Name = "grade9ClassToolStripMenuItem";
            this.grade9ClassToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.grade9ClassToolStripMenuItem.Text = "Grade 9";
            this.grade9ClassToolStripMenuItem.Click += new System.EventHandler(this.newClassToolStripMenuItem_Click);
            // 
            // grade10ClassToolStripMenuItem
            // 
            this.grade10ClassToolStripMenuItem.Name = "grade10ClassToolStripMenuItem";
            this.grade10ClassToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.grade10ClassToolStripMenuItem.Text = "Grade 10";
            this.grade10ClassToolStripMenuItem.Click += new System.EventHandler(this.grade10ClassToolStripMenuItem_Click);
            // 
            // grade11ClassToolStripMenuItem
            // 
            this.grade11ClassToolStripMenuItem.Name = "grade11ClassToolStripMenuItem";
            this.grade11ClassToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.grade11ClassToolStripMenuItem.Text = "Grade 11";
            this.grade11ClassToolStripMenuItem.Click += new System.EventHandler(this.grade11ClassToolStripMenuItem_Click);
            // 
            // grade12ToolStripMenuItem
            // 
            this.grade12ToolStripMenuItem.Name = "grade12ToolStripMenuItem";
            this.grade12ToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.grade12ToolStripMenuItem.Text = "Grade 12";
            this.grade12ToolStripMenuItem.Click += new System.EventHandler(this.grade12ToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // lstUnselected
            // 
            this.lstUnselected.ItemHeight = 24;
            this.lstUnselected.Location = new System.Drawing.Point(11, 77);
            this.lstUnselected.Name = "lstUnselected";
            this.lstUnselected.Size = new System.Drawing.Size(302, 556);
            this.lstUnselected.TabIndex = 1;
            this.lstUnselected.SelectedIndexChanged += new System.EventHandler(this.lstUnselected_SelectedIndexChanged);
            // 
            // lstSelected
            // 
            this.lstSelected.ItemHeight = 24;
            this.lstSelected.Location = new System.Drawing.Point(880, 77);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(285, 556);
            this.lstSelected.TabIndex = 2;
            this.lstSelected.SelectedIndexChanged += new System.EventHandler(this.lstSelected_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(276, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(610, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(265, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(329, 282);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(275, 34);
            this.txtFirst.TabIndex = 7;
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(610, 282);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(265, 34);
            this.txtLast.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(564, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 77);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(564, 547);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 77);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // trackEntries
            // 
            this.trackEntries.LargeChange = 1;
            this.trackEntries.Location = new System.Drawing.Point(318, 374);
            this.trackEntries.Maximum = 5;
            this.trackEntries.Minimum = 1;
            this.trackEntries.Name = "trackEntries";
            this.trackEntries.Size = new System.Drawing.Size(545, 80);
            this.trackEntries.TabIndex = 11;
            this.trackEntries.Value = 1;
            this.trackEntries.ValueChanged += new System.EventHandler(this.trackEntries_ValueChanged);
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntries.Location = new System.Drawing.Point(324, 330);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(113, 29);
            this.lblEntries.TabIndex = 12;
            this.lblEntries.Text = "Entries: 1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(329, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(545, 43);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Selected";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(323, 51);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(211, 35);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Grade 9 Class";
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
            this.shuffleToolStripMenuItem.Text = "Shuffle!";
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.shuffleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 651);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.trackEntries);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstSelected);
            this.Controls.Add(this.lstUnselected);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grade9ClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grade10ClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grade11ClassToolStripMenuItem;
        private System.Windows.Forms.ListBox lstUnselected;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TrackBar trackEntries;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem grade12ToolStripMenuItem;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
    }
}

