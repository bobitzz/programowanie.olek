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
                labelWiadomosc.Text = "B³êdny mail";
            else if (!(textBoxHaslo.Text == textBoxPowtorzHaslo.Text))
                labelWiadomosc.Text = "Has³a siê ró¿ni¹";
            else
                labelWiadomosc.Text = "Witaj " + email;
        }
    }
}