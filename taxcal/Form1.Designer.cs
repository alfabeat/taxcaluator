namespace taxcal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labsel = new System.Windows.Forms.Label();
            this.cbxtax = new System.Windows.Forms.ComboBox();
            this.butselect = new System.Windows.Forms.Button();
            this.labtotal = new System.Windows.Forms.Label();
            this.labtax = new System.Windows.Forms.Label();
            this.labtaxi = new System.Windows.Forms.Label();
            this.labtoli = new System.Windows.Forms.Label();
            this.txbamout = new System.Windows.Forms.TextBox();
            this.txbamout2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labsel
            // 
            this.labsel.AutoSize = true;
            this.labsel.Location = new System.Drawing.Point(39, 75);
            this.labsel.Name = "labsel";
            this.labsel.Size = new System.Drawing.Size(38, 15);
            this.labsel.TabIndex = 0;
            this.labsel.Text = "label1";
            // 
            // cbxtax
            // 
            this.cbxtax.FormattingEnabled = true;
            this.cbxtax.Items.AddRange(new object[] {
            "Salary",
            "hourly",
            "bussiness"});
            this.cbxtax.Location = new System.Drawing.Point(105, 72);
            this.cbxtax.Name = "cbxtax";
            this.cbxtax.Size = new System.Drawing.Size(121, 23);
            this.cbxtax.TabIndex = 1;
            this.cbxtax.Text = "Salary";
            // 
            // butselect
            // 
            this.butselect.Location = new System.Drawing.Point(267, 72);
            this.butselect.Name = "butselect";
            this.butselect.Size = new System.Drawing.Size(75, 23);
            this.butselect.TabIndex = 2;
            this.butselect.Text = "button1";
            this.butselect.UseVisualStyleBackColor = true;
            this.butselect.Click += new System.EventHandler(this.butselect_Click);
            // 
            // labtotal
            // 
            this.labtotal.AutoSize = true;
            this.labtotal.Location = new System.Drawing.Point(39, 149);
            this.labtotal.Name = "labtotal";
            this.labtotal.Size = new System.Drawing.Size(38, 15);
            this.labtotal.TabIndex = 3;
            this.labtotal.Text = "label2";
            // 
            // labtax
            // 
            this.labtax.AutoSize = true;
            this.labtax.Location = new System.Drawing.Point(39, 201);
            this.labtax.Name = "labtax";
            this.labtax.Size = new System.Drawing.Size(38, 15);
            this.labtax.TabIndex = 4;
            this.labtax.Text = "label3";
            // 
            // labtaxi
            // 
            this.labtaxi.AutoSize = true;
            this.labtaxi.Location = new System.Drawing.Point(105, 149);
            this.labtaxi.Name = "labtaxi";
            this.labtaxi.Size = new System.Drawing.Size(38, 15);
            this.labtaxi.TabIndex = 5;
            this.labtaxi.Text = "label4";
            // 
            // labtoli
            // 
            this.labtoli.AutoSize = true;
            this.labtoli.Location = new System.Drawing.Point(105, 201);
            this.labtoli.Name = "labtoli";
            this.labtoli.Size = new System.Drawing.Size(38, 15);
            this.labtoli.TabIndex = 6;
            this.labtoli.Text = "label5";
            // 
            // txbamout
            // 
            this.txbamout.Location = new System.Drawing.Point(105, 101);
            this.txbamout.Name = "txbamout";
            this.txbamout.Size = new System.Drawing.Size(100, 23);
            this.txbamout.TabIndex = 7;
            // 
            // txbamout2
            // 
            this.txbamout2.Location = new System.Drawing.Point(267, 101);
            this.txbamout2.Name = "txbamout2";
            this.txbamout2.Size = new System.Drawing.Size(100, 23);
            this.txbamout2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbamout2);
            this.Controls.Add(this.txbamout);
            this.Controls.Add(this.labtoli);
            this.Controls.Add(this.labtaxi);
            this.Controls.Add(this.labtax);
            this.Controls.Add(this.labtotal);
            this.Controls.Add(this.butselect);
            this.Controls.Add(this.cbxtax);
            this.Controls.Add(this.labsel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labsel;
        private ComboBox cbxtax;
        private Button butselect;
        private Label labtotal;
        private Label labtax;
        private Label labtaxi;
        private Label labtoli;
        private TextBox txbamout;
        private TextBox txbamout2;
    }
}