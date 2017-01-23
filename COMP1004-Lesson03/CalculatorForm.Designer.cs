namespace COMP1004_Lesson03
{
    partial class CalculatorForm
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
            this.CalculatorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.SubtractBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.EqualsBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DecimalBtn = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.CalculatorTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorTableLayout
            // 
            this.CalculatorTableLayout.ColumnCount = 4;
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.Controls.Add(this.ClearBtn, 1, 0);
            this.CalculatorTableLayout.Controls.Add(this.NineBtn, 2, 3);
            this.CalculatorTableLayout.Controls.Add(this.EightBtn, 1, 3);
            this.CalculatorTableLayout.Controls.Add(this.SevenBtn, 0, 3);
            this.CalculatorTableLayout.Controls.Add(this.FourBtn, 0, 2);
            this.CalculatorTableLayout.Controls.Add(this.FiveBtn, 1, 2);
            this.CalculatorTableLayout.Controls.Add(this.SixBtn, 2, 2);
            this.CalculatorTableLayout.Controls.Add(this.ThreeBtn, 2, 1);
            this.CalculatorTableLayout.Controls.Add(this.TwoBtn, 1, 1);
            this.CalculatorTableLayout.Controls.Add(this.OneBtn, 0, 1);
            this.CalculatorTableLayout.Controls.Add(this.DivideBtn, 3, 0);
            this.CalculatorTableLayout.Controls.Add(this.MultiplyBtn, 3, 1);
            this.CalculatorTableLayout.Controls.Add(this.SubtractBtn, 3, 2);
            this.CalculatorTableLayout.Controls.Add(this.AddBtn, 3, 3);
            this.CalculatorTableLayout.Controls.Add(this.ZeroBtn, 1, 4);
            this.CalculatorTableLayout.Controls.Add(this.EqualsBtn, 3, 4);
            this.CalculatorTableLayout.Controls.Add(this.BackBtn, 2, 0);
            this.CalculatorTableLayout.Controls.Add(this.DecimalBtn, 2, 4);
            this.CalculatorTableLayout.Location = new System.Drawing.Point(9, 153);
            this.CalculatorTableLayout.Name = "CalculatorTableLayout";
            this.CalculatorTableLayout.RowCount = 5;
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.Size = new System.Drawing.Size(278, 268);
            this.CalculatorTableLayout.TabIndex = 1;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(72, 3);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(63, 47);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Tag = "Other";
            this.ClearBtn.Text = "C";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // NineBtn
            // 
            this.NineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineBtn.Location = new System.Drawing.Point(141, 162);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(63, 47);
            this.NineBtn.TabIndex = 10;
            this.NineBtn.Tag = "Operand";
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = true;
            this.NineBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EightBtn
            // 
            this.EightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightBtn.Location = new System.Drawing.Point(72, 162);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(63, 47);
            this.EightBtn.TabIndex = 9;
            this.EightBtn.Tag = "Operand";
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = true;
            this.EightBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SevenBtn
            // 
            this.SevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenBtn.Location = new System.Drawing.Point(3, 162);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(63, 47);
            this.SevenBtn.TabIndex = 8;
            this.SevenBtn.Tag = "Operand";
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = true;
            this.SevenBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FourBtn
            // 
            this.FourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourBtn.Location = new System.Drawing.Point(3, 109);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(63, 47);
            this.FourBtn.TabIndex = 4;
            this.FourBtn.Tag = "Operand";
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = true;
            this.FourBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FiveBtn
            // 
            this.FiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveBtn.Location = new System.Drawing.Point(72, 109);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(63, 47);
            this.FiveBtn.TabIndex = 5;
            this.FiveBtn.Tag = "Operand";
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = true;
            this.FiveBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SixBtn
            // 
            this.SixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixBtn.Location = new System.Drawing.Point(141, 109);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(63, 47);
            this.SixBtn.TabIndex = 6;
            this.SixBtn.Tag = "Operand";
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = true;
            this.SixBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeBtn.Location = new System.Drawing.Point(141, 56);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(63, 47);
            this.ThreeBtn.TabIndex = 2;
            this.ThreeBtn.Tag = "Operand";
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = true;
            this.ThreeBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoBtn.Location = new System.Drawing.Point(72, 56);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(63, 47);
            this.TwoBtn.TabIndex = 1;
            this.TwoBtn.Tag = "Operand";
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // OneBtn
            // 
            this.OneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneBtn.Location = new System.Drawing.Point(3, 56);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(63, 47);
            this.OneBtn.TabIndex = 0;
            this.OneBtn.Tag = "Operand";
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideBtn.Location = new System.Drawing.Point(210, 3);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(65, 47);
            this.DivideBtn.TabIndex = 18;
            this.DivideBtn.Tag = "Operator";
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyBtn.Location = new System.Drawing.Point(210, 56);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(65, 47);
            this.MultiplyBtn.TabIndex = 17;
            this.MultiplyBtn.Tag = "Operator";
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SubtractBtn
            // 
            this.SubtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractBtn.Location = new System.Drawing.Point(210, 109);
            this.SubtractBtn.Name = "SubtractBtn";
            this.SubtractBtn.Size = new System.Drawing.Size(65, 47);
            this.SubtractBtn.TabIndex = 16;
            this.SubtractBtn.Tag = "Operator";
            this.SubtractBtn.Text = "-";
            this.SubtractBtn.UseVisualStyleBackColor = true;
            this.SubtractBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(210, 162);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(65, 47);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Tag = "Operator";
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroBtn.Location = new System.Drawing.Point(72, 215);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(63, 50);
            this.ZeroBtn.TabIndex = 12;
            this.ZeroBtn.Tag = "Operand";
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EqualsBtn
            // 
            this.EqualsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsBtn.Location = new System.Drawing.Point(210, 215);
            this.EqualsBtn.Name = "EqualsBtn";
            this.EqualsBtn.Size = new System.Drawing.Size(63, 50);
            this.EqualsBtn.TabIndex = 13;
            this.EqualsBtn.Tag = "Operator";
            this.EqualsBtn.Text = "=";
            this.EqualsBtn.UseVisualStyleBackColor = true;
            this.EqualsBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(141, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(63, 47);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Tag = "Other";
            this.BackBtn.Text = "←";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // DecimalBtn
            // 
            this.DecimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalBtn.Location = new System.Drawing.Point(141, 215);
            this.DecimalBtn.Name = "DecimalBtn";
            this.DecimalBtn.Size = new System.Drawing.Size(63, 50);
            this.DecimalBtn.TabIndex = 14;
            this.DecimalBtn.Tag = "Other";
            this.DecimalBtn.Text = ".";
            this.DecimalBtn.UseVisualStyleBackColor = true;
            this.DecimalBtn.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(9, 28);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(278, 64);
            this.ResultTextBox.TabIndex = 2;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CalculatorTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CalculatorTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorTableLayout;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button EqualsBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DecimalBtn;
        private System.Windows.Forms.Button SubtractBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}

