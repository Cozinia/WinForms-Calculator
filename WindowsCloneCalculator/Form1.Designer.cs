namespace WindowsCloneCalculator
{
    partial class WinCloneCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinCloneCalculator));
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.lbl_prevOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 50);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(58, 54);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_Click);
            this.btn_7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(76, 50);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(58, 54);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_Click);
            this.btn_8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(139, 50);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(58, 54);
            this.btn_9.TabIndex = 2;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_Click);
            this.btn_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(203, 50);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(58, 54);
            this.btn_divide.TabIndex = 3;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.aritmeticOperator_Click);
            this.btn_divide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_ce
            // 
            this.btn_ce.Location = new System.Drawing.Point(267, 50);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(58, 54);
            this.btn_ce.TabIndex = 0;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            this.btn_ce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(267, 110);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(58, 54);
            this.btn_c.TabIndex = 9;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(203, 110);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(58, 54);
            this.btn_multiply.TabIndex = 8;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.aritmeticOperator_Click);
            this.btn_multiply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(139, 110);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(58, 54);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Click);
            this.btn_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(76, 110);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(58, 54);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_Click);
            this.btn_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(12, 110);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(58, 54);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_Click);
            this.btn_6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(267, 170);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(58, 114);
            this.btn_equal.TabIndex = 14;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_subtract
            // 
            this.btn_subtract.Location = new System.Drawing.Point(203, 170);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(58, 54);
            this.btn_subtract.TabIndex = 13;
            this.btn_subtract.Text = "-";
            this.btn_subtract.UseVisualStyleBackColor = true;
            this.btn_subtract.Click += new System.EventHandler(this.aritmeticOperator_Click);
            this.btn_subtract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(139, 170);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(58, 54);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Click);
            this.btn_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(76, 170);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(58, 54);
            this.btn_2.TabIndex = 11;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Click);
            this.btn_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(12, 170);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(58, 54);
            this.btn_3.TabIndex = 10;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Click);
            this.btn_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(203, 230);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(58, 54);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.aritmeticOperator_Click);
            this.btn_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_point
            // 
            this.btn_point.Location = new System.Drawing.Point(139, 230);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(58, 54);
            this.btn_point.TabIndex = 17;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_Click);
            this.btn_point.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(12, 230);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(122, 54);
            this.btn_0.TabIndex = 15;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_Click);
            this.btn_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // tb_result
            // 
            this.tb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_result.Location = new System.Drawing.Point(12, 6);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(313, 38);
            this.tb_result.TabIndex = 19;
            this.tb_result.Text = "0";
            this.tb_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_prevOperation
            // 
            this.lbl_prevOperation.AutoSize = true;
            this.lbl_prevOperation.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_prevOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prevOperation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_prevOperation.Location = new System.Drawing.Point(22, 15);
            this.lbl_prevOperation.Name = "lbl_prevOperation";
            this.lbl_prevOperation.Size = new System.Drawing.Size(0, 25);
            this.lbl_prevOperation.TabIndex = 20;
            // 
            // WinCloneCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 290);
            this.Controls.Add(this.lbl_prevOperation);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_subtract);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WinCloneCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label lbl_prevOperation;
    }
}

