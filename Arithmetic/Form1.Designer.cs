﻿namespace Arithmetic
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(221, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(192, 47);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(41, 33);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(192, 99);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(41, 33);
            this.buttonSubstract.TabIndex = 8;
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(132, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 33);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 33);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(192, 151);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(41, 33);
            this.buttonMultiply.TabIndex = 12;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(132, 151);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(41, 33);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(72, 151);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 33);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 151);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 33);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(192, 203);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(41, 33);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 203);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(41, 33);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(72, 203);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(101, 33);
            this.buttonEquals.TabIndex = 14;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 253);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonEquals;
    }
}

