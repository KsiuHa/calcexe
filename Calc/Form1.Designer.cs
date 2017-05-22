namespace Calc
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
            this.ExpressionLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Editing = new System.Windows.Forms.GroupBox();
            this.C = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.CloseBracket = new System.Windows.Forms.Button();
            this.OpenBracket = new System.Windows.Forms.Button();
            this.Expression = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.ChangeSign = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MPlus = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Editing.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExpressionLabel
            // 
            this.ExpressionLabel.AutoSize = true;
            this.ExpressionLabel.Location = new System.Drawing.Point(12, 15);
            this.ExpressionLabel.Name = "ExpressionLabel";
            this.ExpressionLabel.Size = new System.Drawing.Size(58, 13);
            this.ExpressionLabel.TabIndex = 0;
            this.ExpressionLabel.Text = "Expression";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 42);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "Result";
            // 
            // Editing
            // 
            this.Editing.Controls.Add(this.C);
            this.Editing.Controls.Add(this.Backspace);
            this.Editing.Controls.Add(this.CloseBracket);
            this.Editing.Controls.Add(this.OpenBracket);
            this.Editing.Location = new System.Drawing.Point(15, 65);
            this.Editing.Name = "Editing";
            this.Editing.Size = new System.Drawing.Size(249, 62);
            this.Editing.TabIndex = 4;
            this.Editing.TabStop = false;
            this.Editing.Text = "Editing";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(208, 19);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(35, 30);
            this.C.TabIndex = 8;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Backspace
            // 
            this.Backspace.Location = new System.Drawing.Point(122, 19);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(80, 30);
            this.Backspace.TabIndex = 7;
            this.Backspace.Text = "Backspace";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // CloseBracket
            // 
            this.CloseBracket.Location = new System.Drawing.Point(46, 19);
            this.CloseBracket.Name = "CloseBracket";
            this.CloseBracket.Size = new System.Drawing.Size(35, 30);
            this.CloseBracket.TabIndex = 6;
            this.CloseBracket.Tag = ")";
            this.CloseBracket.Text = ")";
            this.CloseBracket.UseVisualStyleBackColor = true;
            this.CloseBracket.Click += new System.EventHandler(this.CloseBracket_Click);
            // 
            // OpenBracket
            // 
            this.OpenBracket.Location = new System.Drawing.Point(6, 19);
            this.OpenBracket.Name = "OpenBracket";
            this.OpenBracket.Size = new System.Drawing.Size(35, 30);
            this.OpenBracket.TabIndex = 5;
            this.OpenBracket.Tag = "(";
            this.OpenBracket.Text = "(";
            this.OpenBracket.UseVisualStyleBackColor = true;
            this.OpenBracket.Click += new System.EventHandler(this.OpenBracket_Click);
            // 
            // Expression
            // 
            this.Expression.BackColor = System.Drawing.SystemColors.Window;
            this.Expression.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Expression.Location = new System.Drawing.Point(79, 12);
            this.Expression.Name = "Expression";
            this.Expression.Size = new System.Drawing.Size(185, 20);
            this.Expression.TabIndex = 1;
            this.Expression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.Expression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Expression_KeyPress);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(79, 39);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(185, 20);
            this.Result.TabIndex = 3;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(21, 133);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(35, 30);
            this.B1.TabIndex = 9;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(62, 133);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(35, 30);
            this.B2.TabIndex = 10;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(103, 133);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(35, 30);
            this.B3.TabIndex = 11;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(21, 169);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(35, 30);
            this.B4.TabIndex = 13;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(62, 169);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(35, 30);
            this.B5.TabIndex = 14;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(103, 169);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(35, 30);
            this.B6.TabIndex = 15;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(21, 205);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(35, 30);
            this.B7.TabIndex = 17;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(61, 205);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(35, 30);
            this.B8.TabIndex = 18;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // B9
            // 
            this.B9.Location = new System.Drawing.Point(103, 205);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(35, 30);
            this.B9.TabIndex = 19;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // ChangeSign
            // 
            this.ChangeSign.Location = new System.Drawing.Point(21, 241);
            this.ChangeSign.Name = "ChangeSign";
            this.ChangeSign.Size = new System.Drawing.Size(35, 30);
            this.ChangeSign.TabIndex = 21;
            this.ChangeSign.Text = "-/+";
            this.ChangeSign.UseVisualStyleBackColor = true;
            this.ChangeSign.Click += new System.EventHandler(this.ChangeSign_Click);
            // 
            // B0
            // 
            this.B0.Location = new System.Drawing.Point(61, 241);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(35, 30);
            this.B0.TabIndex = 22;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(103, 241);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(35, 30);
            this.Mod.TabIndex = 23;
            this.Mod.Tag = "";
            this.Mod.Text = "mod";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(146, 133);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(35, 30);
            this.Division.TabIndex = 12;
            this.Division.Tag = "/";
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(146, 169);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(35, 30);
            this.Multiply.TabIndex = 16;
            this.Multiply.Tag = "*";
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(146, 241);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(35, 30);
            this.Plus.TabIndex = 24;
            this.Plus.Tag = "+";
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(223, 133);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(35, 30);
            this.MR.TabIndex = 25;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.MR_Click);
            // 
            // MPlus
            // 
            this.MPlus.Location = new System.Drawing.Point(223, 169);
            this.MPlus.Name = "MPlus";
            this.MPlus.Size = new System.Drawing.Size(35, 30);
            this.MPlus.TabIndex = 26;
            this.MPlus.Text = "M+";
            this.MPlus.UseVisualStyleBackColor = true;
            this.MPlus.Click += new System.EventHandler(this.MPlus_Click);
            // 
            // MC
            // 
            this.MC.Location = new System.Drawing.Point(223, 205);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(35, 30);
            this.MC.TabIndex = 27;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = true;
            this.MC.Click += new System.EventHandler(this.MC_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(223, 241);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(35, 30);
            this.Calculate.TabIndex = 28;
            this.Calculate.Tag = "";
            this.Calculate.Text = "=";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(146, 205);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(35, 30);
            this.Minus.TabIndex = 20;
            this.Minus.Tag = "-";
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(278, 284);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.MPlus);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.ChangeSign);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Expression);
            this.Controls.Add(this.Editing);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ExpressionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Editing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExpressionLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.GroupBox Editing;
        private System.Windows.Forms.TextBox Expression;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button CloseBracket;
        private System.Windows.Forms.Button OpenBracket;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button ChangeSign;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button MPlus;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Minus;
    }
}

