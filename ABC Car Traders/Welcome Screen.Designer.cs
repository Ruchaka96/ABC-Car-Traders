
namespace ABC_Car_Traders
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.managecardetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(201, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome To ABC Car Traders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // managecardetails
            // 
            this.managecardetails.BackColor = System.Drawing.Color.DarkKhaki;
            this.managecardetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managecardetails.ForeColor = System.Drawing.Color.Indigo;
            this.managecardetails.Location = new System.Drawing.Point(310, 196);
            this.managecardetails.Name = "managecardetails";
            this.managecardetails.Size = new System.Drawing.Size(204, 57);
            this.managecardetails.TabIndex = 17;
            this.managecardetails.Text = "Admin";
            this.managecardetails.UseVisualStyleBackColor = false;
            this.managecardetails.Click += new System.EventHandler(this.managecardetails_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(310, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 57);
            this.button1.TabIndex = 18;
            this.button1.Text = "User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.managecardetails);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Login Function";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button managecardetails;
        private System.Windows.Forms.Button button1;
    }
}