namespace MineSwepper
{
    partial class RandomNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomNum));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.domainUpDownMin = new System.Windows.Forms.DomainUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.domainUpDownMax = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 15F);
            this.labelTitle.Location = new System.Drawing.Point(18, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(259, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "请输入随机生成数字的范围:";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("宋体", 15F);
            this.labelMin.Location = new System.Drawing.Point(62, 47);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(49, 20);
            this.labelMin.TabIndex = 0;
            this.labelMin.Text = "min:";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("宋体", 15F);
            this.labelMax.Location = new System.Drawing.Point(62, 73);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(49, 20);
            this.labelMax.TabIndex = 0;
            this.labelMax.Text = "max:";
            this.labelMax.Click += new System.EventHandler(this.labelMax_Click);
            // 
            // domainUpDownMin
            // 
            this.domainUpDownMin.Font = new System.Drawing.Font("宋体", 10F);
            this.domainUpDownMin.Location = new System.Drawing.Point(117, 44);
            this.domainUpDownMin.Name = "domainUpDownMin";
            this.domainUpDownMin.Size = new System.Drawing.Size(91, 23);
            this.domainUpDownMin.TabIndex = 1;
            this.domainUpDownMin.Text = "0";
            this.domainUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonOK.Location = new System.Drawing.Point(56, 108);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(65, 31);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "确认";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(154, 108);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(65, 31);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainUpDownMax
            // 
            this.domainUpDownMax.Font = new System.Drawing.Font("宋体", 10F);
            this.domainUpDownMax.Location = new System.Drawing.Point(117, 73);
            this.domainUpDownMax.Name = "domainUpDownMax";
            this.domainUpDownMax.Size = new System.Drawing.Size(91, 23);
            this.domainUpDownMax.TabIndex = 1;
            this.domainUpDownMax.Text = "100";
            this.domainUpDownMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDownMax.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // RandomNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 164);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.domainUpDownMax);
            this.Controls.Add(this.domainUpDownMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomNum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandomNum";
            this.Load += new System.EventHandler(this.RandomNum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.DomainUpDown domainUpDownMin;
        public System.Windows.Forms.DomainUpDown domainUpDownMax;
    }
}