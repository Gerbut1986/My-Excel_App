namespace MY_EXCEL
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        Data data;
        string OldTextBoxExpression = String.Empty, currentFileName;
        public Form1()
        {
            InitializeComponent();

            ColorButtons();

            richTextBox1.Visible = false;
            backBtn.Visible = false;
        }

        // Begin State of the Form:
        private void Form1_Load(object sender, EventArgs e)
        {
            HideTopPanel();
        }

        // Show and Hide methods for apply on begin & About section:
        void HideTopPanel()
        {
            data = new Data(dataGridView);
            BackColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Size = new Size(948, 25);
            exprText.Visible = applyBtn.Visible = cancelBtn.Visible = addRowBtn.Visible = diffRowBtn.Visible = splitContainer1.Visible =
            richTextBox1.Visible = AddColBtn.Visible = diffColBtn.Visible = label1.Visible = label2.Visible = dataGridView.Visible =
            toolStrip1.Visible = false;
        }

        void Show()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            splitContainer1.Visible = exprText.Visible = applyBtn.Visible = cancelBtn.Visible = addRowBtn.Visible = diffRowBtn.Visible =
            AddColBtn.Visible = diffColBtn.Visible = label1.Visible = label2.Visible = dataGridView.Visible = toolStrip1.Visible = true;
            richTextBox1.Visible = false;
            Size = new Size(816, 520);
            using (var stream = System.IO.File.OpenRead("application_office_excel_2474.ico"))
            {
                this.Icon = new Icon(stream);
            }
        }

        void Hide()
        {
            exprText.Visible = applyBtn.Visible = cancelBtn.Visible = addRowBtn.Visible = diffRowBtn.Visible = splitContainer1.Visible =
            richTextBox1.Visible = AddColBtn.Visible = diffColBtn.Visible = label1.Visible = label2.Visible = dataGridView.Visible = toolStrip1.Visible
            = false;
            Size = new Size(816, 489);
        }

        void About()
        {
            backBtn.ForeColor = Color.Blue;
            backBtn.BackColor = Color.White;
            backBtn.Visible = true;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Visible = true;
            richTextBox1.Size = new Size(800, 489);
            cancelBtn.ForeColor = Color.White;
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;
        }

        // Стилізація для кнопок:
        private void beginBtn_MouseEnter(object sender, EventArgs e)
        {
            beginBtn.BackColor = Color.White;
            beginBtn.ForeColor = Color.Black;
        }

        private void beginBtn_MouseLeave(object sender, EventArgs e)
        {
            beginBtn.BackColor = Color.Black;
            beginBtn.ForeColor = Color.White;
        }

        private void applyBtn_MouseEnter(object sender, EventArgs e)
        {
            applyBtn.BackColor = Color.Black;
            applyBtn.ForeColor = Color.Gold;
        }

        private void applyBtn_MouseLeave(object sender, EventArgs e)
        {
            applyBtn.BackColor = Color.Gold;
            applyBtn.ForeColor = Color.Black;
        }

        private void cancelBtn_MouseEnter(object sender, EventArgs e)
        {
            cancelBtn.BackColor = Color.White;
            cancelBtn.ForeColor = Color.Magenta;
        }

        private void cancelBtn_MouseLeave(object sender, EventArgs e)
        {
            cancelBtn.BackColor = Color.Magenta;
            cancelBtn.ForeColor = Color.White;
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.ForeColor = Color.White;
            backBtn.BackColor = Color.Blue;
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.ForeColor = Color.Blue;
            backBtn.BackColor = Color.White;
        }

        private void addRowBtn_MouseEnter(object sender, EventArgs e)
        {
            addRowBtn.ForeColor = Color.White;
            addRowBtn.BackColor = Color.Green;
        }

        private void addRowBtn_MouseLeave(object sender, EventArgs e)
        {
            addRowBtn.ForeColor = Color.Green;
            addRowBtn.BackColor = Color.WhiteSmoke;
        }

        private void diffRowBtn_MouseEnter(object sender, EventArgs e)
        {
            diffRowBtn.ForeColor = Color.White;
            diffRowBtn.BackColor = Color.Black;
        }

        private void diffRowBtn_MouseLeave(object sender, EventArgs e)
        {
            diffRowBtn.ForeColor = Color.Black;
            diffRowBtn.BackColor = Color.White;
        }

        private void AddColBtn_MouseEnter(object sender, EventArgs e)
        {
            AddColBtn.ForeColor = Color.White;
            AddColBtn.BackColor = Color.Green;
        }

        private void AddColBtn_MouseLeave(object sender, EventArgs e)
        {
            AddColBtn.ForeColor = Color.Green;
            AddColBtn.BackColor = Color.WhiteSmoke;
        }

        private void diffColBtn_MouseEnter(object sender, EventArgs e)
        {
            diffColBtn.ForeColor = Color.White;
            diffColBtn.BackColor = Color.Black;
        }

        private void diffColBtn_MouseLeave(object sender, EventArgs e)
        {
            diffColBtn.ForeColor = Color.Black;
            diffColBtn.BackColor = Color.White;
        }

        // Обродники подій на верхнє меню 'Файл':
        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            data = new Data(dataGridView);
            data.FillData(Mode.Value);
            OldTextBoxExpression = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            bool flag = false;
            // var val = dataGridView.Rows[0].Cells[0].Value;  // for debugger
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        flag = true;
                        result = MessageBox.Show("У таблиці є вирази.\n\tНатисніть 'Ok'  щоб збарегти,\nабо 'Cancel' щоб відкрити інакший..", "У таблиці є вирази", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Save();
                            return;
                        }
                        else if (result == DialogResult.Cancel) { Open(); return; }
                    }
                }
            }
            if (!flag)
            {
                Open();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Save();
        }

        void Open()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                data = new Data(dataGridView);
                data.OpenFile(openFileDialog1.FileName);
                data.FillData(Mode.Value);
                currentFileName = openFileDialog1.FileName;
                Text = currentFileName + "MY_EXCEL";
            }
        }

        void Save()
        {
            saveFileDialog1.Filter = "GridFile|*.grd";
            saveFileDialog1.Title = "Save Grid File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string msg = data.SaveToFile(saveFileDialog1.FileName);
                currentFileName = saveFileDialog1.FileName;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            About();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // DataGridView of Manipulations:
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count == 1)
            {
                var selectedCell = dataGridView.SelectedCells[0];
                exprText.Text = Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Expression;
                OldTextBoxExpression = exprText.Text;
            }
        }

        private void dataGridView_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Value.ToString()))
                data.ChangeData(e.Value.ToString(), e.RowIndex, e.ColumnIndex);
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Data.cells[e.RowIndex][e.ColumnIndex].Expression;
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Data.cells[e.RowIndex][e.ColumnIndex].Expression != null)
                if (!String.IsNullOrEmpty(Data.cells[e.RowIndex][e.ColumnIndex].Error))
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Data.cells[e.RowIndex][e.ColumnIndex].Error;
                else dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Data.cells[e.RowIndex][e.ColumnIndex].Value.ToString();
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = new TextBox();
            tb.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            exprText.Text = ((TextBox)sender).Text;
            OldTextBoxExpression = exprText.Text;
        }

        // Обродники подій на Buttons 'Click':
        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count == 1)
            {
                var selectedCell = dataGridView.SelectedCells[0];
                if (exprText.Text == String.Empty)
                {
                    Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Expression = null;
                    Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Value = 0;
                    dataGridView.Rows[selectedCell.RowIndex].Cells[selectedCell.ColumnIndex].Value = "";
                }
                else
                {
                    data.ChangeData(exprText.Text, selectedCell.RowIndex, selectedCell.ColumnIndex);
                    if (!String.IsNullOrEmpty(Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Error))
                        dataGridView.Rows[selectedCell.RowIndex].Cells[selectedCell.ColumnIndex].Value =
                            Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Error;
                    else
                        dataGridView.Rows[selectedCell.RowIndex].Cells[selectedCell.ColumnIndex].Value =
                            Data.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Value.ToString();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            exprText.Text = OldTextBoxExpression;
        }

        private void addRowBtn_Click(object sender, EventArgs e)
        {
            data.AddRow();
        }

        private void diffRowBtn_Click(object sender, EventArgs e)
        {
            data.RemoveRow();
        }

        private void AddColBtn_Click(object sender, EventArgs e)
        {
            data.AddColumn();
        }

        private void diffColBtn_Click(object sender, EventArgs e)
        {
            data.RemoveColumn();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            backBtn.Visible = false;
            Show();
        }

        private void beginBtn_Click(object sender, EventArgs e)
        {
            beginBtn.Visible = false;
            Show();
            data.FillData(Mode.Value);
        }

        internal Data Data
        {
            get => default(Data);
            set { }
        }

        void ColorButtons()
        {
            applyBtn.BackColor = Color.Gold;
            cancelBtn.BackColor = Color.Magenta;

            addRowBtn.ForeColor = Color.Green;
            addRowBtn.BackColor = Color.WhiteSmoke;
            diffRowBtn.ForeColor = Color.Black;
            diffRowBtn.BackColor = Color.White;

            AddColBtn.ForeColor = Color.Green;
            AddColBtn.BackColor = Color.WhiteSmoke;
            diffColBtn.ForeColor = Color.Black;
            diffColBtn.BackColor = Color.White;
        }
    }
}
