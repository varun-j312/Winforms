namespace CalculatorApp
{
    partial class Calc
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
            this.display = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(12, 33);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(338, 91);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(12, 139);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(80, 55);
            this.percent.TabIndex = 1;
            this.percent.TabStop = false;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.UnaryOp_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.clearEntry.Location = new System.Drawing.Point(98, 139);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(80, 55);
            this.clearEntry.TabIndex = 2;
            this.clearEntry.TabStop = false;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(183, 139);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 55);
            this.clear.TabIndex = 3;
            this.clear.TabStop = false;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(269, 139);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(80, 55);
            this.backspace.TabIndex = 4;
            this.backspace.TabStop = false;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 383);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(80, 55);
            this.one.TabIndex = 5;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Digit_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(98, 383);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(80, 55);
            this.two.TabIndex = 6;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Digit_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.reciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.reciprocal.Location = new System.Drawing.Point(12, 200);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(80, 55);
            this.reciprocal.TabIndex = 7;
            this.reciprocal.TabStop = false;
            this.reciprocal.Text = "¹/x";
            this.reciprocal.UseVisualStyleBackColor = false;
            this.reciprocal.Click += new System.EventHandler(this.UnaryOp_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.square.Location = new System.Drawing.Point(98, 200);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(80, 55);
            this.square.TabIndex = 8;
            this.square.TabStop = false;
            this.square.Text = "x²";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.UnaryOp_Click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.root.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.root.Location = new System.Drawing.Point(183, 200);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(80, 55);
            this.root.TabIndex = 9;
            this.root.TabStop = false;
            this.root.Text = "√x";
            this.root.UseVisualStyleBackColor = false;
            this.root.Click += new System.EventHandler(this.UnaryOp_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(269, 200);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(80, 55);
            this.div.TabIndex = 10;
            this.div.TabStop = false;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.BinaryOp_Click);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.sign.Location = new System.Drawing.Point(12, 444);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(80, 55);
            this.sign.TabIndex = 11;
            this.sign.TabStop = false;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.UnaryOp_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(183, 383);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(80, 55);
            this.three.TabIndex = 12;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Digit_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 261);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(80, 55);
            this.seven.TabIndex = 13;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Digit_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(98, 261);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(80, 55);
            this.eight.TabIndex = 14;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Digit_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(183, 261);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(80, 55);
            this.nine.TabIndex = 15;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Digit_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(269, 261);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(80, 55);
            this.mul.TabIndex = 16;
            this.mul.TabStop = false;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.BinaryOp_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(98, 444);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(80, 55);
            this.zero.TabIndex = 17;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Digit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(269, 383);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(80, 55);
            this.add.TabIndex = 18;
            this.add.TabStop = false;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.BinaryOp_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 322);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(80, 55);
            this.four.TabIndex = 19;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Digit_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(98, 322);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(80, 55);
            this.five.TabIndex = 20;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Digit_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(183, 322);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(80, 55);
            this.six.TabIndex = 21;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Digit_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(269, 322);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(80, 55);
            this.sub.TabIndex = 22;
            this.sub.TabStop = false;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.BinaryOp_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(183, 444);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(80, 55);
            this.dot.TabIndex = 23;
            this.dot.TabStop = false;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.Digit_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.equal.Location = new System.Drawing.Point(269, 444);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(80, 55);
            this.equal.TabIndex = 24;
            this.equal.TabStop = false;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.Equals_Click);
            // 
            // equation
            // 
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.equation.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.equation.Location = new System.Drawing.Point(12, 9);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(336, 24);
            this.equation.TabIndex = 25;
            this.equation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 509);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.add);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.three);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.div);
            this.Controls.Add(this.root);
            this.Controls.Add(this.square);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.display);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 556);
            this.MinimumSize = new System.Drawing.Size(378, 556);
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calc_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Label equation;
    }
}

