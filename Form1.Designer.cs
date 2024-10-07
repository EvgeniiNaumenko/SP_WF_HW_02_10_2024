namespace HW_WF_02_10_2024
{
    partial class Form1
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
            apllyButton = new Button();
            loadButton = new Button();
            inputTextBox = new TextBox();
            outPutTextBox = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // apllyButton
            // 
            apllyButton.Location = new Point(80, 329);
            apllyButton.Name = "apllyButton";
            apllyButton.Size = new Size(150, 50);
            apllyButton.TabIndex = 0;
            apllyButton.Text = "Save";
            apllyButton.UseVisualStyleBackColor = true;
            apllyButton.Click += apllyButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(546, 329);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(150, 50);
            loadButton.TabIndex = 1;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(29, 192);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(735, 111);
            inputTextBox.TabIndex = 0;
            // 
            // outPutTextBox
            // 
            outPutTextBox.Location = new Point(29, 67);
            outPutTextBox.Multiline = true;
            outPutTextBox.Name = "outPutTextBox";
            outPutTextBox.Size = new Size(735, 105);
            outPutTextBox.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(29, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 20);
            textBox1.TabIndex = 3;
            textBox1.Text = "Исходные данные";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(outPutTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(loadButton);
            Controls.Add(apllyButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button apllyButton;
        private Button loadButton;
        private TextBox inputTextBox;
        private TextBox outPutTextBox;
        private TextBox textBox1;
    }
}
