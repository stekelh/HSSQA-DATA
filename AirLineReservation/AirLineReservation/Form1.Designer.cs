namespace AirLineReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flightClassBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seatNoBox = new System.Windows.Forms.ComboBox();
            this.addPass = new System.Windows.Forms.Button();
            this.closeFlight = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Passanger Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Flight Class";
            // 
            // flightClassBox
            // 
            this.flightClassBox.FormattingEnabled = true;
            this.flightClassBox.Location = new System.Drawing.Point(205, 110);
            this.flightClassBox.Name = "flightClassBox";
            this.flightClassBox.Size = new System.Drawing.Size(121, 21);
            this.flightClassBox.TabIndex = 3;
            this.flightClassBox.SelectedIndexChanged += new System.EventHandler(this.flightClassBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleect Seat No.";
            // 
            // seatNoBox
            // 
            this.seatNoBox.FormattingEnabled = true;
            this.seatNoBox.Location = new System.Drawing.Point(473, 115);
            this.seatNoBox.Name = "seatNoBox";
            this.seatNoBox.Size = new System.Drawing.Size(49, 21);
            this.seatNoBox.TabIndex = 5;
            // 
            // addPass
            // 
            this.addPass.Location = new System.Drawing.Point(84, 147);
            this.addPass.Name = "addPass";
            this.addPass.Size = new System.Drawing.Size(192, 29);
            this.addPass.TabIndex = 7;
            this.addPass.Text = "Add Passenger";
            this.addPass.UseVisualStyleBackColor = true;
            this.addPass.Click += new System.EventHandler(this.addPass_Click);
            // 
            // closeFlight
            // 
            this.closeFlight.Location = new System.Drawing.Point(323, 147);
            this.closeFlight.Name = "closeFlight";
            this.closeFlight.Size = new System.Drawing.Size(143, 29);
            this.closeFlight.TabIndex = 8;
            this.closeFlight.Text = "Close Flight";
            this.closeFlight.UseVisualStyleBackColor = true;
            this.closeFlight.Click += new System.EventHandler(this.closeFlight_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(548, 316);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 508);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.closeFlight);
            this.Controls.Add(this.addPass);
            this.Controls.Add(this.seatNoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flightClassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox flightClassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox seatNoBox;
        private System.Windows.Forms.Button addPass;
        private System.Windows.Forms.Button closeFlight;
        private System.Windows.Forms.ListBox listBox1;
    }
}

