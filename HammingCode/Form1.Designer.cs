namespace HammingCode
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.CorrectCipherTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.CodeMessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закодировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(278, 35);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(146, 52);
            this.CipherTextBox.TabIndex = 1;
            this.CipherTextBox.Text = "11110110001011110001";
            // 
            // CorrectCipherTextBox
            // 
            this.CorrectCipherTextBox.Location = new System.Drawing.Point(278, 111);
            this.CorrectCipherTextBox.Multiline = true;
            this.CorrectCipherTextBox.Name = "CorrectCipherTextBox";
            this.CorrectCipherTextBox.Size = new System.Drawing.Size(146, 51);
            this.CorrectCipherTextBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Исправить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(31, 35);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(146, 52);
            this.MessageTextBox.TabIndex = 4;
            this.MessageTextBox.Text = "11110110001011110001";
            // 
            // CodeMessageTextBox
            // 
            this.CodeMessageTextBox.Location = new System.Drawing.Point(31, 111);
            this.CodeMessageTextBox.Multiline = true;
            this.CodeMessageTextBox.Name = "CodeMessageTextBox";
            this.CodeMessageTextBox.Size = new System.Drawing.Size(146, 51);
            this.CodeMessageTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.CodeMessageTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CorrectCipherTextBox);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CipherTextBox;
        private System.Windows.Forms.TextBox CorrectCipherTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox CodeMessageTextBox;
    }
}

