namespace HaruCommandEditor.Main
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プラグインToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.タブを追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.giveを追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summonを追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBlockを追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "コピー";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 705);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "コマンド管理";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 652);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(905, 19);
            this.textBox1.TabIndex = 2;
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // プラグインToolStripMenuItem
            // 
            this.プラグインToolStripMenuItem.Name = "プラグインToolStripMenuItem";
            this.プラグインToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.プラグインToolStripMenuItem.Text = "プラグイン(&P)";
            // 
            // ツールToolStripMenuItem
            // 
            this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
            this.ツールToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ツールToolStripMenuItem.Text = "ツール(&T)";
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集ToolStripMenuItem.Text = "編集(&E)";
            // 
            // タブを追加ToolStripMenuItem
            // 
            this.タブを追加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveを追加ToolStripMenuItem,
            this.summonを追加ToolStripMenuItem,
            this.setBlockを追加ToolStripMenuItem});
            this.タブを追加ToolStripMenuItem.Name = "タブを追加ToolStripMenuItem";
            this.タブを追加ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.タブを追加ToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.タブを追加ToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.ツールToolStripMenuItem,
            this.プラグインToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(994, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(270, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(724, 613);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 31);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(258, 615);
            this.treeView1.TabIndex = 1;
            // 
            // giveを追加ToolStripMenuItem
            // 
            this.giveを追加ToolStripMenuItem.Name = "giveを追加ToolStripMenuItem";
            this.giveを追加ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.giveを追加ToolStripMenuItem.Text = "Giveを追加";
            // 
            // summonを追加ToolStripMenuItem
            // 
            this.summonを追加ToolStripMenuItem.Name = "summonを追加ToolStripMenuItem";
            this.summonを追加ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.summonを追加ToolStripMenuItem.Text = "Summonを追加";
            // 
            // setBlockを追加ToolStripMenuItem
            // 
            this.setBlockを追加ToolStripMenuItem.Name = "setBlockを追加ToolStripMenuItem";
            this.setBlockを追加ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setBlockを追加ToolStripMenuItem.Text = "SetBlockを追加";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ハルの総合コマンドエディタ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プラグインToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem タブを追加ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripMenuItem giveを追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summonを追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBlockを追加ToolStripMenuItem;
    }
}