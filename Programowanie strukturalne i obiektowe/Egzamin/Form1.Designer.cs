namespace Egzamin
{
    partial class Rejestracja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelRejestruj = new Label();
            labelPodajEmail = new Label();
            textBoxEmail = new TextBox();
            labelHaslo = new Label();
            textBoxHaslo = new TextBox();
            textBoxPowtorzHaslo = new TextBox();
            labelPowtorzHaslo = new Label();
            buttonZatwierdz = new Button();
            labelWiadomosc = new Label();
            SuspendLayout();
            // 
            // labelRejestruj
            // 
            labelRejestruj.AutoSize = true;
            labelRejestruj.BackColor = SystemColors.ActiveCaption;
            labelRejestruj.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelRejestruj.Location = new Point(-13, 0);
            labelRejestruj.Name = "labelRejestruj";
            labelRejestruj.Size = new Size(475, 32);
            labelRejestruj.TabIndex = 0;
            labelRejestruj.Text = "   Rejestruj konto                                        ";
            // 
            // labelPodajEmail
            // 
            labelPodajEmail.AutoSize = true;
            labelPodajEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPodajEmail.Location = new Point(12, 53);
            labelPodajEmail.Name = "labelPodajEmail";
            labelPodajEmail.Size = new Size(87, 19);
            labelPodajEmail.TabIndex = 1;
            labelPodajEmail.Text = "Podaj e-mail:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(15, 78);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(161, 23);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.Text = "email";
            // 
            // labelHaslo
            // 
            labelHaslo.AutoSize = true;
            labelHaslo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelHaslo.Location = new Point(12, 117);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(82, 19);
            labelHaslo.TabIndex = 3;
            labelHaslo.Text = "Podaj hasło:";
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.HideSelection = false;
            textBoxHaslo.Location = new Point(15, 142);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(161, 23);
            textBoxHaslo.TabIndex = 4;
            textBoxHaslo.UseSystemPasswordChar = true;
            // 
            // textBoxPowtorzHaslo
            // 
            textBoxPowtorzHaslo.HideSelection = false;
            textBoxPowtorzHaslo.Location = new Point(15, 208);
            textBoxPowtorzHaslo.Name = "textBoxPowtorzHaslo";
            textBoxPowtorzHaslo.Size = new Size(161, 23);
            textBoxPowtorzHaslo.TabIndex = 6;
            textBoxPowtorzHaslo.UseSystemPasswordChar = true;
            // 
            // labelPowtorzHaslo
            // 
            labelPowtorzHaslo.AutoSize = true;
            labelPowtorzHaslo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPowtorzHaslo.Location = new Point(12, 183);
            labelPowtorzHaslo.Name = "labelPowtorzHaslo";
            labelPowtorzHaslo.Size = new Size(98, 19);
            labelPowtorzHaslo.TabIndex = 5;
            labelPowtorzHaslo.Text = "Powtórz hasło:";
            // 
            // buttonZatwierdz
            // 
            buttonZatwierdz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZatwierdz.Location = new Point(111, 247);
            buttonZatwierdz.Name = "buttonZatwierdz";
            buttonZatwierdz.Size = new Size(99, 23);
            buttonZatwierdz.TabIndex = 7;
            buttonZatwierdz.Text = "ZATWIERDŹ";
            buttonZatwierdz.UseVisualStyleBackColor = true;
            buttonZatwierdz.Click += buttonZatwierdz_Click;
            // 
            // labelWiadomosc
            // 
            labelWiadomosc.AutoSize = true;
            labelWiadomosc.Location = new Point(154, 282);
            labelWiadomosc.Name = "labelWiadomosc";
            labelWiadomosc.Size = new Size(0, 15);
            labelWiadomosc.TabIndex = 8;
            // 
            // Rejestracja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 563);
            Controls.Add(labelWiadomosc);
            Controls.Add(buttonZatwierdz);
            Controls.Add(textBoxPowtorzHaslo);
            Controls.Add(labelPowtorzHaslo);
            Controls.Add(textBoxHaslo);
            Controls.Add(labelHaslo);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPodajEmail);
            Controls.Add(labelRejestruj);
            Name = "Rejestracja";
            Text = "Rejestracja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRejestruj;
        private Label labelPodajEmail;
        private TextBox textBoxEmail;
        private Label labelHaslo;
        private TextBox textBoxHaslo;
        private TextBox textBoxPowtorzHaslo;
        private Label labelPowtorzHaslo;
        private Button buttonZatwierdz;
        private Label labelWiadomosc;
    }
}