
namespace Bank
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.transButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.card = new System.Windows.Forms.Panel();
            this.balance = new System.Windows.Forms.Label();
            this.cardNumber = new System.Windows.Forms.Label();
            this.nameAccount = new System.Windows.Forms.Label();
            this.transPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cardOwn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.card.SuspendLayout();
            this.transPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(1149, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 40);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(0, -3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(44, 43);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 3;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 40);
            this.panel1.TabIndex = 4;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuPanel.Controls.Add(this.transButton);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Location = new System.Drawing.Point(0, -1);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(288, 767);
            this.menuPanel.TabIndex = 5;
            this.menuPanel.Visible = false;
            // 
            // transButton
            // 
            this.transButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.transButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.transButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.transButton.FlatAppearance.BorderSize = 0;
            this.transButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transButton.Location = new System.Drawing.Point(90, 99);
            this.transButton.Name = "transButton";
            this.transButton.Size = new System.Drawing.Size(170, 57);
            this.transButton.TabIndex = 0;
            this.transButton.Text = "Transanction";
            this.transButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transButton.UseVisualStyleBackColor = false;
            this.transButton.Click += new System.EventHandler(this.trasnClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.trasnClick);
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Teal;
            this.card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card.Controls.Add(this.balance);
            this.card.Controls.Add(this.cardNumber);
            this.card.Location = new System.Drawing.Point(433, 112);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(599, 346);
            this.card.TabIndex = 6;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.Transparent;
            this.balance.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(17, 293);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(166, 33);
            this.balance.TabIndex = 1;
            this.balance.Text = "0000-0000";
            this.balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardNumber
            // 
            this.cardNumber.AutoSize = true;
            this.cardNumber.BackColor = System.Drawing.Color.Transparent;
            this.cardNumber.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumber.Location = new System.Drawing.Point(65, 211);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(118, 24);
            this.cardNumber.TabIndex = 0;
            this.cardNumber.Text = "0000-0000";
            this.cardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameAccount
            // 
            this.nameAccount.AutoSize = true;
            this.nameAccount.BackColor = System.Drawing.Color.Transparent;
            this.nameAccount.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAccount.Location = new System.Drawing.Point(659, 55);
            this.nameAccount.Name = "nameAccount";
            this.nameAccount.Size = new System.Drawing.Size(194, 45);
            this.nameAccount.TabIndex = 2;
            this.nameAccount.Text = "0000-0000";
            this.nameAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transPanel
            // 
            this.transPanel.Controls.Add(this.cardOwn);
            this.transPanel.Controls.Add(this.label1);
            this.transPanel.Location = new System.Drawing.Point(285, 36);
            this.transPanel.Name = "transPanel";
            this.transPanel.Size = new System.Drawing.Size(909, 730);
            this.transPanel.TabIndex = 7;
            this.transPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your number card";
            // 
            // cardOwn
            // 
            this.cardOwn.AutoSize = true;
            this.cardOwn.BackColor = System.Drawing.Color.White;
            this.cardOwn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardOwn.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardOwn.Location = new System.Drawing.Point(98, 146);
            this.cardOwn.Name = "cardOwn";
            this.cardOwn.Size = new System.Drawing.Size(2, 30);
            this.cardOwn.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1192, 764);
            this.Controls.Add(this.transPanel);
            this.Controls.Add(this.nameAccount);
            this.Controls.Add(this.card);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.transPanel.ResumeLayout(false);
            this.transPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.Label cardNumber;
        private System.Windows.Forms.Button transButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameAccount;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Panel transPanel;
        private System.Windows.Forms.Label cardOwn;
        private System.Windows.Forms.Label label1;
    }
}