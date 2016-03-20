namespace lab2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LCTabPage = new System.Windows.Forms.TabPage();
            this.BTrackBar = new System.Windows.Forms.TrackBar();
            this.CTrackBar = new System.Windows.Forms.TrackBar();
            this.ATrackBar = new System.Windows.Forms.TrackBar();
            this.DecryptTextBox = new System.Windows.Forms.TextBox();
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.DecryptLabel = new System.Windows.Forms.Label();
            this.EncryptLabel = new System.Windows.Forms.Label();
            this.WordLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.XORTabPage = new System.Windows.Forms.TabPage();
            this.Decrypt_TextBox = new System.Windows.Forms.TextBox();
            this.Encrypt_TextBox = new System.Windows.Forms.TextBox();
            this.Word_TextBox = new System.Windows.Forms.TextBox();
            this.Decrypt_Label = new System.Windows.Forms.Label();
            this.Encrypt_Label = new System.Windows.Forms.Label();
            this.Word_Label = new System.Windows.Forms.Label();
            this.Decrypt_Button = new System.Windows.Forms.Button();
            this.Encrypt_Button = new System.Windows.Forms.Button();
            this.T_TextBox = new System.Windows.Forms.TextBox();
            this.T_Label = new System.Windows.Forms.Label();
            this.B_TrackBar = new System.Windows.Forms.TrackBar();
            this.C_TrackBar = new System.Windows.Forms.TrackBar();
            this.A_TrackBar = new System.Windows.Forms.TrackBar();
            this.B_Label = new System.Windows.Forms.Label();
            this.C_Label = new System.Windows.Forms.Label();
            this.A_Label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.LCTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATrackBar)).BeginInit();
            this.XORTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LCTabPage);
            this.tabControl1.Controls.Add(this.XORTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 228);
            this.tabControl1.TabIndex = 0;
            // 
            // LCTabPage
            // 
            this.LCTabPage.Controls.Add(this.BTrackBar);
            this.LCTabPage.Controls.Add(this.CTrackBar);
            this.LCTabPage.Controls.Add(this.ATrackBar);
            this.LCTabPage.Controls.Add(this.DecryptTextBox);
            this.LCTabPage.Controls.Add(this.EncryptTextBox);
            this.LCTabPage.Controls.Add(this.WordTextBox);
            this.LCTabPage.Controls.Add(this.DecryptLabel);
            this.LCTabPage.Controls.Add(this.EncryptLabel);
            this.LCTabPage.Controls.Add(this.WordLabel);
            this.LCTabPage.Controls.Add(this.BLabel);
            this.LCTabPage.Controls.Add(this.CLabel);
            this.LCTabPage.Controls.Add(this.ALabel);
            this.LCTabPage.Controls.Add(this.DecryptButton);
            this.LCTabPage.Controls.Add(this.EncryptButton);
            this.LCTabPage.Location = new System.Drawing.Point(4, 22);
            this.LCTabPage.Name = "LCTabPage";
            this.LCTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LCTabPage.Size = new System.Drawing.Size(551, 202);
            this.LCTabPage.TabIndex = 0;
            this.LCTabPage.Text = "Линейные конгруэнтные датчики";
            this.LCTabPage.UseVisualStyleBackColor = true;
            // 
            // BTrackBar
            // 
            this.BTrackBar.Location = new System.Drawing.Point(441, 107);
            this.BTrackBar.Minimum = 1;
            this.BTrackBar.Name = "BTrackBar";
            this.BTrackBar.Size = new System.Drawing.Size(104, 45);
            this.BTrackBar.TabIndex = 13;
            this.BTrackBar.Value = 1;
            this.BTrackBar.Scroll += new System.EventHandler(this.Form1_Load);
            // 
            // CTrackBar
            // 
            this.CTrackBar.Location = new System.Drawing.Point(441, 56);
            this.CTrackBar.Minimum = 1;
            this.CTrackBar.Name = "CTrackBar";
            this.CTrackBar.Size = new System.Drawing.Size(104, 45);
            this.CTrackBar.TabIndex = 12;
            this.CTrackBar.Value = 1;
            this.CTrackBar.Scroll += new System.EventHandler(this.Form1_Load);
            // 
            // ATrackBar
            // 
            this.ATrackBar.Location = new System.Drawing.Point(441, 5);
            this.ATrackBar.Minimum = 1;
            this.ATrackBar.Name = "ATrackBar";
            this.ATrackBar.Size = new System.Drawing.Size(104, 45);
            this.ATrackBar.TabIndex = 11;
            this.ATrackBar.Value = 1;
            this.ATrackBar.Scroll += new System.EventHandler(this.Form1_Load);
            // 
            // DecryptTextBox
            // 
            this.DecryptTextBox.Location = new System.Drawing.Point(8, 174);
            this.DecryptTextBox.Name = "DecryptTextBox";
            this.DecryptTextBox.Size = new System.Drawing.Size(200, 20);
            this.DecryptTextBox.TabIndex = 10;
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Location = new System.Drawing.Point(9, 101);
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.Size = new System.Drawing.Size(199, 20);
            this.EncryptTextBox.TabIndex = 9;
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(9, 30);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(199, 20);
            this.WordTextBox.TabIndex = 8;
            // 
            // DecryptLabel
            // 
            this.DecryptLabel.AutoSize = true;
            this.DecryptLabel.Location = new System.Drawing.Point(5, 157);
            this.DecryptLabel.Name = "DecryptLabel";
            this.DecryptLabel.Size = new System.Drawing.Size(127, 13);
            this.DecryptLabel.TabIndex = 7;
            this.DecryptLabel.Text = "Дешефрованная фраза";
            // 
            // EncryptLabel
            // 
            this.EncryptLabel.AutoSize = true;
            this.EncryptLabel.Location = new System.Drawing.Point(5, 82);
            this.EncryptLabel.Name = "EncryptLabel";
            this.EncryptLabel.Size = new System.Drawing.Size(125, 13);
            this.EncryptLabel.TabIndex = 6;
            this.EncryptLabel.Text = "Зашифрованная фраза";
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Location = new System.Drawing.Point(6, 12);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(102, 13);
            this.WordLabel.TabIndex = 5;
            this.WordLabel.Text = "Шифруемая фраза";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(330, 125);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(87, 13);
            this.BLabel.TabIndex = 4;
            this.BLabel.Text = "Коэффициент В";
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(330, 75);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(87, 13);
            this.CLabel.TabIndex = 3;
            this.CLabel.Text = "Коэффициент С";
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(330, 23);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(87, 13);
            this.ALabel.TabIndex = 2;
            this.ALabel.Text = "Коэффициент А";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(5, 127);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(103, 23);
            this.DecryptButton.TabIndex = 1;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.Decryptbutton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(5, 56);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(104, 23);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Зашифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // XORTabPage
            // 
            this.XORTabPage.Controls.Add(this.B_TrackBar);
            this.XORTabPage.Controls.Add(this.C_TrackBar);
            this.XORTabPage.Controls.Add(this.A_TrackBar);
            this.XORTabPage.Controls.Add(this.B_Label);
            this.XORTabPage.Controls.Add(this.C_Label);
            this.XORTabPage.Controls.Add(this.A_Label);
            this.XORTabPage.Controls.Add(this.T_Label);
            this.XORTabPage.Controls.Add(this.T_TextBox);
            this.XORTabPage.Controls.Add(this.Decrypt_TextBox);
            this.XORTabPage.Controls.Add(this.Encrypt_TextBox);
            this.XORTabPage.Controls.Add(this.Word_TextBox);
            this.XORTabPage.Controls.Add(this.Decrypt_Label);
            this.XORTabPage.Controls.Add(this.Encrypt_Label);
            this.XORTabPage.Controls.Add(this.Word_Label);
            this.XORTabPage.Controls.Add(this.Decrypt_Button);
            this.XORTabPage.Controls.Add(this.Encrypt_Button);
            this.XORTabPage.Location = new System.Drawing.Point(4, 22);
            this.XORTabPage.Name = "XORTabPage";
            this.XORTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.XORTabPage.Size = new System.Drawing.Size(551, 202);
            this.XORTabPage.TabIndex = 1;
            this.XORTabPage.Text = "Метод  гаммирования с обратной связью";
            this.XORTabPage.UseVisualStyleBackColor = true;
            // 
            // Decrypt_TextBox
            // 
            this.Decrypt_TextBox.Location = new System.Drawing.Point(8, 175);
            this.Decrypt_TextBox.Name = "Decrypt_TextBox";
            this.Decrypt_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Decrypt_TextBox.TabIndex = 18;
            // 
            // Encrypt_TextBox
            // 
            this.Encrypt_TextBox.Location = new System.Drawing.Point(9, 102);
            this.Encrypt_TextBox.Name = "Encrypt_TextBox";
            this.Encrypt_TextBox.Size = new System.Drawing.Size(199, 20);
            this.Encrypt_TextBox.TabIndex = 17;
            // 
            // Word_TextBox
            // 
            this.Word_TextBox.Location = new System.Drawing.Point(9, 31);
            this.Word_TextBox.Name = "Word_TextBox";
            this.Word_TextBox.Size = new System.Drawing.Size(199, 20);
            this.Word_TextBox.TabIndex = 16;
            // 
            // Decrypt_Label
            // 
            this.Decrypt_Label.AutoSize = true;
            this.Decrypt_Label.Location = new System.Drawing.Point(5, 158);
            this.Decrypt_Label.Name = "Decrypt_Label";
            this.Decrypt_Label.Size = new System.Drawing.Size(127, 13);
            this.Decrypt_Label.TabIndex = 15;
            this.Decrypt_Label.Text = "Дешефрованная фраза";
            // 
            // Encrypt_Label
            // 
            this.Encrypt_Label.AutoSize = true;
            this.Encrypt_Label.Location = new System.Drawing.Point(5, 83);
            this.Encrypt_Label.Name = "Encrypt_Label";
            this.Encrypt_Label.Size = new System.Drawing.Size(125, 13);
            this.Encrypt_Label.TabIndex = 14;
            this.Encrypt_Label.Text = "Зашифрованная фраза";
            // 
            // Word_Label
            // 
            this.Word_Label.AutoSize = true;
            this.Word_Label.Location = new System.Drawing.Point(6, 13);
            this.Word_Label.Name = "Word_Label";
            this.Word_Label.Size = new System.Drawing.Size(102, 13);
            this.Word_Label.TabIndex = 13;
            this.Word_Label.Text = "Шифруемая фраза";
            // 
            // Decrypt_Button
            // 
            this.Decrypt_Button.Location = new System.Drawing.Point(5, 128);
            this.Decrypt_Button.Name = "Decrypt_Button";
            this.Decrypt_Button.Size = new System.Drawing.Size(103, 23);
            this.Decrypt_Button.TabIndex = 12;
            this.Decrypt_Button.Text = "Расшифровать";
            this.Decrypt_Button.UseVisualStyleBackColor = true;
            this.Decrypt_Button.Click += new System.EventHandler(this.Decrypt_Button_Click);
            // 
            // Encrypt_Button
            // 
            this.Encrypt_Button.Location = new System.Drawing.Point(5, 57);
            this.Encrypt_Button.Name = "Encrypt_Button";
            this.Encrypt_Button.Size = new System.Drawing.Size(104, 23);
            this.Encrypt_Button.TabIndex = 11;
            this.Encrypt_Button.Text = "Зашифровать";
            this.Encrypt_Button.UseVisualStyleBackColor = true;
            this.Encrypt_Button.Click += new System.EventHandler(this.Encrypt_Button_Click);
            // 
            // T_TextBox
            // 
            this.T_TextBox.Location = new System.Drawing.Point(220, 36);
            this.T_TextBox.Name = "T_TextBox";
            this.T_TextBox.Size = new System.Drawing.Size(100, 20);
            this.T_TextBox.TabIndex = 19;
            // 
            // T_Label
            // 
            this.T_Label.AutoSize = true;
            this.T_Label.Location = new System.Drawing.Point(220, 13);
            this.T_Label.Name = "T_Label";
            this.T_Label.Size = new System.Drawing.Size(122, 13);
            this.T_Label.TabIndex = 20;
            this.T_Label.Text = "Начальное значение T";
            // 
            // B_TrackBar
            // 
            this.B_TrackBar.Location = new System.Drawing.Point(441, 133);
            this.B_TrackBar.Minimum = 1;
            this.B_TrackBar.Name = "B_TrackBar";
            this.B_TrackBar.Size = new System.Drawing.Size(104, 45);
            this.B_TrackBar.TabIndex = 26;
            this.B_TrackBar.Value = 1;
            this.B_TrackBar.Scroll += new System.EventHandler(this.Form1_Load);
            // 
            // C_TrackBar
            // 
            this.C_TrackBar.Location = new System.Drawing.Point(441, 82);
            this.C_TrackBar.Minimum = 1;
            this.C_TrackBar.Name = "C_TrackBar";
            this.C_TrackBar.Size = new System.Drawing.Size(104, 45);
            this.C_TrackBar.TabIndex = 25;
            this.C_TrackBar.Value = 1;
            this.C_TrackBar.Scroll += new System.EventHandler(this.Form1_Load);
            // 
            // A_TrackBar
            // 
            this.A_TrackBar.Location = new System.Drawing.Point(441, 31);
            this.A_TrackBar.Minimum = 1;
            this.A_TrackBar.Name = "A_TrackBar";
            this.A_TrackBar.Size = new System.Drawing.Size(104, 45);
            this.A_TrackBar.TabIndex = 24;
            this.A_TrackBar.Value = 1;
            this.A_TrackBar.Scroll += new System.EventHandler(this.Form1_Load);
            // 
            // B_Label
            // 
            this.B_Label.AutoSize = true;
            this.B_Label.Location = new System.Drawing.Point(330, 151);
            this.B_Label.Name = "B_Label";
            this.B_Label.Size = new System.Drawing.Size(87, 13);
            this.B_Label.TabIndex = 23;
            this.B_Label.Text = "Коэффициент В";
            // 
            // C_Label
            // 
            this.C_Label.AutoSize = true;
            this.C_Label.Location = new System.Drawing.Point(330, 101);
            this.C_Label.Name = "C_Label";
            this.C_Label.Size = new System.Drawing.Size(87, 13);
            this.C_Label.TabIndex = 22;
            this.C_Label.Text = "Коэффициент С";
            // 
            // A_Label
            // 
            this.A_Label.AutoSize = true;
            this.A_Label.Location = new System.Drawing.Point(330, 49);
            this.A_Label.Name = "A_Label";
            this.A_Label.Size = new System.Drawing.Size(87, 13);
            this.A_Label.TabIndex = 21;
            this.A_Label.Text = "Коэффициент А";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 279);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.LCTabPage.ResumeLayout(false);
            this.LCTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATrackBar)).EndInit();
            this.XORTabPage.ResumeLayout(false);
            this.XORTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_TrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LCTabPage;
        private System.Windows.Forms.TrackBar BTrackBar;
        private System.Windows.Forms.TrackBar CTrackBar;
        private System.Windows.Forms.TrackBar ATrackBar;
        private System.Windows.Forms.TextBox DecryptTextBox;
        private System.Windows.Forms.TextBox EncryptTextBox;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Label DecryptLabel;
        private System.Windows.Forms.Label EncryptLabel;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TabPage XORTabPage;
        private System.Windows.Forms.TextBox Decrypt_TextBox;
        private System.Windows.Forms.TextBox Encrypt_TextBox;
        private System.Windows.Forms.TextBox Word_TextBox;
        private System.Windows.Forms.Label Decrypt_Label;
        private System.Windows.Forms.Label Encrypt_Label;
        private System.Windows.Forms.Label Word_Label;
        private System.Windows.Forms.Button Decrypt_Button;
        private System.Windows.Forms.Button Encrypt_Button;
        private System.Windows.Forms.Label T_Label;
        private System.Windows.Forms.TextBox T_TextBox;
        private System.Windows.Forms.TrackBar B_TrackBar;
        private System.Windows.Forms.TrackBar C_TrackBar;
        private System.Windows.Forms.TrackBar A_TrackBar;
        private System.Windows.Forms.Label B_Label;
        private System.Windows.Forms.Label C_Label;
        private System.Windows.Forms.Label A_Label;
    }
}

