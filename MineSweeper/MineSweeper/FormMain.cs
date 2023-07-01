using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

// 思路：
// 游戏区域内每个方块三个属性：是否揭开、是否有地雷、周围地雷的数量
// 绘制所有方块 block : Button 类
// 采用链表类型，方便难度切换、方块数量转换
// 随机生成若干地雷 RandamMine
// 绘制鼠标点击、移动、右键事件 MouseDown
// 计算显示揭开方块周围地雷数量 UpdateMineCount
// 递进揭开block附近非雷block OpenBlock
// 揭开地雷时游戏失败 GameOver
// 揭开所有非地雷方块时游戏胜利 GameSuccess

// 核心：CreatMap-RandomMine-MouseDown-GameXxxx

// 细节美化：
// 1.音乐：背景音乐（欢快的小曲），失败、胜利音效 可静音 IsSilence Media
// 2.主题：主要针对笑脸图像变化 采用枚举类型GameTheme---face、fufu、dionsaur，可爱有趣的图标谁不爱啊！
// 3.颜色：采用colorDialog，自由切换block颜色 
// 4.难度：通过对地雷数量、block数量的变换来增加游戏难度 
// 5.随机数字：新建RandomNum显示栏，输入数字范围，随机生成数字 RandomNum
// 6.运气测试：生成的四个blocks中随机生成一个雷，检验运气的时候到啦嘿嘿！LuckTest
// 7.计时功能：应用Timer，来计时

namespace MineSwepper
{
    public partial class FormMainMine : Form
    {
        #region 私有字段
        // GameArea大小坐标
        // PannelGameArea 360*360
        
        private  int Rows = 9;
        // 枚举类型
        private  int Cols = 9; // 地雷 9*9
        private int remainMine; // 剩余地雷数量
        private int curMine;
        private int _remainMine;
        private int MineSize = 40;
       
        // 颜色
        private Color DefaultMineColor = Color.FromArgb(135, 206, 235);
        private Color MineColor = Color.FromArgb(135, 206, 235);
        private int cnt = 0; // cnt 为未揭开的block数量，用于判断是否Success
        // 记录每个方块是否有雷
        //private Block[,] blocks = new Block[Rows, Cols]; // 无法引用非静态字段(构造方法)
        private List<List<Block>> blocks = null;
        // 计时器
        // 时间计数值 秒为单位
        private int _nowSecond = 0;
        // 随机数
        private int min = 0;
        private int max = 100;
        private enum GameTheme
        {
            face = 1, fufu = 2, dinosaur = 3
        }
        private GameTheme _GameTheme = GameTheme.face;

        private int FormSizeWidth = 368;
        private int FormSizeHeight = 462;
        private int panelWidth = 360;
        private int panelHeight = 360;
        
        private Size FormSize = new Size(368, 462);
        
        #endregion

        #region 加载背景音乐
        private bool IsSilence = false;
        SoundPlayer bgm1 = new SoundPlayer(".\\music\\Music1.wav");
        SoundPlayer bgm2 = new SoundPlayer(".\\music\\Music2.wav");
        SoundPlayer boom = new SoundPlayer(".\\music\\boom.wav");
        SoundPlayer Success = new SoundPlayer(".\\music\\success.wav");
        #endregion

