namespace HaruCommandEditor.Tool
{
    partial class SelectorGenerator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Style = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LevelStyle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LevelLabel2 = new System.Windows.Forms.Label();
            this.LevelValue2 = new System.Windows.Forms.NumericUpDown();
            this.LevelValue1 = new System.Windows.Forms.NumericUpDown();
            this.LevelLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelValue1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Style);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本設定";
            // 
            // Style
            // 
            this.Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Style.FormattingEnabled = true;
            this.Style.Items.AddRange(new object[] {
            "@a",
            "@p",
            "@r",
            "@e",
            "@s"});
            this.Style.Location = new System.Drawing.Point(68, 18);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(145, 20);
            this.Style.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "形式";
            // 
            // Sort
            // 
            this.Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sort.FormattingEnabled = true;
            this.Sort.Items.AddRange(new object[] {
            "(未使用)",
            "近い順",
            "遠い順",
            "ランダム",
            "非指定"});
            this.Sort.Location = new System.Drawing.Point(68, 44);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(145, 20);
            this.Sort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ソート方法";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LevelValue1);
            this.groupBox2.Controls.Add(this.LevelLabel1);
            this.groupBox2.Controls.Add(this.LevelValue2);
            this.groupBox2.Controls.Add(this.LevelLabel2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LevelStyle);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "経験値レベル";
            // 
            // LevelStyle
            // 
            this.LevelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelStyle.FormattingEnabled = true;
            this.LevelStyle.Items.AddRange(new object[] {
            "使用しない",
            "特定の値のみ",
            "上限値のみ",
            "下限値のみ",
            "範囲指定"});
            this.LevelStyle.Location = new System.Drawing.Point(68, 18);
            this.LevelStyle.Name = "LevelStyle";
            this.LevelStyle.Size = new System.Drawing.Size(145, 20);
            this.LevelStyle.TabIndex = 0;
            this.LevelStyle.SelectedIndexChanged += new System.EventHandler(this.LevelStyle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "形式";
            // 
            // LevelLabel2
            // 
            this.LevelLabel2.AutoSize = true;
            this.LevelLabel2.Location = new System.Drawing.Point(21, 71);
            this.LevelLabel2.Name = "LevelLabel2";
            this.LevelLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LevelLabel2.Size = new System.Drawing.Size(41, 12);
            this.LevelLabel2.TabIndex = 2;
            this.LevelLabel2.Text = "最大値";
            // 
            // LevelValue2
            // 
            this.LevelValue2.Location = new System.Drawing.Point(68, 69);
            this.LevelValue2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.LevelValue2.Name = "LevelValue2";
            this.LevelValue2.Size = new System.Drawing.Size(145, 19);
            this.LevelValue2.TabIndex = 3;
            // 
            // LevelValue1
            // 
            this.LevelValue1.Location = new System.Drawing.Point(68, 44);
            this.LevelValue1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.LevelValue1.Name = "LevelValue1";
            this.LevelValue1.Size = new System.Drawing.Size(145, 19);
            this.LevelValue1.TabIndex = 5;
            // 
            // LevelLabel1
            // 
            this.LevelLabel1.AutoSize = true;
            this.LevelLabel1.Location = new System.Drawing.Point(21, 46);
            this.LevelLabel1.Name = "LevelLabel1";
            this.LevelLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LevelLabel1.Size = new System.Drawing.Size(41, 12);
            this.LevelLabel1.TabIndex = 4;
            this.LevelLabel1.Text = "最大値";
            // 
            // SelectorGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectorGenerator";
            this.Text = "セレクター生成フォーム";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelValue1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Style;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LevelStyle;
        private System.Windows.Forms.NumericUpDown LevelValue2;
        private System.Windows.Forms.Label LevelLabel2;
        private System.Windows.Forms.NumericUpDown LevelValue1;
        private System.Windows.Forms.Label LevelLabel1;
    }
}