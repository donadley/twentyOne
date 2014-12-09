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
            this.pnlPC2.Location = new System.Drawing.Point(325, 317);
            this.pnlPC2.Name = "pnlPC2";
            this.pnlPC2.Size = new System.Drawing.Size(72, 96);
            this.pnlPC2.TabIndex = 5;
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.Silver;
            this.btnDeal.Location = new System.Drawing.Point(66, 495);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bet $:";
            // 
            // pnlDC1
            // 
            this.pnlDC1.Location = new System.Drawing.Point(247, 56);
            this.pnlDC1.Name = "pnlDC1";
            this.pnlDC1.Size = new System.Drawing.Size(72, 96);
            this.pnlDC1.TabIndex = 4;
            // 
            // pnlplayerHand1
            // 
            this.pnlplayerHand1.Location = new System.Drawing.Point(247, 317);
            this.pnlplayerHand1.Name = "pnlplayerHand1";
            this.pnlplayerHand1.Size = new System.Drawing.Size(72, 96);
            this.pnlplayerHand1.TabIndex = 4;
            // 
            // pnlplayerHand0
            // 
            this.pnlplayerHand0.Location = new System.Drawing.Point(169, 317);
            this.pnlplayerHand0.Name = "pnlplayerHand0";
            this.pnlplayerHand0.Size = new System.Drawing.Size(72, 96);
            this.pnlplayerHand0.TabIndex = 3;
            // 
            // pnlDC0
            // 
            this.pnlDC0.Location = new System.Drawing.Point(169, 56);
            this.pnlDC0.Name = "pnlDC0";
            this.pnlDC0.Size = new System.Drawing.Size(72, 96);
            this.pnlDC0.TabIndex = 4;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.ForeColor = System.Drawing.Color.Black;
            this.lblDealer.Location = new System.Drawing.Point(25, 56);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(79, 13);
            this.lblDealer.TabIndex = 5;
            this.lblDealer.Text = "Dealer\'s Score:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(25, 317);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(77, 13);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "Player\'s Score:";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.ForeColor = System.Drawing.Color.Black;
            this.lblDealerScore.Location = new System.Drawing.Point(110, 56);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(0, 13);
            this.lblDealerScore.TabIndex = 7;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(108, 317);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerScore.TabIndex = 8;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(340, 230);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 13);
            this.lblWinner.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.comboBox1.Location = new System.Drawing.Point(66, 455);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(325, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 96);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(403, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 96);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(403, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 96);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(481, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(72, 96);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(481, 317);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(72, 96);
            this.panel5.TabIndex = 5;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Silver;
            this.btnHit.Location = new System.Drawing.Point(169, 495);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 11;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.Silver;
            this.btnDouble.Location = new System.Drawing.Point(368, 495);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 23);
            this.btnDouble.TabIndex = 13;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Visible = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.Silver;
            this.btnSplit.Location = new System.Drawing.Point(265, 495);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 12;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Visible = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Silver;
            this.btnStand.Location = new System.Drawing.Point(458, 495);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 14;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Visible = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnSurrender
            // 
            this.btnSurrender.BackColor = System.Drawing.Color.Silver;
            this.btnSurrender.Location = new System.Drawing.Point(562, 495);
            this.btnSurrender.Name = "btnSurrender";
            this.btnSurrender.Size = new System.Drawing.Size(75, 23);
            this.btnSurrender.TabIndex = 15;
            this.btnSurrender.Text = "Surrender";
            this.btnSurrender.UseVisualStyleBackColor = false;
            this.btnSurrender.Visible = false;
            this.btnSurrender.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(244, 458);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(67, 13);
            this.lblMoney.TabIndex = 16;
            this.lblMoney.Text = "Your Money:";
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(929, 550);
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
            this.Name = "Blackjack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Blackjack_Load);
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

