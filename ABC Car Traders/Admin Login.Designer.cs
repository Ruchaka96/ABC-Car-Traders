
namespace ABC_Car_Traders
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exitbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.adminpassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.adminusername = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(382, 460);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.DarkKhaki;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Indigo;
            this.exitbutton.Location = new System.Drawing.Point(699, 321);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(147, 40);
            this.exitbutton.TabIndex = 27;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.DarkKhaki;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.Indigo;
            this.loginbutton.Location = new System.Drawing.Point(536, 321);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(147, 40);
            this.loginbutton.TabIndex = 26;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // adminpassword
            // 
            this.adminpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adminpassword.ForeColor = System.Drawing.Color.Indigo;
            this.adminpassword.Location = new System.Drawing.Point(536, 236);
            this.adminpassword.Multiline = true;
            this.adminpassword.Name = "adminpassword";
            this.adminpassword.PasswordChar = '*';
            this.adminpassword.Size = new System.Drawing.Size(310, 30);
            this.adminpassword.TabIndex = 25;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Indigo;
            this.password.Location = new System.Drawing.Point(412, 239);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(103, 20);
            this.password.TabIndex = 24;
            this.password.Text = "Password :";
            // 
            // adminusername
            // 
            this.adminusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminusername.ForeColor = System.Drawing.Color.Indigo;
            this.adminusername.Location = new System.Drawing.Point(536, 172);
            this.adminusername.Multiline = true;
            this.adminusername.Name = "adminusername";
            this.adminusername.Size = new System.Drawing.Size(310, 30);
            this.adminusername.TabIndex = 23;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Indigo;
            this.username.Location = new System.Drawing.Point(412, 175);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(106, 20);
            this.username.TabIndex = 22;
            this.username.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(612, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Admin Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 462);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.adminpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.adminusername);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form7";
            this.Text = "Admin Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox adminpassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox adminusername;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
    }
}