namespace Example
{
    partial class LBForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelList = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelBool = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.takeButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(206, 229);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelList);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.letterTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(198, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(68, 128);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(10, 13);
            this.labelList.TabIndex = 6;
            this.labelList.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Список:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(21, 161);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(158, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Буква:";
            // 
            // letterTextBox
            // 
            this.letterTextBox.Location = new System.Drawing.Point(21, 56);
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(158, 20);
            this.letterTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown);
            this.tabPage2.Controls.Add(this.labelBool);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.takeButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(198, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Логика";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(21, 56);
            this.numericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(158, 20);
            this.numericUpDown.TabIndex = 14;
            // 
            // labelBool
            // 
            this.labelBool.AutoSize = true;
            this.labelBool.Location = new System.Drawing.Point(144, 128);
            this.labelBool.Name = "labelBool";
            this.labelBool.Size = new System.Drawing.Size(10, 13);
            this.labelBool.TabIndex = 13;
            this.labelBool.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Логическое значение:";
            // 
            // takeButton
            // 
            this.takeButton.Location = new System.Drawing.Point(21, 161);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(158, 23);
            this.takeButton.TabIndex = 11;
            this.takeButton.Text = "Получить значение";
            this.takeButton.UseVisualStyleBackColor = true;
            this.takeButton.Click += new System.EventHandler(this.takeButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Число (1 или 0):";
            // 
            // LBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 253);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(246, 292);
            this.MinimumSize = new System.Drawing.Size(246, 292);
            this.Name = "LBForm";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox letterTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelBool;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button takeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}