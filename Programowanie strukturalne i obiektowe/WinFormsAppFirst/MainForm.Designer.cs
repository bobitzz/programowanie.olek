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
            SuspendLayout();
            // 
            // HelloButton
            // 
            HelloButton.Location = new Point(182, 146);
            HelloButton.Name = "HelloButton";
            HelloButton.Size = new Size(146, 70);
            HelloButton.TabIndex = 0;
            HelloButton.Text = "Hello";
            HelloButton.UseVisualStyleBackColor = true;
            HelloButton.Click += button1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(182, 117);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(276, 23);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Jan";
            // 
            // laeblName
            // 
            laeblName.AutoSize = true;
            laeblName.Font = new Font("Miriam Libre", 13F, FontStyle.Regular, GraphicsUnit.Point);
            laeblName.Location = new Point(182, 90);
            laeblName.Name = "laeblName";
            laeblName.Size = new Size(181, 24);
            laeblName.TabIndex = 2;
            laeblName.Text = "What`s your name?";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}