namespace Калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Number0 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CleanOneNum = new System.Windows.Forms.Button();
            this.CleanSecondMeanings = new System.Windows.Forms.Button();
            this.CleanAll = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.Blabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number0
            // 
            this.Number0.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number0.Location = new System.Drawing.Point(11, 380);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(109, 46);
            this.Number0.TabIndex = 0;
            this.Number0.Text = "0";
            this.Number0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.Num);
            // 
            // Number2
            // 
            this.Number2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number2.Location = new System.Drawing.Point(68, 328);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(52, 46);
            this.Number2.TabIndex = 1;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.Num);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(185, 380);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(53, 46);
            this.Plus.TabIndex = 1;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.operetions);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(244, 328);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(52, 98);
            this.Result.TabIndex = 1;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dot.Location = new System.Drawing.Point(126, 380);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(53, 46);
            this.Dot.TabIndex = 1;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            // 
            // Number1
            // 
            this.Number1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Number1.Location = new System.Drawing.Point(11, 328);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(51, 46);
            this.Number1.TabIndex = 1;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Num);
            // 
            // Number3
            // 
            this.Number3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number3.Location = new System.Drawing.Point(126, 328);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(52, 46);
            this.Number3.TabIndex = 1;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.Num);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(186, 328);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(52, 46);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.operetions);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiply.Location = new System.Drawing.Point(185, 276);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(52, 46);
            this.Multiply.TabIndex = 1;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.operetions);
            // 
            // Number6
            // 
            this.Number6.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number6.Location = new System.Drawing.Point(126, 276);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(52, 46);
            this.Number6.TabIndex = 1;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.Num);
            // 
            // Number4
            // 
            this.Number4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number4.Location = new System.Drawing.Point(11, 276);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(52, 46);
            this.Number4.TabIndex = 1;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.Num);
            // 
            // Number5
            // 
            this.Number5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number5.Location = new System.Drawing.Point(68, 276);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(52, 46);
            this.Number5.TabIndex = 1;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.Num);
            // 
            // Number7
            // 
            this.Number7.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number7.Location = new System.Drawing.Point(12, 224);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(52, 46);
            this.Number7.TabIndex = 1;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.Num);
            // 
            // Number8
            // 
            this.Number8.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number8.Location = new System.Drawing.Point(70, 224);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(52, 46);
            this.Number8.TabIndex = 1;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.Num);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(127, 224);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(52, 46);
            this.button14.TabIndex = 1;
            this.button14.Text = "button2";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(243, 276);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(52, 46);
            this.button15.TabIndex = 1;
            this.button15.Text = "1/x";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(242, 224);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(52, 46);
            this.button16.TabIndex = 1;
            this.button16.Text = "%";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.operetions);
            // 
            // Number9
            // 
            this.Number9.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number9.Location = new System.Drawing.Point(126, 224);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(52, 46);
            this.Number9.TabIndex = 1;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.Num);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(11, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(283, 87);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CleanOneNum
            // 
            this.CleanOneNum.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanOneNum.Location = new System.Drawing.Point(12, 172);
            this.CleanOneNum.Name = "CleanOneNum";
            this.CleanOneNum.Size = new System.Drawing.Size(52, 46);
            this.CleanOneNum.TabIndex = 1;
            this.CleanOneNum.Text = "←";
            this.CleanOneNum.UseVisualStyleBackColor = true;
            // 
            // CleanSecondMeanings
            // 
            this.CleanSecondMeanings.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanSecondMeanings.Location = new System.Drawing.Point(68, 172);
            this.CleanSecondMeanings.Name = "CleanSecondMeanings";
            this.CleanSecondMeanings.Size = new System.Drawing.Size(52, 46);
            this.CleanSecondMeanings.TabIndex = 1;
            this.CleanSecondMeanings.Text = "CE";
            this.CleanSecondMeanings.UseVisualStyleBackColor = true;
            this.CleanSecondMeanings.Click += new System.EventHandler(this.Clea);
            // 
            // CleanAll
            // 
            this.CleanAll.AllowDrop = true;
            this.CleanAll.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanAll.Location = new System.Drawing.Point(126, 172);
            this.CleanAll.Name = "CleanAll";
            this.CleanAll.Size = new System.Drawing.Size(52, 46);
            this.CleanAll.TabIndex = 1;
            this.CleanAll.Text = "C";
            this.CleanAll.UseVisualStyleBackColor = true;
            this.CleanAll.Click += new System.EventHandler(this.CleanAll_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(184, 172);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(52, 46);
            this.button21.TabIndex = 1;
            this.button21.Text = "±";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.operetions);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(242, 172);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(52, 46);
            this.button22.TabIndex = 1;
            this.button22.Text = " √";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.operetions);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.Location = new System.Drawing.Point(12, 120);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(52, 46);
            this.button23.TabIndex = 1;
            this.button23.Text = "MC";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(70, 120);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(52, 46);
            this.button24.TabIndex = 1;
            this.button24.Text = "MR";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button25.Location = new System.Drawing.Point(126, 120);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(52, 46);
            this.button25.TabIndex = 1;
            this.button25.Text = "MS";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.Location = new System.Drawing.Point(184, 120);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(52, 46);
            this.button26.TabIndex = 1;
            this.button26.Text = "M+";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button27.Location = new System.Drawing.Point(242, 120);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(52, 46);
            this.button27.TabIndex = 1;
            this.button27.Text = "M-";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(185, 224);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(52, 46);
            this.division.TabIndex = 1;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operetions);
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Blabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Blabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Blabel.Location = new System.Drawing.Point(12, 30);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(0, 37);
            this.Blabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 432);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.division);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.CleanAll);
            this.Controls.Add(this.CleanSecondMeanings);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.CleanOneNum);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button CleanOneNum;
        private System.Windows.Forms.Button CleanSecondMeanings;
        private System.Windows.Forms.Button CleanAll;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Blabel;
    }
}

