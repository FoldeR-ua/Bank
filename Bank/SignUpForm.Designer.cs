
namespace Bank
{
    partial class SignUpForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backArrow = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.snameBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordMainBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.confBox = new System.Windows.Forms.TextBox();
            this.registerButt = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.Label();
            this.snameError = new System.Windows.Forms.Label();
            this.loginError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.confError = new System.Windows.Forms.Label();
            this.pasportBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pasportError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(801, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 40);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 56);
            this.label4.TabIndex = 10;
            this.label4.Text = "Login \r\n( e-mail: Gmail, Ukr.net,I.UA )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 96);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bee Bank\r\n Sign Up";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 56);
            this.label5.TabIndex = 11;
            this.label5.Text = "Passwors \r\n( minimum 8 characters )";
            // 
            // backArrow
            // 
            this.backArrow.Image = global::Bank.Properties.Resources.back_svg;
            this.backArrow.Location = new System.Drawing.Point(12, 9);
            this.backArrow.Name = "backArrow";
            this.backArrow.Size = new System.Drawing.Size(50, 51);
            this.backArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrow.TabIndex = 12;
            this.backArrow.TabStop = false;
            this.backArrow.Click += new System.EventHandler(this.backArrow_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(68, 164);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(304, 36);
            this.nameBox.TabIndex = 13;
            // 
            // snameBox
            // 
            this.snameBox.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snameBox.Location = new System.Drawing.Point(68, 271);
            this.snameBox.Name = "snameBox";
            this.snameBox.Size = new System.Drawing.Size(304, 36);
            this.snameBox.TabIndex = 14;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBox.Location = new System.Drawing.Point(68, 407);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(304, 36);
            this.loginBox.TabIndex = 15;
            // 
            // passwordMainBox
            // 
            this.passwordMainBox.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordMainBox.Location = new System.Drawing.Point(68, 565);
            this.passwordMainBox.Name = "passwordMainBox";
            this.passwordMainBox.PasswordChar = '*';
            this.passwordMainBox.Size = new System.Drawing.Size(304, 36);
            this.passwordMainBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Confirm password";
            // 
            // confBox
            // 
            this.confBox.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBox.Location = new System.Drawing.Point(467, 565);
            this.confBox.Name = "confBox";
            this.confBox.PasswordChar = '*';
            this.confBox.Size = new System.Drawing.Size(304, 36);
            this.confBox.TabIndex = 18;
            // 
            // registerButt
            // 
            this.registerButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerButt.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerButt.Location = new System.Drawing.Point(342, 645);
            this.registerButt.Name = "registerButt";
            this.registerButt.Size = new System.Drawing.Size(165, 77);
            this.registerButt.TabIndex = 19;
            this.registerButt.Text = "SIGN UP";
            this.registerButt.UseVisualStyleBackColor = false;
            this.registerButt.Click += new System.EventHandler(this.registerButt_Click);
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(148, 120);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(200, 20);
            this.nameError.TabIndex = 20;
            this.nameError.Text = "Write your name corerctly :)";
            this.nameError.Visible = false;
            // 
            // snameError
            // 
            this.snameError.AutoSize = true;
            this.snameError.ForeColor = System.Drawing.Color.Red;
            this.snameError.Location = new System.Drawing.Point(167, 231);
            this.snameError.Name = "snameError";
            this.snameError.Size = new System.Drawing.Size(222, 20);
            this.snameError.TabIndex = 21;
            this.snameError.Text = "Write your surname corerctly :)";
            this.snameError.Visible = false;
            // 
            // loginError
            // 
            this.loginError.AutoSize = true;
            this.loginError.ForeColor = System.Drawing.Color.Red;
            this.loginError.Location = new System.Drawing.Point(142, 337);
            this.loginError.Name = "loginError";
            this.loginError.Size = new System.Drawing.Size(206, 20);
            this.loginError.TabIndex = 22;
            this.loginError.Text = "Write your e-mail corerctly  :)";
            this.loginError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(172, 488);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(228, 20);
            this.passwordError.TabIndex = 23;
            this.passwordError.Text = "Write your password corerctly :)";
            this.passwordError.Visible = false;
            // 
            // confError
            // 
            this.confError.AutoSize = true;
            this.confError.ForeColor = System.Drawing.Color.Red;
            this.confError.Location = new System.Drawing.Point(513, 616);
            this.confError.Name = "confError";
            this.confError.Size = new System.Drawing.Size(187, 20);
            this.confError.TabIndex = 24;
            this.confError.Text = "Password doesn`t seems";
            this.confError.Visible = false;
            // 
            // pasportBox
            // 
            this.pasportBox.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasportBox.Location = new System.Drawing.Point(446, 271);
            this.pasportBox.Name = "pasportBox";
            this.pasportBox.Size = new System.Drawing.Size(304, 36);
            this.pasportBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 28);
            this.label7.TabIndex = 26;
            this.label7.Text = "Pasport number";
            // 
            // pasportError
            // 
            this.pasportError.AutoSize = true;
            this.pasportError.ForeColor = System.Drawing.Color.Red;
            this.pasportError.Location = new System.Drawing.Point(463, 320);
            this.pasportError.Name = "pasportError";
            this.pasportError.Size = new System.Drawing.Size(276, 20);
            this.pasportError.TabIndex = 27;
            this.pasportError.Text = "Write your pasport number corerctly  :)";
            this.pasportError.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(845, 740);
            this.Controls.Add(this.pasportError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pasportBox);
            this.Controls.Add(this.confError);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.loginError);
            this.Controls.Add(this.snameError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.registerButt);
            this.Controls.Add(this.confBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordMainBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.snameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.backArrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox backArrow;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox snameBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordMainBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox confBox;
        private System.Windows.Forms.Button registerButt;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label snameError;
        private System.Windows.Forms.Label loginError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label confError;
        private System.Windows.Forms.TextBox pasportBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pasportError;
    }
}