namespace NotepadWinFormsApp
{
    public partial class MainForm : Form
    {
        string filePath = "";

        public MainForm()
        {
            InitializeComponent();
        }

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

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotepad.Undo();
        }
    }
}