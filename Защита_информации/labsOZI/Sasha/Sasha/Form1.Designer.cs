namespace Sasha
{
    partial class CodingForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.codeRearrange = new System.Windows.Forms.Button();
            this.outStringRearrange = new System.Windows.Forms.TextBox();
            this.inStringRearrange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.codeSubstitution = new System.Windows.Forms.Button();
            this.outStringSubstitution = new System.Windows.Forms.TextBox();
            this.inStringSubstitution = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 192);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.codeRearrange);
            this.tabPage1.Controls.Add(this.outStringRearrange);
            this.tabPage1.Controls.Add(this.inStringRearrange);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Перестановка";
            // 
            // codeRearrange
            // 
            this.codeRearrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeRearrange.Location = new System.Drawing.Point(6, 76);
            this.codeRearrange.Name = "codeRearrange";
            this.codeRearrange.Size = new System.Drawing.Size(113, 37);
            this.codeRearrange.TabIndex = 3;
            this.codeRearrange.Text = "Закодировать";
            this.codeRearrange.UseVisualStyleBackColor = true;
            this.codeRearrange.Click += new System.EventHandler(this.codeRearrange_Click);
            // 
            // outStringRearrange
            // 
            this.outStringRearrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outStringRearrange.Location = new System.Drawing.Point(6, 119);
            this.outStringRearrange.Name = "outStringRearrange";
            this.outStringRearrange.Size = new System.Drawing.Size(256, 26);
            this.outStringRearrange.TabIndex = 2;
            this.outStringRearrange.TextChanged += new System.EventHandler(this.codeRearrange_Click);
            // 
            // inStringRearrange
            // 
            this.inStringRearrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inStringRearrange.Location = new System.Drawing.Point(6, 44);
            this.inStringRearrange.Name = "inStringRearrange";
            this.inStringRearrange.Size = new System.Drawing.Size(256, 26);
            this.inStringRearrange.TabIndex = 1;
            this.inStringRearrange.TextChanged += new System.EventHandler(this.codeRearrange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входная строка";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.codeSubstitution);
            this.tabPage2.Controls.Add(this.outStringSubstitution);
            this.tabPage2.Controls.Add(this.inStringSubstitution);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(363, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подстановка";
            // 
            // codeSubstitution
            // 
            this.codeSubstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeSubstitution.Location = new System.Drawing.Point(6, 68);
            this.codeSubstitution.Name = "codeSubstitution";
            this.codeSubstitution.Size = new System.Drawing.Size(113, 37);
            this.codeSubstitution.TabIndex = 7;
            this.codeSubstitution.Text = "Закодировать";
            this.codeSubstitution.UseVisualStyleBackColor = true;
            this.codeSubstitution.Click += new System.EventHandler(this.codeSubstitution_Click);
            // 
            // outStringSubstitution
            // 
            this.outStringSubstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outStringSubstitution.Location = new System.Drawing.Point(6, 111);
            this.outStringSubstitution.Name = "outStringSubstitution";
            this.outStringSubstitution.Size = new System.Drawing.Size(256, 26);
            this.outStringSubstitution.TabIndex = 6;
            this.outStringSubstitution.TextChanged += new System.EventHandler(this.codeSubstitution_Click);
            // 
            // inStringSubstitution
            // 
            this.inStringSubstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inStringSubstitution.Location = new System.Drawing.Point(6, 36);
            this.inStringSubstitution.Name = "inStringSubstitution";
            this.inStringSubstitution.Size = new System.Drawing.Size(256, 26);
            this.inStringSubstitution.TabIndex = 5;
            this.inStringSubstitution.TextChanged += new System.EventHandler(this.codeSubstitution_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Входная строка";
            // 
            // CodingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 234);
            this.Controls.Add(this.tabControl1);
            this.Name = "CodingForm";
            this.Text = "Кодирование";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox inStringRearrange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button codeRearrange;
        private System.Windows.Forms.TextBox outStringRearrange;
        private System.Windows.Forms.Button codeSubstitution;
        private System.Windows.Forms.TextBox outStringSubstitution;
        private System.Windows.Forms.TextBox inStringSubstitution;
        private System.Windows.Forms.Label label2;
    }
}

