namespace twentyone
{
    public partial class Blackjack
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
        public void InitializeComponent()
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnSurrender = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlPC2
            // 
            this.pnlPC2.Location = new System.Drawing.Point(433, 390);
            this.pnlPC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPC2.Name = "pnlPC2";
            this.pnlPC2.Size = new System.Drawing.Size(96, 118);
            this.pnlPC2.TabIndex = 5;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(88, 609);
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
            this.label1.Location = new System.Drawing.Point(33, 564);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bet $:";
            // 
            // pnlDC1
            // 
            this.pnlDC1.Location = new System.Drawing.Point(329, 69);
            this.pnlDC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDC1.Name = "pnlDC1";
            this.pnlDC1.Size = new System.Drawing.Size(96, 118);
            this.pnlDC1.TabIndex = 4;
            // 
            // pnlplayerHand1
            // 
            this.pnlplayerHand1.Location = new System.Drawing.Point(329, 390);
            this.pnlplayerHand1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlplayerHand1.Name = "pnlplayerHand1";
            this.pnlplayerHand1.Size = new System.Drawing.Size(96, 118);
            this.pnlplayerHand1.TabIndex = 4;
            // 
            // pnlplayerHand0
            // 
            this.pnlplayerHand0.Location = new System.Drawing.Point(225, 390);
            this.pnlplayerHand0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlplayerHand0.Name = "pnlplayerHand0";
            this.pnlplayerHand0.Size = new System.Drawing.Size(96, 118);
            this.pnlplayerHand0.TabIndex = 3;
            // 
            // pnlDC0
            // 
            this.pnlDC0.Location = new System.Drawing.Point(225, 69);
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
            this.comboBox1.Location = new System.Drawing.Point(88, 560);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(433, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 118);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(537, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 118);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(537, 390);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 118);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(641, 69);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 118);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(641, 390);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 118);
            this.panel5.TabIndex = 5;
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(225, 609);
            this.btnHit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(100, 28);
            this.btnHit.TabIndex = 11;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(491, 609);
            this.btnDouble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(100, 28);
            this.btnDouble.TabIndex = 13;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(353, 609);
            this.btnSplit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(100, 28);
            this.btnSplit.TabIndex = 12;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(611, 609);
            this.btnStand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(100, 28);
            this.btnStand.TabIndex = 14;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnSurrender
            // 
            this.btnSurrender.Location = new System.Drawing.Point(749, 609);
            this.btnSurrender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSurrender.Name = "btnSurrender";
            this.btnSurrender.Size = new System.Drawing.Size(100, 28);
            this.btnSurrender.TabIndex = 15;
            this.btnSurrender.Text = "Surrender";
            this.btnSurrender.UseVisualStyleBackColor = true;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(325, 564);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(88, 17);
            this.lblMoney.TabIndex = 16;
            this.lblMoney.Text = "Your Money:";
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 677);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.btnSurrender);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.Text = "BlackJack";
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
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnSurrender;
        public System.Windows.Forms.Label lblMoney;
        public System.Windows.Forms.Button btnHit;
    }
}

