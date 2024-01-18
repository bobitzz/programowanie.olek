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

        private void labelCurrentTime_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void labelMouseClick_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                labelMouseClick.Text = "Left click";
            else if (e.Button == MouseButtons.Right)
                labelMouseClick.Text = "Right click";
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Decimal firstNumber = numericUpDownFirstNumber.Value;
            Decimal secondNumber = numericUpDownSecondNumber.Value;

            Decimal result = 0;

            Button button = sender as Button;
            if (button == null)
                return;

            string operation = button.Text;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            labelResult.Text = "Wynik " + result.ToString();
        }
    }
}