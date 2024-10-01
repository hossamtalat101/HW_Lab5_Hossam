namespace Lab5_Najm
{
    partial class Form2
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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWidth = new System.Windows.Forms.Button();
            this.btnHeightInc = new System.Windows.Forms.Button();
            this.btnWidthDec = new System.Windows.Forms.Button();
            this.btnHeightDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRight.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(340, 160);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 40);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTop.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.Location = new System.Drawing.Point(248, 85);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(40, 40);
            this.btnTop.TabIndex = 3;
            this.btnTop.Text = "^";
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLeft.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(156, 160);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 40);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBottom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottom.Location = new System.Drawing.Point(248, 241);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(40, 40);
            this.btnBottom.TabIndex = 5;
            this.btnBottom.Text = "v";
            this.btnBottom.UseVisualStyleBackColor = false;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-4, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnWidth
            // 
            this.btnWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWidth.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWidth.Location = new System.Drawing.Point(294, 160);
            this.btnWidth.Name = "btnWidth";
            this.btnWidth.Size = new System.Drawing.Size(40, 40);
            this.btnWidth.TabIndex = 10;
            this.btnWidth.Text = "+";
            this.btnWidth.UseVisualStyleBackColor = false;
            this.btnWidth.Click += new System.EventHandler(this.btnWidth_Click);
            // 
            // btnHeightInc
            // 
            this.btnHeightInc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHeightInc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeightInc.Location = new System.Drawing.Point(248, 131);
            this.btnHeightInc.Name = "btnHeightInc";
            this.btnHeightInc.Size = new System.Drawing.Size(40, 40);
            this.btnHeightInc.TabIndex = 9;
            this.btnHeightInc.Text = "+";
            this.btnHeightInc.UseVisualStyleBackColor = false;
            this.btnHeightInc.Click += new System.EventHandler(this.btnHeightInc_Click);
            // 
            // btnWidthDec
            // 
            this.btnWidthDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWidthDec.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWidthDec.Location = new System.Drawing.Point(202, 160);
            this.btnWidthDec.Name = "btnWidthDec";
            this.btnWidthDec.Size = new System.Drawing.Size(40, 40);
            this.btnWidthDec.TabIndex = 8;
            this.btnWidthDec.Text = "-";
            this.btnWidthDec.UseVisualStyleBackColor = false;
            this.btnWidthDec.Click += new System.EventHandler(this.btnWidthDec_Click);
            // 
            // btnHeightDec
            // 
            this.btnHeightDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHeightDec.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeightDec.Location = new System.Drawing.Point(248, 195);
            this.btnHeightDec.Name = "btnHeightDec";
            this.btnHeightDec.Size = new System.Drawing.Size(40, 40);
            this.btnHeightDec.TabIndex = 7;
            this.btnHeightDec.Text = "-";
            this.btnHeightDec.UseVisualStyleBackColor = false;
            this.btnHeightDec.Click += new System.EventHandler(this.btnHeightDec_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 287);
            this.Controls.Add(this.btnWidth);
            this.Controls.Add(this.btnHeightInc);
            this.Controls.Add(this.btnWidthDec);
            this.Controls.Add(this.btnHeightDec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnRight);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWidth;
        private System.Windows.Forms.Button btnHeightInc;
        private System.Windows.Forms.Button btnWidthDec;
        private System.Windows.Forms.Button btnHeightDec;
    }
}