namespace twentyone
{
    partial class Blackjack
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
            this.pnlPC2 = new System.Windows.Forms.Panel();
            this.btnDeal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDC1 = new System.Windows.Forms.Panel();
            this.pnlplayerHand1 = new System.Windows.Forms.Panel();
            this.pnlplayerHand0 = new System.Windows.Forms.Panel();
            this.pnlDC0 = new System.Windows.Forms.Panel();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlPC2
            // 
            this.pnlPC2.Location = new System.Drawing.Point(592, 390);
            this.pnlPC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPC2.Name = "pnlPC2";
            this.pnlPC2.Size = new System.Drawing.Size(96, 118);
            this.pnlPC2.TabIndex = 5;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(847, 513);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(100, 28);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 438);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bet $:";
            // 
            // pnlDC1
            // 
            this.pnlDC1.Location = new System.Drawing.Point(488, 69);
            this.pnlDC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDC1.Name = "pnlDC1";
            this.pnlDC1.Size = new System.Drawing.Size(96, 118);
            this.pnlDC1.TabIndex = 4;
            // 
            // pnlplayerHand1
            // 
            this.pnlplayerHand1.Location = new System.Drawing.Point(488, 390);
            this.pnlplayerHand1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlplayerHand1.Name = "pnlplayerHand1";
            this.pnlplayerHand1.Size = new System.Drawing.Size(96, 118);
            this.pnlplayerHand1.TabIndex = 4;
            // 
            // pnlplayerHand0
            // 
            this.pnlplayerHand0.Location = new System.Drawing.Point(384, 390);
            this.pnlplayerHand0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlplayerHand0.Name = "pnlplayerHand0";
            this.pnlplayerHand0.Size = new System.Drawing.Size(96, 118);
            this.pnlplayerHand0.TabIndex = 3;
            // 
            // pnlDC0
            // 
            this.pnlDC0.Location = new System.Drawing.Point(384, 69);
            this.pnlDC0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDC0.Name = "pnlDC0";
            this.pnlDC0.Size = new System.Drawing.Size(96, 118);
            this.pnlDC0.TabIndex = 4;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(33, 69);
            this.lblDealer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(105, 17);
            this.lblDealer.TabIndex = 5;
            this.lblDealer.Text = "Dealer\'s Score:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(33, 390);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(103, 17);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "Player\'s Score:";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Location = new System.Drawing.Point(147, 69);
            this.lblDealerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(0, 17);
            this.lblDealerScore.TabIndex = 7;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(144, 390);
            this.lblPlayerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerScore.TabIndex = 8;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(453, 283);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 17);
            this.lblWinner.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1000",
            "500",
            "250",
            "100",
            "50",
            "25",
            "10",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(812, 434);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 677);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlplayerHand1);
            this.Controls.Add(this.pnlDC1);
            this.Controls.Add(this.pnlPC2);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.pnlplayerHand0);
            this.Controls.Add(this.pnlDC0);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlplayerHand0;
        public System.Windows.Forms.Panel pnlplayerHand1;
        public System.Windows.Forms.Panel pnlDC0;
        public System.Windows.Forms.Panel pnlDC1;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Label lblPlayerScore;
        public System.Windows.Forms.Panel pnlPC2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

