namespace Inf04_01_Desktopowa_2023_01_cz2
{
    partial class FormAddEmployee
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
            groupBoxEmployeeInformaition = new GroupBox();
            comboBoxEmployeePosition = new ComboBox();
            textBoxEmployeeSurname = new TextBox();
            textBoxEmployeeName = new TextBox();
            labelEmployeePosition = new Label();
            labelEmployeeSurname = new Label();
            labelEmployeeName = new Label();
            groupBoxPassowrdGenerator = new GroupBox();
            buttonPasswordGenerator = new Button();
            checkBoxPassGenSpecialSigns = new CheckBox();
            checkBoxPassGenNumbers = new CheckBox();
            checkBoxPassGenSmallAndBigSigns = new CheckBox();
            textBoxPassowrdGenerator = new TextBox();
            labelPassowrdGenerator = new Label();
            buttonAccept = new Button();
            groupBoxEmployeeInformaition.SuspendLayout();
            groupBoxPassowrdGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxEmployeeInformaition
            // 
            groupBoxEmployeeInformaition.Controls.Add(comboBoxEmployeePosition);
            groupBoxEmployeeInformaition.Controls.Add(textBoxEmployeeSurname);
            groupBoxEmployeeInformaition.Controls.Add(textBoxEmployeeName);
            groupBoxEmployeeInformaition.Controls.Add(labelEmployeePosition);
            groupBoxEmployeeInformaition.Controls.Add(labelEmployeeSurname);
            groupBoxEmployeeInformaition.Controls.Add(labelEmployeeName);
            groupBoxEmployeeInformaition.Location = new Point(84, 72);
            groupBoxEmployeeInformaition.Name = "groupBoxEmployeeInformaition";
            groupBoxEmployeeInformaition.Size = new Size(288, 240);
            groupBoxEmployeeInformaition.TabIndex = 0;
            groupBoxEmployeeInformaition.TabStop = false;
            groupBoxEmployeeInformaition.Text = "Dane pracownika";
            // 
            // comboBoxEmployeePosition
            // 
            comboBoxEmployeePosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployeePosition.FormattingEnabled = true;
            comboBoxEmployeePosition.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            comboBoxEmployeePosition.Location = new Point(131, 175);
            comboBoxEmployeePosition.Name = "comboBoxEmployeePosition";
            comboBoxEmployeePosition.Size = new Size(121, 23);
            comboBoxEmployeePosition.TabIndex = 5;
            // 
            // textBoxEmployeeSurname
            // 
            textBoxEmployeeSurname.Location = new Point(131, 100);
            textBoxEmployeeSurname.Name = "textBoxEmployeeSurname";
            textBoxEmployeeSurname.Size = new Size(121, 23);
            textBoxEmployeeSurname.TabIndex = 4;
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.Location = new Point(131, 36);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(121, 23);
            textBoxEmployeeName.TabIndex = 3;
            // 
            // labelEmployeePosition
            // 
            labelEmployeePosition.AutoSize = true;
            labelEmployeePosition.Location = new Point(26, 175);
            labelEmployeePosition.Name = "labelEmployeePosition";
            labelEmployeePosition.Size = new Size(67, 15);
            labelEmployeePosition.TabIndex = 2;
            labelEmployeePosition.Text = "Stanowisko";
            // 
            // labelEmployeeSurname
            // 
            labelEmployeeSurname.AutoSize = true;
            labelEmployeeSurname.Location = new Point(26, 100);
            labelEmployeeSurname.Name = "labelEmployeeSurname";
            labelEmployeeSurname.Size = new Size(57, 15);
            labelEmployeeSurname.TabIndex = 1;
            labelEmployeeSurname.Text = "Nazwisko";
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Location = new Point(26, 36);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(30, 15);
            labelEmployeeName.TabIndex = 0;
            labelEmployeeName.Text = "Imię";
            // 
            // groupBoxPassowrdGenerator
            // 
            groupBoxPassowrdGenerator.Controls.Add(buttonPasswordGenerator);
            groupBoxPassowrdGenerator.Controls.Add(checkBoxPassGenSpecialSigns);
            groupBoxPassowrdGenerator.Controls.Add(checkBoxPassGenNumbers);
            groupBoxPassowrdGenerator.Controls.Add(checkBoxPassGenSmallAndBigSigns);
            groupBoxPassowrdGenerator.Controls.Add(textBoxPassowrdGenerator);
            groupBoxPassowrdGenerator.Controls.Add(labelPassowrdGenerator);
            groupBoxPassowrdGenerator.Location = new Point(451, 72);
            groupBoxPassowrdGenerator.Name = "groupBoxPassowrdGenerator";
            groupBoxPassowrdGenerator.Size = new Size(288, 240);
            groupBoxPassowrdGenerator.TabIndex = 1;
            groupBoxPassowrdGenerator.TabStop = false;
            groupBoxPassowrdGenerator.Text = "Generowanie hasła";
            // 
            // buttonPasswordGenerator
            // 
            buttonPasswordGenerator.BackColor = Color.SteelBlue;
            buttonPasswordGenerator.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPasswordGenerator.ForeColor = Color.White;
            buttonPasswordGenerator.Location = new Point(90, 196);
            buttonPasswordGenerator.Name = "buttonPasswordGenerator";
            buttonPasswordGenerator.Size = new Size(110, 23);
            buttonPasswordGenerator.TabIndex = 7;
            buttonPasswordGenerator.Text = "Generuj hasło";
            buttonPasswordGenerator.UseVisualStyleBackColor = false;
            buttonPasswordGenerator.Click += buttonPasswordGenerator_Click;
            // 
            // checkBoxPassGenSpecialSigns
            // 
            checkBoxPassGenSpecialSigns.AutoSize = true;
            checkBoxPassGenSpecialSigns.Location = new Point(26, 156);
            checkBoxPassGenSpecialSigns.Name = "checkBoxPassGenSpecialSigns";
            checkBoxPassGenSpecialSigns.Size = new Size(107, 19);
            checkBoxPassGenSpecialSigns.TabIndex = 6;
            checkBoxPassGenSpecialSigns.Text = "Znaki specjalne";
            checkBoxPassGenSpecialSigns.UseVisualStyleBackColor = true;
            // 
            // checkBoxPassGenNumbers
            // 
            checkBoxPassGenNumbers.AutoSize = true;
            checkBoxPassGenNumbers.Location = new Point(24, 117);
            checkBoxPassGenNumbers.Name = "checkBoxPassGenNumbers";
            checkBoxPassGenNumbers.Size = new Size(54, 19);
            checkBoxPassGenNumbers.TabIndex = 5;
            checkBoxPassGenNumbers.Text = "Cyfry";
            checkBoxPassGenNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxPassGenSmallAndBigSigns
            // 
            checkBoxPassGenSmallAndBigSigns.AutoSize = true;
            checkBoxPassGenSmallAndBigSigns.Location = new Point(26, 75);
            checkBoxPassGenSmallAndBigSigns.Name = "checkBoxPassGenSmallAndBigSigns";
            checkBoxPassGenSmallAndBigSigns.Size = new Size(126, 19);
            checkBoxPassGenSmallAndBigSigns.TabIndex = 4;
            checkBoxPassGenSmallAndBigSigns.Text = "Małe i wielkie litery";
            checkBoxPassGenSmallAndBigSigns.UseVisualStyleBackColor = true;
            // 
            // textBoxPassowrdGenerator
            // 
            textBoxPassowrdGenerator.Location = new Point(131, 36);
            textBoxPassowrdGenerator.Name = "textBoxPassowrdGenerator";
            textBoxPassowrdGenerator.Size = new Size(121, 23);
            textBoxPassowrdGenerator.TabIndex = 3;
            textBoxPassowrdGenerator.TextChanged += textBoxPassowrdGenerator_TextChanged;
            // 
            // labelPassowrdGenerator
            // 
            labelPassowrdGenerator.AutoSize = true;
            labelPassowrdGenerator.Location = new Point(26, 36);
            labelPassowrdGenerator.Name = "labelPassowrdGenerator";
            labelPassowrdGenerator.Size = new Size(67, 15);
            labelPassowrdGenerator.TabIndex = 0;
            labelPassowrdGenerator.Text = "Ile znaków?";
            // 
            // buttonAccept
            // 
            buttonAccept.BackColor = Color.SteelBlue;
            buttonAccept.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAccept.ForeColor = Color.White;
            buttonAccept.Location = new Point(299, 357);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(208, 45);
            buttonAccept.TabIndex = 8;
            buttonAccept.Text = "Zatwierdź";
            buttonAccept.UseVisualStyleBackColor = false;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAccept);
            Controls.Add(groupBoxPassowrdGenerator);
            Controls.Add(groupBoxEmployeeInformaition);
            Name = "FormAddEmployee";
            Text = "Dodaj pracownika";
            groupBoxEmployeeInformaition.ResumeLayout(false);
            groupBoxEmployeeInformaition.PerformLayout();
            groupBoxPassowrdGenerator.ResumeLayout(false);
            groupBoxPassowrdGenerator.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEmployeeInformaition;
        private Label labelEmployeePosition;
        private Label labelEmployeeSurname;
        private Label labelEmployeeName;
        private ComboBox comboBoxEmployeePosition;
        private TextBox textBoxEmployeeSurname;
        private TextBox textBoxEmployeeName;
        private GroupBox groupBoxPassowrdGenerator;
        private TextBox textBoxPassowrdGenerator;
        private Label labelPassowrdGenerator;
        private Button buttonPasswordGenerator;
        private CheckBox checkBoxPassGenSpecialSigns;
        private CheckBox checkBoxPassGenNumbers;
        private CheckBox checkBoxPassGenSmallAndBigSigns;
        private Button buttonAccept;
    }
}