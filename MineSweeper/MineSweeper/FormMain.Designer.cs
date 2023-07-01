namespace MineSwepper
{
    partial class FormMainMine
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMine));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.新游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSilence = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInterestGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRandomNum = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLuckTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDifficulty = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHard = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFaceTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFuFuTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDinosaur = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGameArea = new System.Windows.Forms.Panel();
            this.labelRemainMine = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelColon = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGame,
            this.MenuItemInterestGame,
            this.MenuItemColor,
            this.MenuItemDifficulty,
            this.MenuItemTheme});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemGame
            // 
            this.MenuItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新游戏ToolStripMenuItem,
            this.MenuItemSilence});
            this.MenuItemGame.Image = global::MineSwepper.Properties.Resources.Mine21;
            this.MenuItemGame.Name = "MenuItemGame";
            this.MenuItemGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.MenuItemGame.Size = new System.Drawing.Size(60, 21);
            this.MenuItemGame.Text = "游戏";
            // 
            // 新游戏ToolStripMenuItem
            // 
            this.新游戏ToolStripMenuItem.Image = global::MineSwepper.Properties.Resources.Mine2;
            this.新游戏ToolStripMenuItem.Name = "新游戏ToolStripMenuItem";
            this.新游戏ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.新游戏ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.新游戏ToolStripMenuItem.Text = "新游戏";
            this.新游戏ToolStripMenuItem.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // MenuItemSilence
            // 
            this.MenuItemSilence.Image = global::MineSwepper.Properties.Resources.声音;
            this.MenuItemSilence.Name = "MenuItemSilence";
            this.MenuItemSilence.Size = new System.Drawing.Size(156, 22);
            this.MenuItemSilence.Text = "静音";
            this.MenuItemSilence.Click += new System.EventHandler(this.MenuItemSilence_Click);
            // 
            // MenuItemInterestGame
            // 
            this.MenuItemInterestGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRandomNum,
            this.MenuItemLuckTest});
            this.MenuItemInterestGame.Image = global::MineSwepper.Properties.Resources.开心1;
            this.MenuItemInterestGame.Name = "MenuItemInterestGame";
            this.MenuItemInterestGame.Size = new System.Drawing.Size(96, 21);
            this.MenuItemInterestGame.Text = "趣味小游戏";
            this.MenuItemInterestGame.ToolTipText = "设置";
            // 
            // MenuItemRandomNum
            // 
            this.MenuItemRandomNum.Image = global::MineSwepper.Properties.Resources.fufu_quick2;
            this.MenuItemRandomNum.Name = "MenuItemRandomNum";
            this.MenuItemRandomNum.Size = new System.Drawing.Size(152, 22);
            this.MenuItemRandomNum.Text = "随机数字";
            this.MenuItemRandomNum.Click += new System.EventHandler(this.MenuItemRandomNum_Click);
            // 
            // MenuItemLuckTest
            // 
            this.MenuItemLuckTest.Image = global::MineSwepper.Properties.Resources.关于我们_笑脸;
            this.MenuItemLuckTest.Name = "MenuItemLuckTest";
            this.MenuItemLuckTest.Size = new System.Drawing.Size(152, 22);
            this.MenuItemLuckTest.Text = "运气测试！！";
            this.MenuItemLuckTest.Click += new System.EventHandler(this.MenuItemLuckTest_Click_1);
            // 
            // MenuItemColor
            // 
            this.MenuItemColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChangeColor,
            this.MenuItemDefault});
            this.MenuItemColor.Image = global::MineSwepper.Properties.Resources.color;
            this.MenuItemColor.Name = "MenuItemColor";
            this.MenuItemColor.Size = new System.Drawing.Size(60, 21);
            this.MenuItemColor.Text = "颜色";
            // 
            // MenuItemChangeColor
            // 
            this.MenuItemChangeColor.Image = global::MineSwepper.Properties.Resources.color;
            this.MenuItemChangeColor.Name = "MenuItemChangeColor";
            this.MenuItemChangeColor.Size = new System.Drawing.Size(152, 22);
            this.MenuItemChangeColor.Text = "换颜色！";
            this.MenuItemChangeColor.Click += new System.EventHandler(this.MenuItemChangeColor_Click);
            // 
            // MenuItemDefault
            // 
            this.MenuItemDefault.Image = global::MineSwepper.Properties.Resources.收藏;
            this.MenuItemDefault.Name = "MenuItemDefault";
            this.MenuItemDefault.Size = new System.Drawing.Size(152, 22);
            this.MenuItemDefault.Text = "恢复默认颜色";
            this.MenuItemDefault.Click += new System.EventHandler(this.MenuItemDefault_Click);
            // 
            // MenuItemDifficulty
            // 
            this.MenuItemDifficulty.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEasy,
            this.MenuItemMedium,
            this.MenuItemHard});
            this.MenuItemDifficulty.Image = global::MineSwepper.Properties.Resources.鬼脸;
            this.MenuItemDifficulty.Name = "MenuItemDifficulty";
            this.MenuItemDifficulty.Size = new System.Drawing.Size(60, 21);
            this.MenuItemDifficulty.Text = "难度";
            // 
            // MenuItemEasy
            // 
            this.MenuItemEasy.Name = "MenuItemEasy";
            this.MenuItemEasy.Size = new System.Drawing.Size(152, 22);
            this.MenuItemEasy.Text = "初级(9x9)";
            this.MenuItemEasy.Click += new System.EventHandler(this.MenuItemEasy_Click);
            // 
            // MenuItemMedium
            // 
            this.MenuItemMedium.Name = "MenuItemMedium";
            this.MenuItemMedium.Size = new System.Drawing.Size(152, 22);
            this.MenuItemMedium.Text = "中级(12x12)";
            this.MenuItemMedium.Click += new System.EventHandler(this.MenuItemMedium_Click);
            // 
            // MenuItemHard
            // 
            this.MenuItemHard.Name = "MenuItemHard";
            this.MenuItemHard.Size = new System.Drawing.Size(152, 22);
            this.MenuItemHard.Text = "高级(15x15)";
            this.MenuItemHard.Click += new System.EventHandler(this.MenuItemHard_Click);
            // 
            // MenuItemTheme
            // 
            this.MenuItemTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFaceTheme,
            this.MenuItemFuFuTheme,
            this.MenuItemDinosaur});
            this.MenuItemTheme.Image = global::MineSwepper.Properties.Resources.face2;
            this.MenuItemTheme.Name = "MenuItemTheme";
            this.MenuItemTheme.Size = new System.Drawing.Size(60, 21);
            this.MenuItemTheme.Text = "主题";
            // 
            // MenuItemFaceTheme
            // 
            this.MenuItemFaceTheme.Image = global::MineSwepper.Properties.Resources.Laugh4;
            this.MenuItemFaceTheme.Name = "MenuItemFaceTheme";
            this.MenuItemFaceTheme.Size = new System.Drawing.Size(112, 22);
            this.MenuItemFaceTheme.Text = "face";
            this.MenuItemFaceTheme.Click += new System.EventHandler(this.MenuItemFaceTheme_Click);
            // 
            // MenuItemFuFuTheme
            // 
            this.MenuItemFuFuTheme.Image = global::MineSwepper.Properties.Resources.fufu_love2;
            this.MenuItemFuFuTheme.Name = "MenuItemFuFuTheme";
            this.MenuItemFuFuTheme.Size = new System.Drawing.Size(112, 22);
            this.MenuItemFuFuTheme.Text = "fufu";
            this.MenuItemFuFuTheme.Click += new System.EventHandler(this.MenuItemFuFuTheme_Click);
            // 
            // MenuItemDinosaur
            // 
            this.MenuItemDinosaur.Image = global::MineSwepper.Properties.Resources.恐龙微笑2;
            this.MenuItemDinosaur.Name = "MenuItemDinosaur";
            this.MenuItemDinosaur.Size = new System.Drawing.Size(112, 22);
            this.MenuItemDinosaur.Text = "恐龙！";
            this.MenuItemDinosaur.Click += new System.EventHandler(this.MenuItemDinosaur_Click);
            // 
            // panelGameArea
            // 
            this.panelGameArea.BackColor = System.Drawing.Color.Transparent;
            this.panelGameArea.Font = new System.Drawing.Font("宋体", 10F);
            this.panelGameArea.Location = new System.Drawing.Point(1, 76);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(360, 360);
            this.panelGameArea.TabIndex = 1;
            this.panelGameArea.Tag = "游戏区域";
            this.panelGameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGameArea_Paint);
            // 
            // labelRemainMine
            // 
            this.labelRemainMine.AutoSize = true;
            this.labelRemainMine.Font = new System.Drawing.Font("宋体", 30F);
            this.labelRemainMine.Location = new System.Drawing.Point(52, 28);
            this.labelRemainMine.Name = "labelRemainMine";
            this.labelRemainMine.Size = new System.Drawing.Size(37, 40);
            this.labelRemainMine.TabIndex = 2;
            this.labelRemainMine.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("宋体", 25F);
            this.labelMinute.Location = new System.Drawing.Point(236, 31);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(49, 34);
            this.labelMinute.TabIndex = 3;
            this.labelMinute.Text = "00";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("宋体", 25F);
            this.labelSecond.Location = new System.Drawing.Point(301, 31);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(49, 34);
            this.labelSecond.TabIndex = 3;
            this.labelSecond.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 25F);
            this.label3.Location = new System.Drawing.Point(301, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // labelColon
            // 
            this.labelColon.AutoSize = true;
            this.labelColon.BackColor = System.Drawing.Color.Transparent;
            this.labelColon.Font = new System.Drawing.Font("宋体", 25F);
            this.labelColon.Location = new System.Drawing.Point(277, 31);
            this.labelColon.Name = "labelColon";
            this.labelColon.Size = new System.Drawing.Size(32, 34);
            this.labelColon.TabIndex = 3;
            this.labelColon.Text = ":";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BackgroundImage = global::MineSwepper.Properties.Resources.Laugh4;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("宋体", 30F);
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(155, 31);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(44, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormMainMine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(362, 433);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelColon);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelRemainMine);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelGameArea);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMainMine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我爱扫雷！";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGame;
        private System.Windows.Forms.ToolStripMenuItem 新游戏ToolStripMenuItem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelRemainMine;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInterestGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelColon;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemColor;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDifficulty;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEasy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMedium;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHard;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTheme;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDefault;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangeColor;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFuFuTheme;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFaceTheme;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDinosaur;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRandomNum;
        public System.Windows.Forms.Panel panelGameArea;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSilence;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLuckTest;
    }
}

