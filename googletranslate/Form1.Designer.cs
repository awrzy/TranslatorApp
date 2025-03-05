
namespace TranslatorApp
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
            TextBoxInput = new System.Windows.Forms.TextBox();
            TextBoxOutput = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            ComboBoxFrom = new System.Windows.Forms.ComboBox();
            ComboBoxTo = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // TextBoxInput
            // 
            TextBoxInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxInput.Location = new System.Drawing.Point(103, 102);
            TextBoxInput.Multiline = true;
            TextBoxInput.Name = "TextBoxInput";
            TextBoxInput.Size = new System.Drawing.Size(279, 226);
            TextBoxInput.TabIndex = 6;
            // 
            // TextBoxOutput
            // 
            TextBoxOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxOutput.Location = new System.Drawing.Point(480, 102);
            TextBoxOutput.Multiline = true;
            TextBoxOutput.Name = "TextBoxOutput";
            TextBoxOutput.Size = new System.Drawing.Size(279, 226);
            TextBoxOutput.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(397, 357);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Перевести";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ComboBoxFrom
            // 
            ComboBoxFrom.FormattingEnabled = true;
            ComboBoxFrom.Location = new System.Drawing.Point(252, 295);
            ComboBoxFrom.Name = "ComboBoxFrom";
            ComboBoxFrom.Size = new System.Drawing.Size(121, 23);
            ComboBoxFrom.TabIndex = 9;
            // 
            // ComboBoxTo
            // 
            ComboBoxTo.FormattingEnabled = true;
            ComboBoxTo.Location = new System.Drawing.Point(628, 295);
            ComboBoxTo.Name = "ComboBoxTo";
            ComboBoxTo.Size = new System.Drawing.Size(121, 23);
            ComboBoxTo.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(829, 450);
            Controls.Add(ComboBoxTo);
            Controls.Add(ComboBoxFrom);
            Controls.Add(button1);
            Controls.Add(TextBoxOutput);
            Controls.Add(TextBoxInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.TextBox TextBoxOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboBoxFrom;
        private System.Windows.Forms.ComboBox ComboBoxTo;
    }
}

