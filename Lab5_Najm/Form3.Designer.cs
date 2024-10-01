namespace Lab5_Najm
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "--->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(164, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "|v";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayer1.Location = new System.Drawing.Point(12, 12);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(70, 30);
            this.btnPlayer1.TabIndex = 2;
            this.btnPlayer1.UseVisualStyleBackColor = false;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackColor = System.Drawing.Color.Aqua;
            this.btnPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayer2.Location = new System.Drawing.Point(12, 48);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(30, 70);
            this.btnPlayer2.TabIndex = 3;
            this.btnPlayer2.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(140, 218);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 30);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnStop;
    }
}