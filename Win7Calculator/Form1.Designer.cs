namespace Win7Calculator
{
    partial class MainForm
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
            this.JustCanvas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MC = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MS = new System.Windows.Forms.Button();
            this.MPlus = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.ChangeSign = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.MMinus = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.DivideByX = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JustCanvas
            // 
            this.JustCanvas.Dock = System.Windows.Forms.DockStyle.Top;
            this.JustCanvas.Location = new System.Drawing.Point(0, 0);
            this.JustCanvas.Multiline = true;
            this.JustCanvas.Name = "JustCanvas";
            this.JustCanvas.ReadOnly = true;
            this.JustCanvas.Size = new System.Drawing.Size(372, 160);
            this.JustCanvas.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 67);
            this.label2.TabIndex = 1;
            // 
            // MC
            // 
            this.MC.Location = new System.Drawing.Point(12, 166);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(65, 30);
            this.MC.TabIndex = 2;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = true;
            this.MC.Click += new System.EventHandler(this.MC_Click);
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(83, 166);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(65, 30);
            this.MR.TabIndex = 3;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.MR_Click);
            // 
            // MS
            // 
            this.MS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MS.Location = new System.Drawing.Point(154, 166);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(65, 30);
            this.MS.TabIndex = 4;
            this.MS.Text = "MS";
            this.MS.UseVisualStyleBackColor = true;
            this.MS.Click += new System.EventHandler(this.MS_Click);
            // 
            // MPlus
            // 
            this.MPlus.Location = new System.Drawing.Point(225, 166);
            this.MPlus.Name = "MPlus";
            this.MPlus.Size = new System.Drawing.Size(65, 30);
            this.MPlus.TabIndex = 5;
            this.MPlus.Text = "M+";
            this.MPlus.UseVisualStyleBackColor = true;
            this.MPlus.Click += new System.EventHandler(this.MPlus_Click);
            // 
            // Backspace
            // 
            this.Backspace.Location = new System.Drawing.Point(12, 202);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(65, 60);
            this.Backspace.TabIndex = 7;
            this.Backspace.Text = "←";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(83, 202);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(65, 60);
            this.CE.TabIndex = 8;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(154, 202);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(65, 60);
            this.C.TabIndex = 9;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // ChangeSign
            // 
            this.ChangeSign.Location = new System.Drawing.Point(225, 202);
            this.ChangeSign.Name = "ChangeSign";
            this.ChangeSign.Size = new System.Drawing.Size(65, 60);
            this.ChangeSign.TabIndex = 10;
            this.ChangeSign.Text = "±";
            this.ChangeSign.UseVisualStyleBackColor = true;
            this.ChangeSign.Click += new System.EventHandler(this.ChangeSign_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(12, 268);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(65, 60);
            this.Seven.TabIndex = 12;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Btn_Click);
            this.Seven.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(83, 268);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(65, 60);
            this.Eight.TabIndex = 13;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(154, 268);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(65, 60);
            this.Nine.TabIndex = 14;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(225, 268);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(65, 60);
            this.Divide.TabIndex = 15;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(12, 334);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(65, 60);
            this.Four.TabIndex = 17;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(83, 334);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(65, 60);
            this.Five.TabIndex = 18;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(154, 334);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(65, 60);
            this.Six.TabIndex = 19;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(225, 334);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(65, 60);
            this.Multiply.TabIndex = 20;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(12, 464);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(136, 60);
            this.Zero.TabIndex = 21;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(154, 400);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(65, 60);
            this.Three.TabIndex = 24;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Btn_Click);
            // 
            // MMinus
            // 
            this.MMinus.Location = new System.Drawing.Point(296, 166);
            this.MMinus.Name = "MMinus";
            this.MMinus.Size = new System.Drawing.Size(65, 30);
            this.MMinus.TabIndex = 25;
            this.MMinus.Text = "M-";
            this.MMinus.UseVisualStyleBackColor = true;
            this.MMinus.Click += new System.EventHandler(this.MMinus_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(296, 202);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(65, 60);
            this.Sqrt.TabIndex = 26;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(296, 268);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(65, 60);
            this.Percent.TabIndex = 27;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = true;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(225, 400);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(65, 60);
            this.Minus.TabIndex = 28;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // DivideByX
            // 
            this.DivideByX.Location = new System.Drawing.Point(296, 334);
            this.DivideByX.Name = "DivideByX";
            this.DivideByX.Size = new System.Drawing.Size(65, 60);
            this.DivideByX.TabIndex = 29;
            this.DivideByX.Text = "1/x";
            this.DivideByX.UseVisualStyleBackColor = true;
            this.DivideByX.Click += new System.EventHandler(this.DivideByX_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(12, 400);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(65, 60);
            this.One.TabIndex = 30;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(83, 400);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(65, 60);
            this.Two.TabIndex = 31;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(296, 400);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(65, 124);
            this.Calculate.TabIndex = 32;
            this.Calculate.Text = "=";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(225, 464);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(65, 60);
            this.Plus.TabIndex = 33;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Point
            // 
            this.Point.Location = new System.Drawing.Point(154, 464);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(65, 60);
            this.Point.TabIndex = 34;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 79);
            this.label1.TabIndex = 35;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.DivideByX);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.MMinus);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.ChangeSign);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.MPlus);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JustCanvas);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox JustCanvas;
        private Label label2;
        private Button MC;
        private Button MR;
        private Button MS;
        private Button MPlus;
        private Button Backspace;
        private Button CE;
        private Button C;
        private Button ChangeSign;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Divide;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Multiply;
        private Button Zero;
        private Button Three;
        private Button MMinus;
        private Button Sqrt;
        private Button Percent;
        private Button Minus;
        private Button DivideByX;
        private Button One;
        private Button Two;
        private Button Calculate;
        private Button Plus;
        private Button Point;
        private Label label1;
    }
}