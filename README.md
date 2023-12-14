# klasa-2c-2022-2023


namespace WinFormsAppFirst
{
    partial class MainForm
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
            HelloButton = new Button();
            textBoxName = new TextBox();
            laeblName = new Label();
            checkBoxSchoolSubjectEnglisch = new CheckBox();
            checkBoxSchoolSubjectMatematic = new CheckBox();
            labelSchoolSubject = new Label();
            radioButtonPizzaQuestionYes = new RadioButton();
            radioButtonPizzaQuestionNo = new RadioButton();
            labelPizzaQuestion = new Label();
            SuspendLayout();
            // 
            // HelloButton
            // 
            HelloButton.Location = new Point(408, 254);
            HelloButton.Name = "HelloButton";
            HelloButton.Size = new Size(118, 34);
            HelloButton.TabIndex = 1;
            HelloButton.Text = "Hello";
            HelloButton.UseVisualStyleBackColor = true;
            HelloButton.Click += button1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(182, 117);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(344, 23);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "Marek";
            // 
            // laeblName
            // 
            laeblName.AutoSize = true;
            laeblName.Font = new Font("Microsoft YaHei", 13F, FontStyle.Italic, GraphicsUnit.Point);
            laeblName.ForeColor = SystemColors.ControlText;
            laeblName.Location = new Point(182, 90);
            laeblName.Name = "laeblName";
            laeblName.Size = new Size(175, 24);
            laeblName.TabIndex = 2;
            laeblName.Text = "What`s your name?";
            // 
            // checkBoxSchoolSubjectEnglisch
            // 
            checkBoxSchoolSubjectEnglisch.AutoSize = true;
            checkBoxSchoolSubjectEnglisch.Location = new Point(182, 184);
            checkBoxSchoolSubjectEnglisch.Name = "checkBoxSchoolSubjectEnglisch";
            checkBoxSchoolSubjectEnglisch.Size = new Size(70, 19);
            checkBoxSchoolSubjectEnglisch.TabIndex = 2;
            checkBoxSchoolSubjectEnglisch.Text = "Englisch";
            checkBoxSchoolSubjectEnglisch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSchoolSubjectMatematic
            // 
            checkBoxSchoolSubjectMatematic.AutoSize = true;
            checkBoxSchoolSubjectMatematic.Location = new Point(182, 209);
            checkBoxSchoolSubjectMatematic.Name = "checkBoxSchoolSubjectMatematic";
            checkBoxSchoolSubjectMatematic.Size = new Size(54, 19);
            checkBoxSchoolSubjectMatematic.TabIndex = 3;
            checkBoxSchoolSubjectMatematic.Text = "Math";
            checkBoxSchoolSubjectMatematic.UseVisualStyleBackColor = true;
            // 
            // labelSchoolSubject
            // 
            labelSchoolSubject.AutoSize = true;
            labelSchoolSubject.Font = new Font("Microsoft YaHei", 7F, FontStyle.Italic, GraphicsUnit.Point);
            labelSchoolSubject.Location = new Point(182, 157);
            labelSchoolSubject.Name = "labelSchoolSubject";
            labelSchoolSubject.Size = new Size(162, 16);
            labelSchoolSubject.TabIndex = 6;
            labelSchoolSubject.Text = "What is your fav school subject?";
            // 
            // radioButtonPizzaQuestionYes
            // 
            radioButtonPizzaQuestionYes.AutoSize = true;
            radioButtonPizzaQuestionYes.Location = new Point(364, 184);
            radioButtonPizzaQuestionYes.Name = "radioButtonPizzaQuestionYes";
            radioButtonPizzaQuestionYes.Size = new Size(42, 19);
            radioButtonPizzaQuestionYes.TabIndex = 4;
            radioButtonPizzaQuestionYes.Text = "yes";
            radioButtonPizzaQuestionYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonPizzaQuestionNo
            // 
            radioButtonPizzaQuestionNo.AutoSize = true;
            radioButtonPizzaQuestionNo.Checked = true;
            radioButtonPizzaQuestionNo.Location = new Point(364, 209);
            radioButtonPizzaQuestionNo.Name = "radioButtonPizzaQuestionNo";
            radioButtonPizzaQuestionNo.Size = new Size(39, 19);
            radioButtonPizzaQuestionNo.TabIndex = 5;
            radioButtonPizzaQuestionNo.TabStop = true;
            radioButtonPizzaQuestionNo.Text = "no";
            radioButtonPizzaQuestionNo.UseVisualStyleBackColor = true;
            // 
            // labelPizzaQuestion
            // 
            labelPizzaQuestion.AutoSize = true;
            labelPizzaQuestion.Font = new Font("Microsoft YaHei", 7F, FontStyle.Italic, GraphicsUnit.Point);
            labelPizzaQuestion.Location = new Point(364, 157);
            labelPizzaQuestion.Name = "labelPizzaQuestion";
            labelPizzaQuestion.Size = new Size(152, 16);
            labelPizzaQuestion.TabIndex = 9;
            labelPizzaQuestion.Text = "Do u like pizza with pineaple?";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPizzaQuestion);
            Controls.Add(radioButtonPizzaQuestionNo);
            Controls.Add(radioButtonPizzaQuestionYes);
            Controls.Add(labelSchoolSubject);
            Controls.Add(checkBoxSchoolSubjectMatematic);
            Controls.Add(checkBoxSchoolSubjectEnglisch);
            Controls.Add(laeblName);
            Controls.Add(textBoxName);
            Controls.Add(HelloButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HelloButton;
        private TextBox textBoxName;
        private Label laeblName;
        private CheckBox checkBoxSchoolSubjectEnglisch;
        private CheckBox checkBoxSchoolSubjectMatematic;
        private Label labelSchoolSubject;
        private RadioButton radioButtonPizzaQuestionYes;
        private RadioButton radioButtonPizzaQuestionNo;
        private Label labelPizzaQuestion;
    }
}
