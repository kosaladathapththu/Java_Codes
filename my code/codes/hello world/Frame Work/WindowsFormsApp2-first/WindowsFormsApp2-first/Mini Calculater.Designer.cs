namespace WindowsFormsApp2_first
{
    partial class Mini_Calculater
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
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.btnplu = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btneq = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btn9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdisplay
            // 
            this.txtdisplay.Location = new System.Drawing.Point(66, 24);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(692, 37);
            this.txtdisplay.TabIndex = 0;
            // 
            // btnplu
            // 
            this.btnplu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnplu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplu.Location = new System.Drawing.Point(81, 121);
            this.btnplu.Name = "btnplu";
            this.btnplu.Size = new System.Drawing.Size(85, 37);
            this.btnplu.TabIndex = 1;
            this.btnplu.Text = "+";
            this.btnplu.UseVisualStyleBackColor = false;
            this.btnplu.Click += new System.EventHandler(this.btnplu_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.Color.Gainsboro;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnsub.Location = new System.Drawing.Point(275, 121);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(85, 37);
            this.btnsub.TabIndex = 2;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.Gainsboro;
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btndiv.Location = new System.Drawing.Point(449, 121);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(85, 37);
            this.btndiv.TabIndex = 3;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmul
            // 
            this.btnmul.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnmul.Location = new System.Drawing.Point(617, 121);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(85, 37);
            this.btnmul.TabIndex = 4;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = false;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gainsboro;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(617, 203);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 37);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gainsboro;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(449, 203);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 37);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gainsboro;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(275, 203);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 37);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gainsboro;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(81, 203);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(85, 37);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gainsboro;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(617, 275);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 37);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gainsboro;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(449, 275);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 37);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gainsboro;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(275, 275);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 37);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gainsboro;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(81, 275);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 37);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btneq
            // 
            this.btneq.BackColor = System.Drawing.Color.Gainsboro;
            this.btneq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneq.Location = new System.Drawing.Point(617, 344);
            this.btneq.Name = "btneq";
            this.btneq.Size = new System.Drawing.Size(85, 37);
            this.btneq.TabIndex = 16;
            this.btneq.Text = "=";
            this.btneq.UseVisualStyleBackColor = false;
            this.btneq.Click += new System.EventHandler(this.btneq_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.Gainsboro;
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnc.Location = new System.Drawing.Point(449, 344);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(85, 37);
            this.btnc.TabIndex = 15;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gainsboro;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(81, 344);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 37);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gainsboro;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(275, 344);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 37);
            this.btn9.TabIndex = 17;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // Mini_Calculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btneq);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnplu);
            this.Controls.Add(this.txtdisplay);
            this.Name = "Mini_Calculater";
            this.Text = "Mini_Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Button btnplu;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btneq;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btn9;
    }
}