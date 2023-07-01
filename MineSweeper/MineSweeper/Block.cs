using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MineSwepper
{
    // Block:Button Block继承Button类型，方便鼠标点击游戏
    class Block : Button
    {
        private int row;
        private int col;
        // 构造函数 但无法引用非静态字段
        public Block(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        private bool IsMine = false; // 是否有地雷

        public bool isMine
        {
            get { return IsMine; }
            set { IsMine = value; }
        }
        private int MineCount = 0; // 周围地雷数量

        public int mineCount
        {
            get { return MineCount; }
            set { MineCount = value; }
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Col
        {
            get { return col; }
            set { col = value; }
        }

    }
}
