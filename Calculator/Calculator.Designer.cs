namespace Calculator
{
    partial class Calculator
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.bMC = new System.Windows.Forms.Button();
            this.bMS = new System.Windows.Forms.Button();
            this.bMplus = new System.Windows.Forms.Button();
            this.bMminus = new System.Windows.Forms.Button();
            this.bMR = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bSqrt = new System.Windows.Forms.Button();
            this.bPlusMinus = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bBackspace = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.bPercent = new System.Windows.Forms.Button();
            this.bDivision = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.bInverse = new System.Windows.Forms.Button();
            this.bMull = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.bEqually = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bComma = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiView});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(214, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // tsmiView
            // 
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(39, 20);
            this.tsmiView.Text = "Вид";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 28);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox.Size = new System.Drawing.Size(190, 50);
            this.textBox.TabIndex = 1;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // bMC
            // 
            this.bMC.Location = new System.Drawing.Point(11, 82);
            this.bMC.Name = "bMC";
            this.bMC.Size = new System.Drawing.Size(36, 29);
            this.bMC.TabIndex = 2;
            this.bMC.Text = "MC";
            this.bMC.UseVisualStyleBackColor = true;
            // 
            // bMS
            // 
            this.bMS.Location = new System.Drawing.Point(89, 82);
            this.bMS.Name = "bMS";
            this.bMS.Size = new System.Drawing.Size(36, 29);
            this.bMS.TabIndex = 3;
            this.bMS.Text = "MS";
            this.bMS.UseVisualStyleBackColor = true;
            // 
            // bMplus
            // 
            this.bMplus.Location = new System.Drawing.Point(128, 82);
            this.bMplus.Name = "bMplus";
            this.bMplus.Size = new System.Drawing.Size(36, 29);
            this.bMplus.TabIndex = 4;
            this.bMplus.Text = "M+";
            this.bMplus.UseVisualStyleBackColor = true;
            // 
            // bMminus
            // 
            this.bMminus.Location = new System.Drawing.Point(167, 82);
            this.bMminus.Name = "bMminus";
            this.bMminus.Size = new System.Drawing.Size(36, 29);
            this.bMminus.TabIndex = 5;
            this.bMminus.Text = "M-";
            this.bMminus.UseVisualStyleBackColor = true;
            // 
            // bMR
            // 
            this.bMR.Location = new System.Drawing.Point(50, 82);
            this.bMR.Name = "bMR";
            this.bMR.Size = new System.Drawing.Size(36, 29);
            this.bMR.TabIndex = 6;
            this.bMR.Text = "MR";
            this.bMR.UseVisualStyleBackColor = true;
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(50, 114);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(36, 29);
            this.bCE.TabIndex = 11;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bSqrt
            // 
            this.bSqrt.Location = new System.Drawing.Point(167, 114);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(36, 29);
            this.bSqrt.TabIndex = 10;
            this.bSqrt.Text = "√";
            this.bSqrt.UseVisualStyleBackColor = true;
            this.bSqrt.Click += new System.EventHandler(this.bSqrt_Click);
            // 
            // bPlusMinus
            // 
            this.bPlusMinus.Location = new System.Drawing.Point(128, 114);
            this.bPlusMinus.Name = "bPlusMinus";
            this.bPlusMinus.Size = new System.Drawing.Size(36, 29);
            this.bPlusMinus.TabIndex = 9;
            this.bPlusMinus.Text = "+/-";
            this.bPlusMinus.UseVisualStyleBackColor = true;
            this.bPlusMinus.Click += new System.EventHandler(this.bPlusMinus_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(89, 114);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(36, 29);
            this.bC.TabIndex = 8;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bBackspace
            // 
            this.bBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBackspace.Location = new System.Drawing.Point(11, 114);
            this.bBackspace.Name = "bBackspace";
            this.bBackspace.Size = new System.Drawing.Size(36, 29);
            this.bBackspace.TabIndex = 7;
            this.bBackspace.Text = "←";
            this.bBackspace.UseVisualStyleBackColor = true;
            this.bBackspace.Click += new System.EventHandler(this.bBackspace_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(50, 146);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(36, 29);
            this.b8.TabIndex = 16;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.Digit_Click);
            // 
            // bPercent
            // 
            this.bPercent.Location = new System.Drawing.Point(167, 146);
            this.bPercent.Name = "bPercent";
            this.bPercent.Size = new System.Drawing.Size(36, 29);
            this.bPercent.TabIndex = 15;
            this.bPercent.Text = "%";
            this.bPercent.UseVisualStyleBackColor = true;
            // 
            // bDivision
            // 
            this.bDivision.Location = new System.Drawing.Point(128, 146);
            this.bDivision.Name = "bDivision";
            this.bDivision.Size = new System.Drawing.Size(36, 29);
            this.bDivision.TabIndex = 14;
            this.bDivision.Text = "/";
            this.bDivision.UseVisualStyleBackColor = true;
            this.bDivision.Click += new System.EventHandler(this.Operations_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(89, 146);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(36, 29);
            this.b9.TabIndex = 13;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.Digit_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b7.Location = new System.Drawing.Point(11, 146);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(36, 29);
            this.b7.TabIndex = 12;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.Digit_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(50, 178);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(36, 29);
            this.b5.TabIndex = 21;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.Digit_Click);
            // 
            // bInverse
            // 
            this.bInverse.Location = new System.Drawing.Point(167, 178);
            this.bInverse.Name = "bInverse";
            this.bInverse.Size = new System.Drawing.Size(36, 29);
            this.bInverse.TabIndex = 20;
            this.bInverse.Text = "1/x";
            this.bInverse.UseVisualStyleBackColor = true;
            // 
            // bMull
            // 
            this.bMull.Location = new System.Drawing.Point(128, 178);
            this.bMull.Name = "bMull";
            this.bMull.Size = new System.Drawing.Size(36, 29);
            this.bMull.TabIndex = 19;
            this.bMull.Text = "*";
            this.bMull.UseVisualStyleBackColor = true;
            this.bMull.Click += new System.EventHandler(this.Operations_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(89, 178);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(36, 29);
            this.b6.TabIndex = 18;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.Digit_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(11, 178);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(36, 29);
            this.b4.TabIndex = 17;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.Digit_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(50, 210);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(36, 29);
            this.b2.TabIndex = 26;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.Digit_Click);
            // 
            // bEqually
            // 
            this.bEqually.Location = new System.Drawing.Point(167, 210);
            this.bEqually.Name = "bEqually";
            this.bEqually.Size = new System.Drawing.Size(36, 61);
            this.bEqually.TabIndex = 25;
            this.bEqually.Text = "=";
            this.bEqually.UseVisualStyleBackColor = true;
            this.bEqually.Click += new System.EventHandler(this.bEqually_Click);
            // 
            // bMinus
            // 
            this.bMinus.Location = new System.Drawing.Point(128, 210);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(36, 29);
            this.bMinus.TabIndex = 24;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.Operations_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(89, 210);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(36, 29);
            this.b3.TabIndex = 23;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.Digit_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(11, 210);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(36, 29);
            this.b1.TabIndex = 22;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.Digit_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(11, 242);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 29);
            this.b0.TabIndex = 31;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.Digit_Click);
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(128, 242);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(36, 29);
            this.bPlus.TabIndex = 29;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.Operations_Click);
            // 
            // bComma
            // 
            this.bComma.Location = new System.Drawing.Point(89, 242);
            this.bComma.Name = "bComma";
            this.bComma.Size = new System.Drawing.Size(36, 29);
            this.bComma.TabIndex = 28;
            this.bComma.Text = ",";
            this.bComma.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 280);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bComma);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.bEqually);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.bInverse);
            this.Controls.Add(this.bMull);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.bPercent);
            this.Controls.Add(this.bDivision);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bSqrt);
            this.Controls.Add(this.bPlusMinus);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bBackspace);
            this.Controls.Add(this.bMR);
            this.Controls.Add(this.bMminus);
            this.Controls.Add(this.bMplus);
            this.Controls.Add(this.bMS);
            this.Controls.Add(this.bMC);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button bMC;
        private System.Windows.Forms.Button bMS;
        private System.Windows.Forms.Button bMplus;
        private System.Windows.Forms.Button bMminus;
        private System.Windows.Forms.Button bMR;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.Button bPlusMinus;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bBackspace;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button bPercent;
        private System.Windows.Forms.Button bDivision;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button bInverse;
        private System.Windows.Forms.Button bMull;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button bEqually;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bComma;
    }
}

