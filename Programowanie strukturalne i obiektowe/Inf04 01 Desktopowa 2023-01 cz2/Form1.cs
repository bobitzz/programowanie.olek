namespace Inf04_01_Desktopowa_2023_01_cz2
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void textBoxPassowrdGenerator_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBoxPassowrdGenerator.Text) > 0)
            {

            }
        }
    }
}