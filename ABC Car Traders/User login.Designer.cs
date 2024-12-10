
namespace ABC_Car_Traders
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.mypassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.myusername = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(373, 557);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(517, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "If You Haven\'t Account";
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.DarkKhaki;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Indigo;
            this.exitbutton.Location = new System.Drawing.Point(684, 297);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(147, 40);
            this.exitbutton.TabIndex = 20;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.DarkKhaki;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.Indigo;
            this.loginbutton.Location = new System.Drawing.Point(521, 297);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(147, 40);
            this.loginbutton.TabIndex = 19;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // mypassword
            // 
            this.mypassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mypassword.ForeColor = System.Drawing.Color.Indigo;
            this.mypassword.Location = new System.Drawing.Point(521, 212);
            this.mypassword.Multiline = true;
            this.mypassword.Name = "mypassword";
            this.mypassword.PasswordChar = '.';
            this.mypassword.Size = new System.Drawing.Size(310, 30);
            this.mypassword.TabIndex = 18;
            this.mypassword.TextChanged += new System.EventHandler(this.mypassword_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Indigo;
            this.password.Location = new System.Drawing.Point(397, 215);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(103, 20);
            this.password.TabIndex = 17;
            this.password.Text = "Password :";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // myusername
            // 
            this.myusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myusername.ForeColor = System.Drawing.Color.Indigo;
            this.myusername.Location = new System.Drawing.Point(521, 148);
            this.myusername.Multiline = true;
            this.myusername.Name = "myusername";
            this.myusername.Size = new System.Drawing.Size(310, 30);
            this.myusername.TabIndex = 16;
            this.myusername.TextChanged += new System.EventHandler(this.myusername_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Indigo;
            this.username.Location = new System.Drawing.Point(397, 151);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(106, 20);
            this.username.TabIndex = 15;
            this.username.Text = "Username :";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(597, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "User Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(521, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.mypassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.myusername);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form5";
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox mypassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox myusername;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}