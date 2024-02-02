namespace NotepadWinFormsApp
{
    public partial class MainForm : Form
    {
        #region GlobalVariables
        string filePath = "";
        bool isCtrlDown = false;
        int step = 2;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            textBoxNotepad.MouseWheel += textBoxNotepad_MouseWheel;
        }

        #region MouseWheel
        private void textBoxNotepad_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (!isCtrlDown)
                return;

            if (e.Delta > 0)
                ChangeFontSize(step);
            else
                ChangeFontSize(-step);
        }

        private void ChangeFontSize(int step)
        {
            FontFamily fontFamily = textBoxNotepad.Font.FontFamily;
            float size = textBoxNotepad.Font.Size + step;
            FontStyle fontStyle = textBoxNotepad.Font.Style;
            GraphicsUnit graphicsUnit = textBoxNotepad.Font.Unit;
            byte gdiCharSet = textBoxNotepad.Font.GdiCharSet;

            if (size > 0)
                textBoxNotepad.Font = new Font(fontFamily, size, fontStyle, graphicsUnit, gdiCharSet);
        }

        private void textBoxNotepad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                isCtrlDown = true;
        }

        private void textBoxNotepad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                isCtrlDown = false;
        }
        #endregion 

        #region Plik
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotepad.Text = "";
            filePath = "";
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                textBoxNotepad.Text = File.ReadAllText(openFileDialog.FileName);
                filePath = openFileDialog.FileName;
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBoxNotepad.Text);
                filePath = saveFileDialog.FileName;
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != "" || saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (filePath == "")
                    filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, textBoxNotepad.Text);
            }
        }
        #endregion

        #region Edycja
        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotepad.Undo();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotepad.Cut();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotepad.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotepad.Paste();
        }

        private void usuñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotepad.SelectedText = string.Empty;
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotepad.SelectAll();
        }

        private void godzinadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotepad.Paste(DateTime.Now.ToString("hh:mm dd-MM-yyyy"));
        }
        #endregion

        #region pomoc
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.ShowDialog();
        }
        #endregion
    }
}