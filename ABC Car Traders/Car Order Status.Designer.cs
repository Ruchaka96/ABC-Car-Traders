﻿
namespace ABC_Car_Traders
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.label1 = new System.Windows.Forms.Label();
            this.signuplabel = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusbox = new System.Windows.Forms.ComboBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.carpricebox = new System.Windows.Forms.TextBox();
            this.carcolourbox = new System.Windows.Forms.TextBox();
            this.manufactureyearbox = new System.Windows.Forms.TextBox();
            this.carmodelbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carnamebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carserialnumberbox = new System.Windows.Forms.TextBox();
            this.customerusername = new System.Windows.Forms.Label();
            this.carordersdata = new System.Windows.Forms.DataGridView();
            this.btn_View = new System.Windows.Forms.Button();
            this.homebutton2 = new System.Windows.Forms.PictureBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carordersdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebutton2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(350, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "ABC Car Traders";
            // 
            // signuplabel
            // 
            this.signuplabel.AutoSize = true;
            this.signuplabel.BackColor = System.Drawing.Color.Transparent;
            this.signuplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuplabel.ForeColor = System.Drawing.Color.Indigo;
            this.signuplabel.Location = new System.Drawing.Point(34, 77);
            this.signuplabel.Name = "signuplabel";
            this.signuplabel.Size = new System.Drawing.Size(208, 29);
            this.signuplabel.TabIndex = 19;
            this.signuplabel.Text = "Car Order Status";
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.DarkKhaki;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.Indigo;
            this.updatebutton.Location = new System.Drawing.Point(601, 309);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(119, 38);
            this.updatebutton.TabIndex = 95;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(635, 264);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(225, 22);
            this.txtquantity.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(502, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 93;
            this.label9.Text = "Quantity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(502, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 92;
            this.label2.Text = "Status :";
            // 
            // statusbox
            // 
            this.statusbox.FormattingEnabled = true;
            this.statusbox.Items.AddRange(new object[] {
            "Delivered",
            "Order"});
            this.statusbox.Location = new System.Drawing.Point(635, 218);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(225, 24);
            this.statusbox.TabIndex = 91;
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.DarkKhaki;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.Indigo;
            this.clearbutton.Location = new System.Drawing.Point(741, 309);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(119, 38);
            this.clearbutton.TabIndex = 90;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // carpricebox
            // 
            this.carpricebox.Location = new System.Drawing.Point(633, 177);
            this.carpricebox.Name = "carpricebox";
            this.carpricebox.Size = new System.Drawing.Size(225, 22);
            this.carpricebox.TabIndex = 89;
            // 
            // carcolourbox
            // 
            this.carcolourbox.Location = new System.Drawing.Point(633, 134);
            this.carcolourbox.Name = "carcolourbox";
            this.carcolourbox.Size = new System.Drawing.Size(225, 22);
            this.carcolourbox.TabIndex = 88;
            // 
            // manufactureyearbox
            // 
            this.manufactureyearbox.Location = new System.Drawing.Point(209, 273);
            this.manufactureyearbox.Name = "manufactureyearbox";
            this.manufactureyearbox.Size = new System.Drawing.Size(225, 22);
            this.manufactureyearbox.TabIndex = 87;
            // 
            // carmodelbox
            // 
            this.carmodelbox.Location = new System.Drawing.Point(209, 226);
            this.carmodelbox.Name = "carmodelbox";
            this.carmodelbox.Size = new System.Drawing.Size(225, 22);
            this.carmodelbox.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(36, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 85;
            this.label8.Text = "Car Model :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(502, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 84;
            this.label6.Text = "Colour :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(502, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 83;
            this.label5.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(36, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Manufacture Year :";
            // 
            // carnamebox
            // 
            this.carnamebox.Location = new System.Drawing.Point(209, 178);
            this.carnamebox.Name = "carnamebox";
            this.carnamebox.Size = new System.Drawing.Size(225, 22);
            this.carnamebox.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(36, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "Car Name :";
            // 
            // carserialnumberbox
            // 
            this.carserialnumberbox.Location = new System.Drawing.Point(209, 132);
            this.carserialnumberbox.Name = "carserialnumberbox";
            this.carserialnumberbox.Size = new System.Drawing.Size(225, 22);
            this.carserialnumberbox.TabIndex = 79;
            // 
            // customerusername
            // 
            this.customerusername.AutoSize = true;
            this.customerusername.BackColor = System.Drawing.Color.Transparent;
            this.customerusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerusername.ForeColor = System.Drawing.Color.Indigo;
            this.customerusername.Location = new System.Drawing.Point(36, 130);
            this.customerusername.Name = "customerusername";
            this.customerusername.Size = new System.Drawing.Size(149, 18);
            this.customerusername.TabIndex = 78;
            this.customerusername.Text = "car serial number :";
            // 
            // carordersdata
            // 
            this.carordersdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carordersdata.Location = new System.Drawing.Point(37, 363);
            this.carordersdata.Name = "carordersdata";
            this.carordersdata.RowHeadersWidth = 51;
            this.carordersdata.RowTemplate.Height = 24;
            this.carordersdata.Size = new System.Drawing.Size(821, 232);
            this.carordersdata.TabIndex = 96;
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.Indigo;
            this.btn_View.Location = new System.Drawing.Point(925, 475);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(123, 39);
            this.btn_View.TabIndex = 100;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // homebutton2
            // 
            this.homebutton2.BackColor = System.Drawing.Color.Transparent;
            this.homebutton2.Image = ((System.Drawing.Image)(resources.GetObject("homebutton2.Image")));
            this.homebutton2.Location = new System.Drawing.Point(1006, 545);
            this.homebutton2.Name = "homebutton2";
            this.homebutton2.Size = new System.Drawing.Size(42, 38);
            this.homebutton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homebutton2.TabIndex = 99;
            this.homebutton2.TabStop = false;
            this.homebutton2.Click += new System.EventHandler(this.homebutton2_Click);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(903, 387);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(172, 22);
            this.searchbox.TabIndex = 98;
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.DarkKhaki;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.Color.Indigo;
            this.searchbutton.Location = new System.Drawing.Point(925, 425);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(123, 37);
            this.searchbutton.TabIndex = 97;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 607);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.homebutton2);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.carordersdata);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.carpricebox);
            this.Controls.Add(this.carcolourbox);
            this.Controls.Add(this.manufactureyearbox);
            this.Controls.Add(this.carmodelbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carnamebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carserialnumberbox);
            this.Controls.Add(this.customerusername);
            this.Controls.Add(this.signuplabel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form14";
            this.Text = "Car Order Status";
            ((System.ComponentModel.ISupportInitialize)(this.carordersdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebutton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label signuplabel;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusbox;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox carpricebox;
        private System.Windows.Forms.TextBox carcolourbox;
        private System.Windows.Forms.TextBox manufactureyearbox;
        private System.Windows.Forms.TextBox carmodelbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carnamebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carserialnumberbox;
        private System.Windows.Forms.Label customerusername;
        private System.Windows.Forms.DataGridView carordersdata;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.PictureBox homebutton2;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button searchbutton;
    }
}