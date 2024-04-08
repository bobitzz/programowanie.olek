namespace Inf04_01_Desktopowa_2023_01_cz2
{
    public partial class FormAddEmployee : Form
    {
        string Password = "";
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void textBoxPassowrdGenerator_TextChanged(object sender, EventArgs e)
        {
            int PasswordLength = 0;
            string[] PasswordBigLettrs = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S",
                "D", "", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
            string[] PasswordSmallLettrs = {"q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s",
                "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"};
            int[] PasswordNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string[] PasswordSpecialSigns = { "!", "@", "#", "$", "%", "^", "&", "*", "_", "-", "=", "+", "/", "?" };

            if (int.Parse(textBoxPassowrdGenerator.Text) > 0)
                PasswordLength = textBoxPassowrdGenerator.Text.Length;

            Random rnd = new();
            do
            {
                if (checkBoxPassGenSmallAndBigSigns.Checked)
                {
                    Password += PasswordBigLettrs[rnd.Next(PasswordBigLettrs.Length)];
                    Password += PasswordSmallLettrs[rnd.Next(PasswordSmallLettrs.Length)];
                }
                else if (checkBoxPassGenNumbers.Checked)
                    Password += PasswordNumbers[rnd.Next(PasswordNumbers.Length)];
                else if (checkBoxPassGenSpecialSigns.Checked)
                    Password += PasswordSpecialSigns[rnd.Next(PasswordSpecialSigns.Length)];
            } while (Password.Length <= PasswordLength);
        }

        private void buttonPasswordGenerator_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Password);
        }
    }
}