namespace twentyone
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstCardPanel = new System.Windows.Forms.Panel();
            this.dealButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.firstCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(462, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 113);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(58, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 113);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(45, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 113);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // firstCardPanel
            // 
            this.firstCardPanel.BackColor = System.Drawing.Color.Transparent;
            this.firstCardPanel.Controls.Add(this.panel2);
            this.firstCardPanel.Location = new System.Drawing.Point(473, 464);
            this.firstCardPanel.Name = "firstCardPanel";
            this.firstCardPanel.Size = new System.Drawing.Size(97, 113);
            this.firstCardPanel.TabIndex = 1;
            this.firstCardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dealButton
            // 
            this.dealButton.BackColor = System.Drawing.Color.Transparent;
            this.dealButton.Location = new System.Drawing.Point(385, 623);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(144, 93);
            this.dealButton.TabIndex = 2;
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::twentyone.Properties.Resources.blackjackpntn_screenshot_unbranded;
            this.ClientSize = new System.Drawing.Size(1021, 762);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.firstCardPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Blackjack";
            this.panel1.ResumeLayout(false);
            this.firstCardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel firstCardPanel;
        private System.Windows.Forms.Button dealButton;
    }
}