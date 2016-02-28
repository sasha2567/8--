namespace lab4
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
            this.inLabel = new System.Windows.Forms.Label();
            this.encode = new System.Windows.Forms.Button();
            this.inTextBox = new System.Windows.Forms.TextBox();
            this.encodeTextBox = new System.Windows.Forms.TextBox();
            this.encodeLabel = new System.Windows.Forms.Label();
            this.decodeTextBox = new System.Windows.Forms.TextBox();
            this.decodeLabel = new System.Windows.Forms.Label();
            this.decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inLabel.Location = new System.Drawing.Point(12, 9);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(84, 17);
            this.inLabel.TabIndex = 0;
            this.inLabel.Text = "Сообщение";
            // 
            // encode
            // 
            this.encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encode.Location = new System.Drawing.Point(15, 184);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(143, 23);
            this.encode.TabIndex = 1;
            this.encode.Text = "Кодировать";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // inTextBox
            // 
            this.inTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inTextBox.Location = new System.Drawing.Point(12, 29);
            this.inTextBox.Name = "inTextBox";
            this.inTextBox.Size = new System.Drawing.Size(517, 23);
            this.inTextBox.TabIndex = 2;
            // 
            // encodeTextBox
            // 
            this.encodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodeTextBox.Location = new System.Drawing.Point(12, 84);
            this.encodeTextBox.Name = "encodeTextBox";
            this.encodeTextBox.Size = new System.Drawing.Size(517, 23);
            this.encodeTextBox.TabIndex = 4;
            // 
            // encodeLabel
            // 
            this.encodeLabel.AutoSize = true;
            this.encodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodeLabel.Location = new System.Drawing.Point(12, 64);
            this.encodeLabel.Name = "encodeLabel";
            this.encodeLabel.Size = new System.Drawing.Size(197, 17);
            this.encodeLabel.TabIndex = 3;
            this.encodeLabel.Text = "Закодированное сообщение";
            // 
            // decodeTextBox
            // 
            this.decodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodeTextBox.Location = new System.Drawing.Point(12, 143);
            this.decodeTextBox.Name = "decodeTextBox";
            this.decodeTextBox.Size = new System.Drawing.Size(517, 23);
            this.decodeTextBox.TabIndex = 6;
            // 
            // decodeLabel
            // 
            this.decodeLabel.AutoSize = true;
            this.decodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodeLabel.Location = new System.Drawing.Point(12, 123);
            this.decodeLabel.Name = "decodeLabel";
            this.decodeLabel.Size = new System.Drawing.Size(204, 17);
            this.decodeLabel.TabIndex = 5;
            this.decodeLabel.Text = "Раскодированное сообщение";
            // 
            // decode
            // 
            this.decode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decode.Location = new System.Drawing.Point(15, 227);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(143, 23);
            this.decode.TabIndex = 7;
            this.decode.Text = "Раскодировать";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(561, 262);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.decodeTextBox);
            this.Controls.Add(this.decodeLabel);
            this.Controls.Add(this.encodeTextBox);
            this.Controls.Add(this.encodeLabel);
            this.Controls.Add(this.inTextBox);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.inLabel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.TextBox inTextBox;
        private System.Windows.Forms.TextBox encodeTextBox;
        private System.Windows.Forms.Label encodeLabel;
        private System.Windows.Forms.TextBox decodeTextBox;
        private System.Windows.Forms.Label decodeLabel;
        private System.Windows.Forms.Button decode;


    }
}

