namespace YugiohManager
{
  partial class FrmLogin
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.txtLoginPassword = new System.Windows.Forms.TextBox();
      this.txtLoginUsername = new System.Windows.Forms.TextBox();
      this.btnSignup = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtSignupPasswordConfirm = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.txtSignupToken = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtSignupPassword = new System.Windows.Forms.TextBox();
      this.txtSignupUsername = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(64, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(244, 40);
      this.label1.TabIndex = 0;
      this.label1.Text = "Yu-Gi-Oh Manager";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(88, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(196, 40);
      this.label2.TabIndex = 1;
      this.label2.Text = "Login";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(8, 24);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 28);
      this.label3.TabIndex = 2;
      this.label3.Text = "Username:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(8, 56);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(72, 28);
      this.label4.TabIndex = 3;
      this.label4.Text = "Password:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnLogin);
      this.groupBox1.Controls.Add(this.txtLoginPassword);
      this.groupBox1.Controls.Add(this.txtLoginUsername);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Location = new System.Drawing.Point(40, 96);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(292, 136);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Login";
      // 
      // btnLogin
      // 
      this.btnLogin.Location = new System.Drawing.Point(212, 104);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(75, 23);
      this.btnLogin.TabIndex = 3;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // txtLoginPassword
      // 
      this.txtLoginPassword.Location = new System.Drawing.Point(84, 60);
      this.txtLoginPassword.Name = "txtLoginPassword";
      this.txtLoginPassword.PasswordChar = '*';
      this.txtLoginPassword.Size = new System.Drawing.Size(200, 23);
      this.txtLoginPassword.TabIndex = 2;
      // 
      // txtLoginUsername
      // 
      this.txtLoginUsername.Location = new System.Drawing.Point(84, 28);
      this.txtLoginUsername.Name = "txtLoginUsername";
      this.txtLoginUsername.Size = new System.Drawing.Size(200, 23);
      this.txtLoginUsername.TabIndex = 1;
      this.txtLoginUsername.TextChanged += new System.EventHandler(this.txtLoginUsername_TextChanged);
      // 
      // btnSignup
      // 
      this.btnSignup.Location = new System.Drawing.Point(256, 172);
      this.btnSignup.Name = "btnSignup";
      this.btnSignup.Size = new System.Drawing.Size(75, 23);
      this.btnSignup.TabIndex = 8;
      this.btnSignup.Text = "Signup";
      this.btnSignup.UseVisualStyleBackColor = true;
      this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(64, 236);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(244, 96);
      this.label5.TabIndex = 5;
      this.label5.Text = "Don\'t have an account? Signup below!";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtSignupPasswordConfirm);
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.txtSignupToken);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.txtSignupPassword);
      this.groupBox2.Controls.Add(this.txtSignupUsername);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.btnSignup);
      this.groupBox2.Location = new System.Drawing.Point(12, 340);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(336, 204);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Signup";
      // 
      // txtSignupPasswordConfirm
      // 
      this.txtSignupPasswordConfirm.Location = new System.Drawing.Point(128, 92);
      this.txtSignupPasswordConfirm.Name = "txtSignupPasswordConfirm";
      this.txtSignupPasswordConfirm.PasswordChar = '*';
      this.txtSignupPasswordConfirm.Size = new System.Drawing.Size(200, 23);
      this.txtSignupPasswordConfirm.TabIndex = 6;
      this.txtSignupPasswordConfirm.LostFocus += new System.EventHandler(this.txtSignupPasswordConfirm_LostFocus);
      // 
      // label9
      // 
      this.label9.Location = new System.Drawing.Point(8, 88);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(116, 28);
      this.label9.TabIndex = 12;
      this.label9.Text = "Confirm Password:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtSignupToken
      // 
      this.txtSignupToken.Location = new System.Drawing.Point(128, 124);
      this.txtSignupToken.Name = "txtSignupToken";
      this.txtSignupToken.PasswordChar = '*';
      this.txtSignupToken.Size = new System.Drawing.Size(200, 23);
      this.txtSignupToken.TabIndex = 7;
      // 
      // label8
      // 
      this.label8.Location = new System.Drawing.Point(40, 120);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(84, 28);
      this.label8.TabIndex = 10;
      this.label8.Text = "Signup Token:";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtSignupPassword
      // 
      this.txtSignupPassword.Location = new System.Drawing.Point(128, 60);
      this.txtSignupPassword.Name = "txtSignupPassword";
      this.txtSignupPassword.PasswordChar = '*';
      this.txtSignupPassword.Size = new System.Drawing.Size(200, 23);
      this.txtSignupPassword.TabIndex = 5;
      this.txtSignupPassword.TextChanged += new System.EventHandler(this.txtSignupPassword_TextChanged);
      // 
      // txtSignupUsername
      // 
      this.txtSignupUsername.Location = new System.Drawing.Point(128, 28);
      this.txtSignupUsername.Name = "txtSignupUsername";
      this.txtSignupUsername.Size = new System.Drawing.Size(200, 23);
      this.txtSignupUsername.TabIndex = 4;
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(52, 24);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(72, 28);
      this.label6.TabIndex = 7;
      this.label6.Text = "Username:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(52, 56);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(72, 28);
      this.label7.TabIndex = 8;
      this.label7.Text = "Password:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // FrmLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(360, 553);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "FrmLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.Load += new System.EventHandler(this.FrmLogin_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.TextBox txtLoginPassword;
    private System.Windows.Forms.TextBox txtLoginUsername;
    private System.Windows.Forms.Button btnSignup;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtSignupPassword;
    private System.Windows.Forms.TextBox txtSignupUsername;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtSignupToken;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtSignupPasswordConfirm;
    private System.Windows.Forms.Label label9;
  }
}

