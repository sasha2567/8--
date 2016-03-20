namespace lab3
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
            this.button = new System.Windows.Forms.Button();
            this.inLabel = new System.Windows.Forms.Label();
            this.loopNumeric = new System.Windows.Forms.NumericUpDown();
            this.inTextBox = new System.Windows.Forms.TextBox();
            this.loopLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.outTextBox = new System.Windows.Forms.TextBox();
            this.outLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.loopNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(241, 129);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(109, 40);
            this.button.TabIndex = 0;
            this.button.Text = "Закодировать";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inLabel.Location = new System.Drawing.Point(12, 9);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(103, 17);
            this.inLabel.TabIndex = 1;
            this.inLabel.Text = "Входной текст";
            // 
            // loopNumeric
            // 
            this.loopNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loopNumeric.Location = new System.Drawing.Point(241, 35);
            this.loopNumeric.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.loopNumeric.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.loopNumeric.Name = "loopNumeric";
            this.loopNumeric.Size = new System.Drawing.Size(120, 23);
            this.loopNumeric.TabIndex = 2;
            this.loopNumeric.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // inTextBox
            // 
            this.inTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inTextBox.Location = new System.Drawing.Point(12, 35);
            this.inTextBox.Name = "inTextBox";
            this.inTextBox.Size = new System.Drawing.Size(195, 23);
            this.inTextBox.TabIndex = 3;
            // 
            // loopLabel
            // 
            this.loopLabel.AutoSize = true;
            this.loopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loopLabel.Location = new System.Drawing.Point(216, 9);
            this.loopLabel.Name = "loopLabel";
            this.loopLabel.Size = new System.Drawing.Size(168, 17);
            this.loopLabel.TabIndex = 4;
            this.loopLabel.Text = "Количество повторений";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyTextBox.Location = new System.Drawing.Point(14, 90);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(195, 23);
            this.keyTextBox.TabIndex = 6;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyLabel.Location = new System.Drawing.Point(12, 64);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(132, 17);
            this.keyLabel.TabIndex = 5;
            this.keyLabel.Text = "Ключ шифрования";
            // 
            // outTextBox
            // 
            this.outTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outTextBox.Location = new System.Drawing.Point(14, 146);
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.Size = new System.Drawing.Size(195, 23);
            this.outTextBox.TabIndex = 8;
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outLabel.Location = new System.Drawing.Point(12, 120);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(160, 17);
            this.outLabel.TabIndex = 7;
            this.outLabel.Text = "Зашифрованный текст";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(241, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Зашифровать";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(241, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Расшифровать";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 198);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.outTextBox);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.loopLabel);
            this.Controls.Add(this.inTextBox);
            this.Controls.Add(this.loopNumeric);
            this.Controls.Add(this.inLabel);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Сети Фейштеля";
            ((System.ComponentModel.ISupportInitialize)(this.loopNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.NumericUpDown loopNumeric;
        private System.Windows.Forms.TextBox inTextBox;
        private System.Windows.Forms.Label loopLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox outTextBox;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

