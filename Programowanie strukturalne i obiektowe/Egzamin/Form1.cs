namespace Egzamin
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;

            if (!email.Contains("@"))
                labelWiadomosc.Text = "B��dny mail";
            if(textBoxHaslo.Text == textBoxPowtorzHaslo.Text)

        }
    }
}