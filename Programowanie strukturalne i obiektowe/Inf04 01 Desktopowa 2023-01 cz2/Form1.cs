namespace Inf04_01_Desktopowa_2023_01_cz2
{
    public partial class FormAddEmployee : Form
    {
        //pola z ma³ych liter
        string Password = "";
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void buttonPasswordGenerator_Click(object sender, EventArgs e)
        {
            int PasswordLength = int.Parse(textBoxPassowrdGenerator.Text);
            string[] PasswordBigLettrs = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S",
                "D", "", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
            string[] PasswordSmallLettrs = {"q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s",
                "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"};
            int[] PasswordNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; //zmnienic na string
            string[] PasswordSpecialSigns = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=" };

            Random rnd = new();
            if (checkBoxPassGenSmallAndBigSigns.Checked)
            {
                Password += PasswordSmallLettrs[rnd.Next(PasswordSmallLettrs.Length)].ToUpper();
            }
            if (checkBoxPassGenNumbers.Checked)
                Password += PasswordNumbers[rnd.Next(PasswordNumbers.Length)];
            if (checkBoxPassGenSpecialSigns.Checked)
                Password += PasswordSpecialSigns[rnd.Next(PasswordSpecialSigns.Length)];
            while (Password.Length < PasswordLength)
                Password += PasswordSmallLettrs[rnd.Next(PasswordSmallLettrs.Length)];
            MessageBox.Show(Password);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            string emplyeeName = textBoxEmployeeName.Text;
            string emplyeeSurname = textBoxEmployeeSurname.Text;
            string emplyeePosition = comboBoxEmployeePosition.SelectedItem.ToString();

            MessageBox.Show($"Dane pracownika: {emplyeeName} {emplyeeSurname} {emplyeePosition}. Has³o: {Password}");
        }
    }
}