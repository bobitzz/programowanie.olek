﻿namespace WinFormsAppFirst
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
            components = new System.ComponentModel.Container();
            HelloButton = new Button();
            textBoxName = new TextBox();
            laeblName = new Label();
            checkBoxSchoolSubjectEnglisch = new CheckBox();
            checkBoxSchoolSubjectMatematic = new CheckBox();
            labelSchoolSubject = new Label();
            radioButtonPizzaQuestionYes = new RadioButton();
            radioButtonPizzaQuestionNo = new RadioButton();
            labelPizzaQuestion = new Label();
            comboBoxFavoriteMeal = new ComboBox();
            labelFavoriteMeal = new Label();
            label1 = new Label();
            labelCurrentTime = new Label();
            buttonRefreshTime = new Button();
            timerRefreshTime = new System.Windows.Forms.Timer(components);
            labelMouseClick = new Label();
            numericUpDownFirstNumber = new NumericUpDown();
            numericUpDownSecondNumber = new NumericUpDown();
            buttonDiv = new Button();
            buttonMul = new Button();
            buttonSub = new Button();
            buttonAdd = new Button();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondNumber).BeginInit();
            SuspendLayout();
            // 
            // HelloButton
            // 
            HelloButton.Location = new Point(408, 360);
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
            labelSchoolSubject.Font = new Font("Microsoft YaHei", 8F, FontStyle.Italic, GraphicsUnit.Point);
            labelSchoolSubject.Location = new Point(182, 157);
            labelSchoolSubject.Name = "labelSchoolSubject";
            labelSchoolSubject.Size = new Size(176, 16);
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
            labelPizzaQuestion.Font = new Font("Microsoft YaHei", 8F, FontStyle.Italic, GraphicsUnit.Point);
            labelPizzaQuestion.Location = new Point(364, 157);
            labelPizzaQuestion.Name = "labelPizzaQuestion";
            labelPizzaQuestion.Size = new Size(161, 16);
            labelPizzaQuestion.TabIndex = 9;
            labelPizzaQuestion.Text = "Do u like pizza with pineaple?";
            // 
            // comboBoxFavoriteMeal
            // 
            comboBoxFavoriteMeal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFavoriteMeal.FormattingEnabled = true;
            comboBoxFavoriteMeal.Items.AddRange(new object[] { "Rosół", "Kebab", "Pizza", "Schabowy", "Ramen" });
            comboBoxFavoriteMeal.Location = new Point(182, 272);
            comboBoxFavoriteMeal.Name = "comboBoxFavoriteMeal";
            comboBoxFavoriteMeal.Size = new Size(162, 23);
            comboBoxFavoriteMeal.TabIndex = 10;
            comboBoxFavoriteMeal.SelectedIndexChanged += comboBoxFavoriteMeal_SelectedIndexChanged;
            // 
            // labelFavoriteMeal
            // 
            labelFavoriteMeal.AutoSize = true;
            labelFavoriteMeal.Font = new Font("Microsoft YaHei", 8F, FontStyle.Italic, GraphicsUnit.Point);
            labelFavoriteMeal.Location = new Point(182, 244);
            labelFavoriteMeal.Name = "labelFavoriteMeal";
            labelFavoriteMeal.Size = new Size(125, 16);
            labelFavoriteMeal.TabIndex = 11;
            labelFavoriteMeal.Text = "What is your fav meal?";
            labelFavoriteMeal.Click += labelFavoriteMeal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(656, 90);
            label1.Name = "label1";
            label1.Size = new Size(75, 16);
            label1.TabIndex = 15;
            label1.Text = "Current time:";
            // 
            // labelCurrentTime
            // 
            labelCurrentTime.AutoSize = true;
            labelCurrentTime.Font = new Font("Microsoft YaHei", 8F, FontStyle.Italic, GraphicsUnit.Point);
            labelCurrentTime.Location = new Point(656, 115);
            labelCurrentTime.Name = "labelCurrentTime";
            labelCurrentTime.Size = new Size(38, 16);
            labelCurrentTime.TabIndex = 16;
            labelCurrentTime.Text = "label1";
            // 
            // buttonRefreshTime
            // 
            buttonRefreshTime.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRefreshTime.Location = new Point(656, 134);
            buttonRefreshTime.Name = "buttonRefreshTime";
            buttonRefreshTime.Size = new Size(75, 23);
            buttonRefreshTime.TabIndex = 17;
            buttonRefreshTime.Text = "Refresh timer";
            buttonRefreshTime.UseVisualStyleBackColor = true;
            buttonRefreshTime.Click += buttonRefreshTime_Click;
            // 
            // timerRefreshTime
            // 
            timerRefreshTime.Enabled = true;
            timerRefreshTime.Interval = 1000;
            timerRefreshTime.Tick += timerRefreshTime_Tick;
            // 
            // labelMouseClick
            // 
            labelMouseClick.AutoSize = true;
            labelMouseClick.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMouseClick.ForeColor = Color.Firebrick;
            labelMouseClick.Location = new Point(185, 326);
            labelMouseClick.Name = "labelMouseClick";
            labelMouseClick.Size = new Size(106, 21);
            labelMouseClick.TabIndex = 18;
            labelMouseClick.Text = "Not click yet";
            labelMouseClick.Click += label2_Click_2;
            labelMouseClick.MouseClick += labelMouseClick_MouseClick_1;
            // 
            // numericUpDownFirstNumber
            // 
            numericUpDownFirstNumber.Location = new Point(185, 418);
            numericUpDownFirstNumber.Name = "numericUpDownFirstNumber";
            numericUpDownFirstNumber.Size = new Size(120, 23);
            numericUpDownFirstNumber.TabIndex = 19;
            // 
            // numericUpDownSecondNumber
            // 
            numericUpDownSecondNumber.Location = new Point(323, 418);
            numericUpDownSecondNumber.Name = "numericUpDownSecondNumber";
            numericUpDownSecondNumber.Size = new Size(120, 23);
            numericUpDownSecondNumber.TabIndex = 20;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(425, 447);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 23);
            buttonDiv.TabIndex = 27;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += operation_Click;
            // 
            // buttonMul
            // 
            buttonMul.Location = new Point(344, 447);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(75, 23);
            buttonMul.TabIndex = 26;
            buttonMul.Text = "*";
            buttonMul.UseVisualStyleBackColor = true;
            buttonMul.Click += operation_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(263, 447);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(75, 23);
            buttonSub.TabIndex = 25;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += operation_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(182, 447);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 28;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += operation_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(185, 484);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(36, 15);
            labelResult.TabIndex = 29;
            labelResult.Text = "result";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 588);
            Controls.Add(labelResult);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMul);
            Controls.Add(buttonSub);
            Controls.Add(numericUpDownSecondNumber);
            Controls.Add(numericUpDownFirstNumber);
            Controls.Add(labelMouseClick);
            Controls.Add(buttonRefreshTime);
            Controls.Add(labelCurrentTime);
            Controls.Add(label1);
            Controls.Add(labelFavoriteMeal);
            Controls.Add(comboBoxFavoriteMeal);
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
            MouseClick += MainForm_MouseClick;
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondNumber).EndInit();
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
        private ComboBox comboBoxFavoriteMeal;
        private Label labelFavoriteMeal;
        private Label labelCurrentTime;
        private Label label1;
        private Button buttonRefreshTime;
        private System.Windows.Forms.Timer timerRefreshTime;
        private Label labelMouseClick;
        private NumericUpDown numericUpDownFirstNumber;
        private NumericUpDown numericUpDownSecondNumber;
        private Button buttonDiv;
        private Button buttonMul;
        private Button buttonSub;
        private Button buttonAdd;
        private Label labelResult;
    }
}