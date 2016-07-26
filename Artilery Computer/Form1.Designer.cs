namespace Artilery_Computer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.disFromStoT = new System.Windows.Forms.Label();
            this.disFromT = new System.Windows.Forms.TextBox();
            this.disFromS = new System.Windows.Forms.TextBox();
            this.bearFromStoT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bearingToT = new System.Windows.Forms.TextBox();
            this.bearingToS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bearing to Target (Degrees)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bearing to shooter (Degrees)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distance from Target (Meters)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Distance from Shooter (Meters)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Distance from Shooter to Target";
            // 
            // disFromStoT
            // 
            this.disFromStoT.AutoSize = true;
            this.disFromStoT.Location = new System.Drawing.Point(339, 52);
            this.disFromStoT.Name = "disFromStoT";
            this.disFromStoT.Size = new System.Drawing.Size(13, 13);
            this.disFromStoT.TabIndex = 9;
            this.disFromStoT.Text = "0";
            this.disFromStoT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disFromT
            // 
            this.disFromT.Location = new System.Drawing.Point(36, 119);
            this.disFromT.Name = "disFromT";
            this.disFromT.Size = new System.Drawing.Size(100, 20);
            this.disFromT.TabIndex = 2;
            this.disFromT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disFromT_KeyPress);
            this.disFromT.Validating += new System.ComponentModel.CancelEventHandler(this.disFromT_Validating);
            // 
            // disFromS
            // 
            this.disFromS.Location = new System.Drawing.Point(36, 241);
            this.disFromS.Name = "disFromS";
            this.disFromS.Size = new System.Drawing.Size(100, 20);
            this.disFromS.TabIndex = 4;
            this.disFromS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disFromS_KeyPress);
            this.disFromS.Validating += new System.ComponentModel.CancelEventHandler(this.disFromS_Validating);
            // 
            // bearFromStoT
            // 
            this.bearFromStoT.AutoSize = true;
            this.bearFromStoT.Location = new System.Drawing.Point(339, 111);
            this.bearFromStoT.Name = "bearFromStoT";
            this.bearFromStoT.Size = new System.Drawing.Size(13, 13);
            this.bearFromStoT.TabIndex = 13;
            this.bearFromStoT.Text = "0";
            this.bearFromStoT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bearing from Shooter to Target";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bearingToT
            // 
            this.bearingToT.Location = new System.Drawing.Point(36, 55);
            this.bearingToT.Name = "bearingToT";
            this.bearingToT.Size = new System.Drawing.Size(100, 20);
            this.bearingToT.TabIndex = 1;
            this.bearingToT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bearingToT_KeyPress);
            this.bearingToT.Validating += new System.ComponentModel.CancelEventHandler(this.bearingToT_Validating);
            // 
            // bearingToS
            // 
            this.bearingToS.Location = new System.Drawing.Point(36, 171);
            this.bearingToS.Name = "bearingToS";
            this.bearingToS.Size = new System.Drawing.Size(100, 20);
            this.bearingToS.TabIndex = 3;
            this.bearingToS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bearingToS_KeyPress);
            this.bearingToS.Validating += new System.ComponentModel.CancelEventHandler(this.bearingToS_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 295);
            this.Controls.Add(this.bearingToS);
            this.Controls.Add(this.bearingToT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bearFromStoT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.disFromS);
            this.Controls.Add(this.disFromT);
            this.Controls.Add(this.disFromStoT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Arma Compass Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label disFromStoT;
        private System.Windows.Forms.TextBox disFromT;
        private System.Windows.Forms.TextBox disFromS;
        private System.Windows.Forms.Label bearFromStoT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bearingToT;
        private System.Windows.Forms.TextBox bearingToS;
    }
}