        public FormMainMine()
        {
            InitializeComponent();
            bgm1.Play();
            InitGame();
            RandomMine();
            UpdateMineCount();
        }
        // 初始化游戏
        private void InitGame()
        {
            // 初始化游戏区域
            panelGameArea.Controls.Clear(); // 将所有控件一次性全部删除
            // 初始化笑脸
            if (_GameTheme == GameTheme.face)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.Laugh4;
            else if (_GameTheme == GameTheme.fufu)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.fufu_quick2;
            else if (_GameTheme == GameTheme.dinosaur)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.恐龙微笑2;
            MineSize = panelHeight / Rows;
            CreateMap(); 
            // 初始化剩余地雷数量
            remainMine = 8;
            curMine = 8;
          
            _remainMine = remainMine;
            // 开始计时
            StartTimer();
            cnt = 0;
            labelRemainMine.Text = remainMine.ToString();
            
        }
        private void CreateMap()
        {

            if (blocks == null) blocks = new List<List<Block>>();
            else blocks.Clear();
            
            for (int i = 0; i < Rows; ++i)
            {
                List<Block> tmp = new List<Block>();
                for (int j = 0; j < Cols; ++j)
                {
                    // 创建方块
                    Block block = new Block(i, j);
                    block.Size = new Size(MineSize, MineSize); // 方块的大小
                    block.Margin = new Padding(0); // 边距
                    block.FlatStyle = FlatStyle.Flat; // 控件的外观，Flat控件以平面显示
                    block.FlatAppearance.BorderSize = 1; // 去外边框
                    block.FlatAppearance.BorderColor = Color.White;
                    block.BackColor = MineColor;

                    block.Click += new EventHandler(Block_Click); // 引起事件响应
                    block.MouseDown += new MouseEventHandler(Block_MouseDown);
                    panelGameArea.Controls.Add(block);
                    // int row = 
                    block.Location = new Point(i * MineSize, j * MineSize);
                    // 保存到数组中
                    //getBlock(i, j) = block;
                    tmp.Add(block);
                }
                this.blocks.Add(tmp);
            }
        }
        private Block getBlock(int row, int col) {
            return blocks[row][col];
        }
        // 生成随机地雷
        private void RandomMine()
        {
            Random random = new Random();
            int mines = remainMine;
            while (mines > 0)
            {
                // 随机生成地雷的坐标
                int row = random.Next(Rows); // random.Next()  返回参数
                int col = random.Next(Cols);
                // 更新blocks
                if (!getBlock(row, col).isMine)
                {
                    getBlock(row, col).isMine = true;
                    mines--;
                }
            }
        }
        private void UpdateMineCount()
        {
            // 更新每个方块周围的地雷数量
            // 并更新每个block的Text！！！
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    int count = 0;
                    for (int m = i - 1; m <= i + 1; m++)
                    {
                        for (int n = j - 1; n <= j + 1; n++)
                        {
                            if (m >= 0 && m < Rows && n >= 0 && n < Cols
                                && getBlock(m, n).isMine)
                            {
                                count++;
                            }
                        }
                    }
                    getBlock(i, j).mineCount = count;
                }
            }
        }

        // Click Start！
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // 初始化游戏区域
            panelGameArea.Controls.Clear(); // 将所有控件一次性全部删除
            if(IsSilence == false)
                bgm1.Play();
            
            // 初始化笑脸
            if (_GameTheme == GameTheme.face)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.Laugh4;
            else if (_GameTheme == GameTheme.fufu)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.fufu_quick2;
            else if (_GameTheme == GameTheme.dinosaur)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.恐龙微笑2;
            CreateMap();
            // 初始化剩余地雷数量
            remainMine = curMine;
            _remainMine = remainMine;
            // 开始计时
            StartTimer();
            cnt = 0;
            labelRemainMine.Text = remainMine.ToString();
            // 生成随机地雷 
            RandomMine();
            UpdateMineCount();
        }
       
        // 方块点击事件
        private void Block_Click(object sender, EventArgs e)
        {
            Block block = sender as Block;           
            // 点到雷，游戏结束
            if (block.isMine)
            {
                block.BackColor = Color.Red;
                block.Text = "!";
                GameOver();
            }
            // 非雷，显示周围地雷数量
            else
            {
                block.BackColor = Color.LightGray;
                block.Text = block.mineCount > 0 ? block.mineCount.ToString() : "";
            }

        }
        // 方块的鼠标处理事件
        private void Block_MouseDown(object sender, MouseEventArgs e)
        {
            Block block = sender as Block;
            // 右建标记或取消标记事件
            if (e.Button == MouseButtons.Right)
            {
                
                if (block.Text == "")
                {
                    block.Text = "○";
                    remainMine--;
                    
                }
                else if (block.Text == "○")
                {
                    block.Text = "?";
                    remainMine++;
                }
                else if (block.Text == "?")
                {
                    block.Text = "";
                }
                labelRemainMine.Text = remainMine.ToString();
            }
            else if (e.Button == MouseButtons.Left)
            {
                // 左键为雷，游戏结束
                if (block.isMine)
                {
                    // boom.Play();
                    block.BackColor = Color.Red;
                    block.Text = "!";
                    // block.BackgroundImage = MineSwepper.Properties.Resources.boom1;
                    GameOver();
                    
                }
                else
                {
                    block.Enabled = false;
                    // 非地雷
                    block.BackColor = Color.LightGray;
                    block.Text = block.mineCount > 0 ? block.mineCount.ToString() : "";
                    if (block.mineCount == 0)
                    {
                        OpenBlocks(block.Row, block.Col);
                    }
                }
                cnt = 0;
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        if (getBlock(i, j).Enabled)
                        {
                            cnt++;
                        }
                    }
                }
                if (cnt == _remainMine)
                {

                    GameSuccess();
                }
            }
        }
        // 揭开方块周围有没有地雷和标记的方块(递归实现)
        // 哗啦啦一片片
        private void OpenBlocks(int row, int col)
        {
            // 遍历block四周
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i >= 0 && i < Rows && j >= 0 && j < Cols
                       && getBlock(i, j).Enabled && !getBlock(i, j).isMine && (getBlock(i, j).mineCount == 0
                       || getBlock(i, j).Text == ""))
                    {
                        getBlock(i, j).Enabled = false;
                        getBlock(i, j).BackColor = Color.LightGray;
                        getBlock(i, j).Text = getBlock(i, j).mineCount > 0 ? getBlock(i, j).mineCount.ToString() : "";
                        if (getBlock(i, j).mineCount == 0)
                        {
                            OpenBlocks(i, j);
                        }
                    }
                }
            }
        }
        private void GameOver()
        {
            if (IsSilence == false)
                boom.Play();
            // 停止计时
            StopTimer();
            
            if (_GameTheme == GameTheme.face)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.苦脸2;
            else if (_GameTheme == GameTheme.fufu)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.fufu_cry2;
            else if (_GameTheme == GameTheme.dinosaur)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.恐龙伤心2;
            MessageBox.Show("Boom！！！炸了炸了捏", "噫噫噫", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            // 禁止继续点击
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    getBlock(i, j).Enabled = false;
                }
            }

        }
        private void GameSuccess()
        {
            if (IsSilence == false)
                Success.Play();
            StopTimer();
            if (_GameTheme == GameTheme.face)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.face2;
            else if (_GameTheme == GameTheme.fufu)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.fufu_love2;
            else if (_GameTheme == GameTheme.dinosaur)
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.恐龙开心2;
            MessageBox.Show("成功扫雷！扫雷大师！！", "哇哇哇", MessageBoxButtons.OK);
            // 禁止继续点击
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    getBlock(i, j).Enabled = false;
                }
            }
        }
        #region 计时
        private void StartTimer()
        {
            // 初始化
            _nowSecond = 0;
            timer1.Enabled = true;
            labelMinute.Text = "00";
            labelSecond.Text = "00";
            labelColon.Visible = true;
        }
        // 计时器开始事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            _nowSecond++;
            // 转换分、秒
            int Minute = (_nowSecond % 3600) / 60;
            int Second = (_nowSecond % 3600) % 60 ;
            if (Minute <= 9)
            {
                labelMinute.Text = "0" + Minute.ToString();
            }
            else
                labelMinute.Text = Minute.ToString();
            if (Second <= 9)
            {
                labelSecond.Text = "0" + Second.ToString();
            }
            else
                labelSecond.Text = Second.ToString();
        }
        private void StopTimer()
        {
            timer1.Enabled = false;
        }
        #endregion

        #region 颜色
        // 换颜色
        private void MenuItemChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = MineColor;
            // 显示对话框
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                MineColor = colorDialog1.Color;
            }
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (getBlock(i, j).Enabled)
                    {
                        getBlock(i, j).BackColor = MineColor;
                    }
                }
            }
        }
        // 恢复默认颜色
        private void MenuItemDefault_Click(object sender, EventArgs e)
        {
            MineColor = DefaultMineColor;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (getBlock(i, j).Enabled)
                    {
                        getBlock(i, j).BackColor = MineColor;
                    }
                }
            }
        }
        #endregion

        #region 难度
        private void MenuItemEasy_Click(object sender, EventArgs e)
        {
            panelHeight = 360;
            panelWidth = 360;
            FormSizeHeight = 462;
            FormSizeWidth = 368;

            Rows = 9;
            Cols = 9;
            curMine = 8;
            MineSize = 360 / Rows;
  
            Size = new Size(FormSizeWidth, FormSizeHeight);
            panelGameArea.Size = new Size(panelWidth, panelHeight);
            buttonStart_Click(null, null);
           
        }
        // 12*12
        private void MenuItemMedium_Click(object sender, EventArgs e)
        {
            panelHeight = 420;
            panelWidth = 420;
            FormSizeHeight = 526;
            FormSizeWidth = 430;

            Rows = 12;
            Cols = 12;
            curMine = 25;
            MineSize = panelHeight / Rows;

            Size = new Size(FormSizeWidth, FormSizeHeight);
            panelGameArea.Size = new Size(panelWidth, panelHeight);

            buttonStart_Click(null, null);
        }
        // 15*15
        private void MenuItemHard_Click(object sender, EventArgs e)
        {
            panelHeight = 500;
            panelWidth = 500;
            FormSizeHeight = 605;
            FormSizeWidth = 507;

            Rows = 15;
            Cols = 15;
            curMine = 35;
            MineSize = panelHeight / Rows;
            Size = new Size(FormSizeWidth, FormSizeHeight);
            panelGameArea.Size = new Size(panelWidth, panelHeight);
            buttonStart_Click(null, null);
        }
       
        #endregion

        #region 主题
        private void MenuItemFuFuTheme_Click(object sender, EventArgs e)
        {
            _GameTheme = GameTheme.fufu;
            buttonStart_Click(null, null);
        }

        private void MenuItemFaceTheme_Click(object sender, EventArgs e)
        {
            _GameTheme = GameTheme.face;
            buttonStart_Click(null, null);
        }

        private void MenuItemDinosaur_Click(object sender, EventArgs e)
        {
            _GameTheme = GameTheme.dinosaur;
            buttonStart_Click(null, null);
        }
        #endregion

        // 随机数字
        private void MenuItemRandomNum_Click(object sender, EventArgs e)
        {
            
            RandomNum _randomNum = new RandomNum();
            // 设置默认值
            _randomNum.domainUpDownMin.Text = min.ToString();
            _randomNum.domainUpDownMax.Text = max.ToString();
            // 显示对话框
            if (_randomNum.ShowDialog(this) == DialogResult.OK)
            {
                buttonStart.BackgroundImage = MineSwepper.Properties.Resources.恐龙开心2;
                min = int.Parse(_randomNum.domainUpDownMin.Text);
                max = int.Parse(_randomNum.domainUpDownMax.Text);
                panelGameArea.Controls.Clear();
                // 创建方块
                panelGameArea.Size = new Size(360, 360);
                Size = new Size(368, 462);
                Block block = new Block(1, 1);

                block.Size = new Size(360, 360); // 方块的大小
                block.Margin = new Padding(0); // 边距
                block.FlatStyle = FlatStyle.Flat; // 控件的外观，Flat控件以平面显示
                block.FlatAppearance.BorderSize = 2; // 外边框
                block.FlatAppearance.BorderColor = Color.CadetBlue;
                // block.Location = new Point(80, 80);
                block.BackColor = MineColor;
                block.Font = new Font("隶书", 50);
                // 添加到panel控件中
                panelGameArea.Controls.Add(block);
                Random random = new Random();
                int RandomNum = random.Next(min, max);

                block.Text = RandomNum.ToString();
           
            }
            
            
            
        }
        // 静音
        private void MenuItemSilence_Click(object sender, EventArgs e)
        {
            if (IsSilence == false)
            {
                bgm1.Stop();
                IsSilence = true;
            }
            else
            {
                bgm1.Play();
                IsSilence = false;
            }
        }
        // 运气测试
        private void MenuItemLuckTest_Click_1(object sender, EventArgs e)
        {
            
            panelHeight = 360;
            panelWidth = 360;
            FormSizeHeight = 462;
            FormSizeWidth = 368;

            Rows = 2;
            Cols = 2;
            curMine = 3;
            MineSize = 360 / Rows;
            Size = new Size(FormSizeWidth, FormSizeHeight);
            panelGameArea.Size = new Size(panelWidth, panelHeight);
            buttonStart_Click(null, null);
            
        }

        private void panelGameArea_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
