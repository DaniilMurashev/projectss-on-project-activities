
namespace konvertorvaluti
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rub1 = new System.Windows.Forms.RadioButton();
            this.usd1 = new System.Windows.Forms.RadioButton();
            this.eur1 = new System.Windows.Forms.RadioButton();
            this.gbp1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbp2 = new System.Windows.Forms.RadioButton();
            this.eur2 = new System.Windows.Forms.RadioButton();
            this.usd2 = new System.Windows.Forms.RadioButton();
            this.rub2 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "У меня есть";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Я хочу пробрести";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.rub1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usd1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.eur1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbp1, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(104, 168);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 42);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // rub1
            // 
            this.rub1.AutoSize = true;
            this.rub1.Location = new System.Drawing.Point(3, 3);
            this.rub1.Name = "rub1";
            this.rub1.Size = new System.Drawing.Size(48, 17);
            this.rub1.TabIndex = 1;
            this.rub1.TabStop = true;
            this.rub1.Text = "RUB";
            this.rub1.UseVisualStyleBackColor = true;
            // 
            // usd1
            // 
            this.usd1.AutoSize = true;
            this.usd1.Location = new System.Drawing.Point(57, 3);
            this.usd1.Name = "usd1";
            this.usd1.Size = new System.Drawing.Size(48, 17);
            this.usd1.TabIndex = 0;
            this.usd1.TabStop = true;
            this.usd1.Text = "USD";
            this.usd1.UseVisualStyleBackColor = true;
            // 
            // eur1
            // 
            this.eur1.AutoSize = true;
            this.eur1.Location = new System.Drawing.Point(111, 3);
            this.eur1.Name = "eur1";
            this.eur1.Size = new System.Drawing.Size(48, 17);
            this.eur1.TabIndex = 2;
            this.eur1.TabStop = true;
            this.eur1.Text = "EUR";
            this.eur1.UseVisualStyleBackColor = true;
            // 
            // gbp1
            // 
            this.gbp1.AutoSize = true;
            this.gbp1.Location = new System.Drawing.Point(165, 3);
            this.gbp1.Name = "gbp1";
            this.gbp1.Size = new System.Drawing.Size(47, 17);
            this.gbp1.TabIndex = 3;
            this.gbp1.TabStop = true;
            this.gbp1.Text = "GBP";
            this.gbp1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbp2
            // 
            this.gbp2.AutoSize = true;
            this.gbp2.Location = new System.Drawing.Point(165, 3);
            this.gbp2.Name = "gbp2";
            this.gbp2.Size = new System.Drawing.Size(47, 17);
            this.gbp2.TabIndex = 3;
            this.gbp2.TabStop = true;
            this.gbp2.Text = "GBP";
            this.gbp2.UseVisualStyleBackColor = true;
            // 
            // eur2
            // 
            this.eur2.AutoSize = true;
            this.eur2.Location = new System.Drawing.Point(111, 3);
            this.eur2.Name = "eur2";
            this.eur2.Size = new System.Drawing.Size(48, 17);
            this.eur2.TabIndex = 2;
            this.eur2.TabStop = true;
            this.eur2.Text = "EUR";
            this.eur2.UseVisualStyleBackColor = true;
            // 
            // usd2
            // 
            this.usd2.AutoSize = true;
            this.usd2.Location = new System.Drawing.Point(57, 3);
            this.usd2.Name = "usd2";
            this.usd2.Size = new System.Drawing.Size(48, 17);
            this.usd2.TabIndex = 0;
            this.usd2.TabStop = true;
            this.usd2.Text = "USD";
            this.usd2.UseVisualStyleBackColor = true;
            // 
            // rub2
            // 
            this.rub2.AutoSize = true;
            this.rub2.Location = new System.Drawing.Point(3, 3);
            this.rub2.Name = "rub2";
            this.rub2.Size = new System.Drawing.Size(48, 17);
            this.rub2.TabIndex = 1;
            this.rub2.TabStop = true;
            this.rub2.Text = "RUB";
            this.rub2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.rub2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.usd2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.eur2, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.gbp2, 5, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(458, 168);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(216, 42);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton usd1;
        private System.Windows.Forms.RadioButton rub1;
        private System.Windows.Forms.RadioButton eur1;
        private System.Windows.Forms.RadioButton gbp1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton gbp2;
        private System.Windows.Forms.RadioButton eur2;
        private System.Windows.Forms.RadioButton usd2;
        private System.Windows.Forms.RadioButton rub2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

