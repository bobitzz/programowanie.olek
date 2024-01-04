namespace WinFormsAppFirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxFavoriteMeal.SelectedIndex = -1;

            labelCurrentTime.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            string schoolSubject = "Ulubione przedmioty: \n";
            if (checkBoxSchoolSubjectMatematic.Checked)
            {
                schoolSubject += "Matematyka\n";
            }
            if (checkBoxSchoolSubjectEnglisch.Checked)
            {
                schoolSubject += "Angielski\n";
            }

            string PizzaWithPineaple = " ";
            if (radioButtonPizzaQuestionNo.Checked)
            {
                PizzaWithPineaple = "Nie lubie pizzy z ananasem\n";
            }
            else
            {
                PizzaWithPineaple = "Zaszlo jakies nieporozumienie\n";
            }

            string favoriteMeal = comboBoxFavoriteMeal.Text;

            MessageBox.Show($"Witaj {name} w pierwszym programie.\n{schoolSubject}" +
                $"{PizzaWithPineaple}"
                + $"Ulubiona potrawa: {favoriteMeal}",
                "Powitanie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelFavoriteMeal_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxFavoriteMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefreshTime_Click(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString();
            timerRefreshTime.Enabled = !timerRefreshTime.Enabled;
        }

        private void timerRefreshTime_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString();
        }
    }
}