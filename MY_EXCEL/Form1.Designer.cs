namespace MY_EXCEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.новийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exprText = new System.Windows.Forms.TextBox();
            this.diffRowBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddColBtn = new System.Windows.Forms.Button();
            this.diffColBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addRowBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.beginBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 82);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 377);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView_CellParsing);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Location = new System.Drawing.Point(0, 439);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 10);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(341, 22);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(64, 29);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Відміна";
            this.toolTip1.SetToolTip(this.cancelBtn, "Відмінити дію");
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.cancelBtn.MouseEnter += new System.EventHandler(this.cancelBtn_MouseEnter);
            this.cancelBtn.MouseLeave += new System.EventHandler(this.cancelBtn_MouseLeave);
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.Transparent;
            this.applyBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyBtn.ForeColor = System.Drawing.Color.Black;
            this.applyBtn.Location = new System.Drawing.Point(265, 22);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(64, 29);
            this.applyBtn.TabIndex = 14;
            this.applyBtn.Text = "Ввести";
            this.toolTip1.SetToolTip(this.applyBtn, "Розрахувати вираз");
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            this.applyBtn.MouseEnter += new System.EventHandler(this.applyBtn_MouseEnter);
            this.applyBtn.MouseLeave += new System.EventHandler(this.applyBtn_MouseLeave);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(337, 409);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(130, 29);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Повернутись назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            this.backBtn.MouseEnter += new System.EventHandler(this.backBtn_MouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.backBtn_MouseLeave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newStripSplitButton1
            // 
            this.newStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.newStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("newStripSplitButton1.Image")));
            this.newStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newStripSplitButton1.Name = "newStripSplitButton1";
            this.newStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.newStripSplitButton1.Text = "toolStripSplitButton1";
            this.newStripSplitButton1.ToolTipText = "Файл(розгорни, щоб побачити вміст)";
            // 
            // новийToolStripMenuItem
            // 
            this.новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            this.новийToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.новийToolStripMenuItem.Text = "Новий";
            this.новийToolStripMenuItem.Click += new System.EventHandler(this.новийToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.openToolStripMenuItem.Text = "Відкрити";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(349, 22);
            this.toolStripMenuItem3.Text = "-------------------------------------------------------";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "Про программу, та автора";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.closeToolStripMenuItem.Text = "Закрити";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Green;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.exprText);
            this.splitContainer1.Panel1.Controls.Add(this.cancelBtn);
            this.splitContainer1.Panel1.Controls.Add(this.applyBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.diffRowBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.AddColBtn);
            this.splitContainer1.Panel2.Controls.Add(this.diffColBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.addRowBtn);
            this.splitContainer1.Size = new System.Drawing.Size(800, 63);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 19;
            // 
            // exprText
            // 
            this.exprText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exprText.Location = new System.Drawing.Point(16, 22);
            this.exprText.Name = "exprText";
            this.exprText.Size = new System.Drawing.Size(235, 29);
            this.exprText.TabIndex = 13;
            // 
            // diffRowBtn
            // 
            this.diffRowBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffRowBtn.Location = new System.Drawing.Point(131, 22);
            this.diffRowBtn.Name = "diffRowBtn";
            this.diffRowBtn.Size = new System.Drawing.Size(31, 29);
            this.diffRowBtn.TabIndex = 20;
            this.diffRowBtn.Text = "-";
            this.toolTip1.SetToolTip(this.diffRowBtn, "Видалити рядок");
            this.diffRowBtn.UseVisualStyleBackColor = true;
            this.diffRowBtn.Click += new System.EventHandler(this.diffRowBtn_Click);
            this.diffRowBtn.MouseEnter += new System.EventHandler(this.diffRowBtn_MouseEnter);
            this.diffRowBtn.MouseLeave += new System.EventHandler(this.diffRowBtn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Columns:";
            // 
            // AddColBtn
            // 
            this.AddColBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddColBtn.Location = new System.Drawing.Point(290, 22);
            this.AddColBtn.Name = "AddColBtn";
            this.AddColBtn.Size = new System.Drawing.Size(31, 29);
            this.AddColBtn.TabIndex = 19;
            this.AddColBtn.Text = "+";
            this.toolTip1.SetToolTip(this.AddColBtn, "Добавити нову колонку");
            this.AddColBtn.UseVisualStyleBackColor = true;
            this.AddColBtn.Click += new System.EventHandler(this.AddColBtn_Click);
            this.AddColBtn.MouseEnter += new System.EventHandler(this.AddColBtn_MouseEnter);
            this.AddColBtn.MouseLeave += new System.EventHandler(this.AddColBtn_MouseLeave);
            // 
            // diffColBtn
            // 
            this.diffColBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffColBtn.Location = new System.Drawing.Point(327, 22);
            this.diffColBtn.Name = "diffColBtn";
            this.diffColBtn.Size = new System.Drawing.Size(31, 29);
            this.diffColBtn.TabIndex = 21;
            this.diffColBtn.Text = "-";
            this.toolTip1.SetToolTip(this.diffColBtn, "Видалити колонку");
            this.diffColBtn.UseVisualStyleBackColor = true;
            this.diffColBtn.Click += new System.EventHandler(this.diffColBtn_Click);
            this.diffColBtn.MouseEnter += new System.EventHandler(this.diffColBtn_MouseEnter);
            this.diffColBtn.MouseLeave += new System.EventHandler(this.diffColBtn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rows:";
            // 
            // addRowBtn
            // 
            this.addRowBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRowBtn.Location = new System.Drawing.Point(94, 22);
            this.addRowBtn.Name = "addRowBtn";
            this.addRowBtn.Size = new System.Drawing.Size(31, 29);
            this.addRowBtn.TabIndex = 18;
            this.addRowBtn.Text = "+";
            this.toolTip1.SetToolTip(this.addRowBtn, "Добавити новий рядок");
            this.addRowBtn.UseVisualStyleBackColor = true;
            this.addRowBtn.Click += new System.EventHandler(this.addRowBtn_Click);
            this.addRowBtn.MouseEnter += new System.EventHandler(this.addRowBtn_MouseEnter);
            this.addRowBtn.MouseLeave += new System.EventHandler(this.addRowBtn_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Green;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // beginBtn
            // 
            this.beginBtn.BackColor = System.Drawing.Color.Black;
            this.beginBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginBtn.ForeColor = System.Drawing.Color.White;
            this.beginBtn.Location = new System.Drawing.Point(311, 0);
            this.beginBtn.Name = "beginBtn";
            this.beginBtn.Size = new System.Drawing.Size(210, 25);
            this.beginBtn.TabIndex = 20;
            this.beginBtn.Text = "Натисніть щоб розпочати";
            this.toolTip1.SetToolTip(this.beginBtn, "Start to Use MY EXCEL");
            this.beginBtn.UseVisualStyleBackColor = false;
            this.beginBtn.Click += new System.EventHandler(this.beginBtn_Click);
            this.beginBtn.MouseEnter += new System.EventHandler(this.beginBtn_MouseEnter);
            this.beginBtn.MouseLeave += new System.EventHandler(this.beginBtn_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.beginBtn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                             Лабораторна робота 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton newStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem новийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox exprText;
        private System.Windows.Forms.Button diffRowBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddColBtn;
        private System.Windows.Forms.Button diffColBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRowBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button beginBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

