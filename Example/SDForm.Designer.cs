namespace Example
{
    partial class SDForm
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
            this.SNumber1TextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SNumber2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.summaButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSumma = new System.Windows.Forms.Label();
            this.differenceButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DNumber2TextBox = new System.Windows.Forms.TextBox();
            this.DNumber1TextBox = new System.Windows.Forms.TextBox();
            this.labelDifference = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SNumber1TextBox
            // 
            this.SNumber1TextBox.Location = new System.Drawing.Point(21, 32);
            this.SNumber1TextBox.Name = "SNumber1TextBox";
            this.SNumber1TextBox.Size = new System.Drawing.Size(158, 20);
            this.SNumber1TextBox.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(206, 229);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelSumma);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.summaButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SNumber2TextBox);
            this.tabPage1.Controls.Add(this.SNumber1TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(198, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сумма";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelDifference);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.differenceButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.DNumber2TextBox);
            this.tabPage2.Controls.Add(this.DNumber1TextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(198, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Разность";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SNumber2TextBox
            // 
            this.SNumber2TextBox.Location = new System.Drawing.Point(21, 83);
            this.SNumber2TextBox.Name = "SNumber2TextBox";
            this.SNumber2TextBox.Size = new System.Drawing.Size(158, 20);
            this.SNumber2TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число 2:";
            // 
            // summaButton
            // 
            this.summaButton.Location = new System.Drawing.Point(21, 161);
            this.summaButton.Name = "summaButton";
            this.summaButton.Size = new System.Drawing.Size(158, 23);
            this.summaButton.TabIndex = 4;
            this.summaButton.Text = "Сумма";
            this.summaButton.UseVisualStyleBackColor = true;
            this.summaButton.Click += new System.EventHandler(this.summaButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма:";
            // 
            // labelSumma
            // 
            this.labelSumma.AutoSize = true;
            this.labelSumma.Location = new System.Drawing.Point(68, 128);
            this.labelSumma.Name = "labelSumma";
            this.labelSumma.Size = new System.Drawing.Size(10, 13);
            this.labelSumma.TabIndex = 6;
            this.labelSumma.Text = ".";
            // 
            // differenceButton
            // 
            this.differenceButton.Location = new System.Drawing.Point(21, 161);
            this.differenceButton.Name = "differenceButton";
            this.differenceButton.Size = new System.Drawing.Size(158, 23);
            this.differenceButton.TabIndex = 11;
            this.differenceButton.Text = "Разность";
            this.differenceButton.UseVisualStyleBackColor = true;
            this.differenceButton.Click += new System.EventHandler(this.differenceButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Число 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Число 1:";
            // 
            // DNumber2TextBox
            // 
            this.DNumber2TextBox.Location = new System.Drawing.Point(21, 83);
            this.DNumber2TextBox.Name = "DNumber2TextBox";
            this.DNumber2TextBox.Size = new System.Drawing.Size(158, 20);
            this.DNumber2TextBox.TabIndex = 8;
            // 
            // DNumber1TextBox
            // 
            this.DNumber1TextBox.Location = new System.Drawing.Point(21, 32);
            this.DNumber1TextBox.Name = "DNumber1TextBox";
            this.DNumber1TextBox.Size = new System.Drawing.Size(158, 20);
            this.DNumber1TextBox.TabIndex = 7;
            // 
            // labelDifference
            // 
            this.labelDifference.AutoSize = true;
            this.labelDifference.Location = new System.Drawing.Point(82, 128);
            this.labelDifference.Name = "labelDifference";
            this.labelDifference.Size = new System.Drawing.Size(10, 13);
            this.labelDifference.TabIndex = 13;
            this.labelDifference.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Разность:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 253);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(246, 292);
            this.MinimumSize = new System.Drawing.Size(246, 292);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SNumber1TextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelSumma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button summaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SNumber2TextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelDifference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button differenceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DNumber2TextBox;
        private System.Windows.Forms.TextBox DNumber1TextBox;
    }
}

