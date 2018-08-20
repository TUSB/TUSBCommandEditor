namespace TUSBCommandEditor.Summon
{
    partial class SummonControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.PassengerAdd = new System.Windows.Forms.Button();
            this.PassengerRemove = new System.Windows.Forms.Button();
            this.PassengerResetting = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.EntityID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.EntityName = new System.Windows.Forms.TextBox();
            this.EntityNameGenerate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PassengerResetting);
            this.groupBox1.Controls.Add(this.PassengerRemove);
            this.groupBox1.Controls.Add(this.PassengerAdd);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summonリスト";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 18);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(245, 237);
            this.treeView1.TabIndex = 0;
            // 
            // PassengerAdd
            // 
            this.PassengerAdd.Location = new System.Drawing.Point(257, 159);
            this.PassengerAdd.Name = "PassengerAdd";
            this.PassengerAdd.Size = new System.Drawing.Size(50, 28);
            this.PassengerAdd.TabIndex = 1;
            this.PassengerAdd.Text = "追加";
            this.PassengerAdd.UseVisualStyleBackColor = true;
            // 
            // PassengerRemove
            // 
            this.PassengerRemove.Location = new System.Drawing.Point(257, 227);
            this.PassengerRemove.Name = "PassengerRemove";
            this.PassengerRemove.Size = new System.Drawing.Size(50, 28);
            this.PassengerRemove.TabIndex = 2;
            this.PassengerRemove.Text = "削除";
            this.PassengerRemove.UseVisualStyleBackColor = true;
            // 
            // PassengerResetting
            // 
            this.PassengerResetting.Location = new System.Drawing.Point(257, 193);
            this.PassengerResetting.Name = "PassengerResetting";
            this.PassengerResetting.Size = new System.Drawing.Size(50, 28);
            this.PassengerResetting.TabIndex = 3;
            this.PassengerResetting.Text = "再設定";
            this.PassengerResetting.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EntityNameGenerate);
            this.groupBox2.Controls.Add(this.EntityName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EntityID);
            this.groupBox2.Location = new System.Drawing.Point(3, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本設定";
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(922, 653);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 23);
            this.Copy.TabIndex = 2;
            this.Copy.Text = "コピー";
            this.Copy.UseVisualStyleBackColor = true;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(841, 653);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 3;
            this.Generate.Text = "生成";
            this.Generate.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(3, 655);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(832, 19);
            this.Output.TabIndex = 4;
            // 
            // EntityID
            // 
            this.EntityID.FormattingEnabled = true;
            this.EntityID.Location = new System.Drawing.Point(6, 18);
            this.EntityID.Name = "EntityID";
            this.EntityID.Size = new System.Drawing.Size(301, 20);
            this.EntityID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(47, 97);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "名前";
            // 
            // EntityName
            // 
            this.EntityName.Location = new System.Drawing.Point(41, 46);
            this.EntityName.Name = "EntityName";
            this.EntityName.Size = new System.Drawing.Size(210, 19);
            this.EntityName.TabIndex = 4;
            // 
            // EntityNameGenerate
            // 
            this.EntityNameGenerate.Location = new System.Drawing.Point(257, 44);
            this.EntityNameGenerate.Name = "EntityNameGenerate";
            this.EntityNameGenerate.Size = new System.Drawing.Size(50, 23);
            this.EntityNameGenerate.TabIndex = 5;
            this.EntityNameGenerate.Text = "生成";
            this.EntityNameGenerate.UseVisualStyleBackColor = true;
            this.EntityNameGenerate.Click += new System.EventHandler(this.EntityNameGenerate_Click);
            // 
            // SummonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SummonControl";
            this.Size = new System.Drawing.Size(1000, 679);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PassengerResetting;
        private System.Windows.Forms.Button PassengerRemove;
        private System.Windows.Forms.Button PassengerAdd;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button EntityNameGenerate;
        private System.Windows.Forms.TextBox EntityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EntityID;
    }
}
