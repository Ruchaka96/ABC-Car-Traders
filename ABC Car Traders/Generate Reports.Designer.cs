
namespace ABC_Car_Traders
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.dataview = new System.Windows.Forms.DataGridView();
            this.printbutton = new System.Windows.Forms.Button();
            this.viewbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homebutton2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebutton2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataview
            // 
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(23, 83);
            this.dataview.Name = "dataview";
            this.dataview.RowHeadersWidth = 51;
            this.dataview.RowTemplate.Height = 24;
            this.dataview.Size = new System.Drawing.Size(648, 261);
            this.dataview.TabIndex = 0;
            // 
            // printbutton
            // 
            this.printbutton.BackColor = System.Drawing.Color.DarkKhaki;
            this.printbutton.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbutton.ForeColor = System.Drawing.Color.Indigo;
            this.printbutton.Location = new System.Drawing.Point(552, 361);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(119, 38);
            this.printbutton.TabIndex = 15;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = false;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // viewbutton
            // 
            this.viewbutton.BackColor = System.Drawing.Color.DarkKhaki;
            this.viewbutton.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbutton.ForeColor = System.Drawing.Color.Indigo;
            this.viewbutton.Location = new System.Drawing.Point(427, 361);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(119, 38);
            this.viewbutton.TabIndex = 16;
            this.viewbutton.Text = "View";
            this.viewbutton.UseVisualStyleBackColor = false;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(381, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "ABC Car Traders";
            // 
            // homebutton2
            // 
            this.homebutton2.BackColor = System.Drawing.Color.Transparent;
            this.homebutton2.Image = ((System.Drawing.Image)(resources.GetObject("homebutton2.Image")));
            this.homebutton2.Location = new System.Drawing.Point(993, 463);
            this.homebutton2.Name = "homebutton2";
            this.homebutton2.Size = new System.Drawing.Size(42, 38);
            this.homebutton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homebutton2.TabIndex = 18;
            this.homebutton2.TabStop = false;
            this.homebutton2.Click += new System.EventHandler(this.homebutton2_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 513);
            this.Controls.Add(this.homebutton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewbutton);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.dataview);
            this.DoubleBuffered = true;
            this.Name = "Form16";
            this.Text = "Generate Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebutton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox homebutton2;
    }
}