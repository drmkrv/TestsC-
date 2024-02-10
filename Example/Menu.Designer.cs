namespace Example
{
    partial class Menu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SDButton = new System.Windows.Forms.Button();
            this.LBButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SDButton);
            this.flowLayoutPanel1.Controls.Add(this.LBButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 127);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SDButton
            // 
            this.SDButton.Location = new System.Drawing.Point(3, 3);
            this.SDButton.Name = "SDButton";
            this.SDButton.Size = new System.Drawing.Size(220, 55);
            this.SDButton.TabIndex = 0;
            this.SDButton.Text = "Сумма/разность";
            this.SDButton.UseVisualStyleBackColor = true;
            this.SDButton.Click += new System.EventHandler(this.SDButton_Click);
            // 
            // LBButton
            // 
            this.LBButton.Location = new System.Drawing.Point(3, 64);
            this.LBButton.Name = "LBButton";
            this.LBButton.Size = new System.Drawing.Size(220, 55);
            this.LBButton.TabIndex = 1;
            this.LBButton.Text = "Список/Логика";
            this.LBButton.UseVisualStyleBackColor = true;
            this.LBButton.Click += new System.EventHandler(this.LBButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 151);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SDButton;
        private System.Windows.Forms.Button LBButton;
    }
}