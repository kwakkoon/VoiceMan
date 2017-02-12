namespace VoiceMan
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MF_menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.녹음파일보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.녹음파일변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangCombo = new System.Windows.Forms.ToolStripComboBox();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설명ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileChangeCBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn4 = new System.Windows.Forms.PictureBox();
            this.btn5 = new System.Windows.Forms.PictureBox();
            this.btn6 = new System.Windows.Forms.PictureBox();
            this.btn7 = new System.Windows.Forms.PictureBox();
            this.btn8 = new System.Windows.Forms.PictureBox();
            this.StopBTN = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.PictureBox();
            this.btn2 = new System.Windows.Forms.PictureBox();
            this.MF_menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).BeginInit();
            this.SuspendLayout();
            // 
            // MF_menuStrip
            // 
            this.MF_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MF_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.LangCombo,
            this.도움말ToolStripMenuItem});
            this.MF_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.MF_menuStrip.Name = "MF_menuStrip";
            this.MF_menuStrip.Size = new System.Drawing.Size(297, 32);
            this.MF_menuStrip.TabIndex = 1;
            this.MF_menuStrip.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.녹음파일보기ToolStripMenuItem,
            this.녹음파일변경ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 녹음파일보기ToolStripMenuItem
            // 
            this.녹음파일보기ToolStripMenuItem.Name = "녹음파일보기ToolStripMenuItem";
            this.녹음파일보기ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.녹음파일보기ToolStripMenuItem.Text = "녹음파일 보기";
            this.녹음파일보기ToolStripMenuItem.Click += new System.EventHandler(this.녹음파일보기ToolStripMenuItem_Click);
            // 
            // 녹음파일변경ToolStripMenuItem
            // 
            this.녹음파일변경ToolStripMenuItem.Name = "녹음파일변경ToolStripMenuItem";
            this.녹음파일변경ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.녹음파일변경ToolStripMenuItem.Text = "녹음파일 변경";
            this.녹음파일변경ToolStripMenuItem.Click += new System.EventHandler(this.녹음파일변경ToolStripMenuItem_Click);
            // 
            // LangCombo
            // 
            this.LangCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangCombo.Items.AddRange(new object[] {
            "한국어",
            "일본어",
            "중국어",
            "영어"});
            this.LangCombo.Name = "LangCombo";
            this.LangCombo.Size = new System.Drawing.Size(121, 28);
            this.LangCombo.SelectedIndexChanged += new System.EventHandler(this.LangCombo_SelectedIndexChanged);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설명ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(66, 28);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 설명ToolStripMenuItem
            // 
            this.설명ToolStripMenuItem.Name = "설명ToolStripMenuItem";
            this.설명ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.설명ToolStripMenuItem.Text = "설명";
            this.설명ToolStripMenuItem.Click += new System.EventHandler(this.설명ToolStripMenuItem_Click);
            // 
            // FileChangeCBox
            // 
            this.FileChangeCBox.AutoSize = true;
            this.FileChangeCBox.Location = new System.Drawing.Point(198, 272);
            this.FileChangeCBox.Name = "FileChangeCBox";
            this.FileChangeCBox.Size = new System.Drawing.Size(89, 19);
            this.FileChangeCBox.TabIndex = 2;
            this.FileChangeCBox.Text = "파일설정";
            this.FileChangeCBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.StopBTN, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 231);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.Location = new System.Drawing.Point(5, 85);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 60);
            this.btn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn4.TabIndex = 7;
            this.btn4.TabStop = false;
            this.btn4.Click += new System.EventHandler(this.AudioBTN_Click);
            this.btn4.MouseEnter += new System.EventHandler(this.Pbox_MouseEnter);
            this.btn4.MouseLeave += new System.EventHandler(this.Pbox_MouseLeave);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.Location = new System.Drawing.Point(96, 85);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 60);
            this.btn5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn5.TabIndex = 7;
            this.btn5.TabStop = false;
            this.btn5.Click += new System.EventHandler(this.AudioBTN_Click);
            this.btn5.MouseEnter += new System.EventHandler(this.Pbox_MouseEnter);
            this.btn5.MouseLeave += new System.EventHandler(this.Pbox_MouseLeave);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.Location = new System.Drawing.Point(188, 85);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 60);
            this.btn6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn6.TabIndex = 7;
            this.btn6.TabStop = false;
            this.btn6.Click += new System.EventHandler(this.AudioBTN_Click);
            this.btn6.MouseEnter += new System.EventHandler(this.Pbox_MouseEnter);
            this.btn6.MouseLeave += new System.EventHandler(this.Pbox_MouseLeave);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.Location = new System.Drawing.Point(5, 162);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 60);
            this.btn7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn7.TabIndex = 7;
            this.btn7.TabStop = false;
            this.btn7.Click += new System.EventHandler(this.AudioBTN_Click);
            this.btn7.MouseEnter += new System.EventHandler(this.Pbox_MouseEnter);
            this.btn7.MouseLeave += new System.EventHandler(this.Pbox_MouseLeave);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.Location = new System.Drawing.Point(96, 162);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 60);
            this.btn8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn8.TabIndex = 7;
            this.btn8.TabStop = false;
            this.btn8.Click += new System.EventHandler(this.AudioBTN_Click);
            this.btn8.MouseEnter += new System.EventHandler(this.Pbox_MouseEnter);
            this.btn8.MouseLeave += new System.EventHandler(this.Pbox_MouseLeave);
            // 
            // StopBTN
            // 
            this.StopBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StopBTN.Image = ((System.Drawing.Image)(resources.GetObject("StopBTN.Image")));
            this.StopBTN.Location = new System.Drawing.Point(188, 162);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(80, 60);
            this.StopBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StopBTN.TabIndex = 7;
            this.StopBTN.TabStop = false;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            this.StopBTN.MouseEnter += new System.EventHandler(this.Pbox_MouseEnter);
            this.StopBTN.MouseLeave += new System.EventHandler(this.Pbox_MouseLeave);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(5, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 60);
            this.btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn1.TabIndex = 7;
            this.btn1.TabStop = false;
            this.btn1.Click += new System.EventHandler(this.AudioBTN_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.Pbox_MouseEnter);
            this.btn1.MouseLeave += new System.EventHandler(this.Pbox_MouseLeave);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.Location = new System.Drawing.Point(188, 8);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 60);
            this.btn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn3.TabIndex = 7;
            this.btn3.TabStop = false;
            this.btn3.Click += new System.EventHandler(this.AudioBTN_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.Pbox_MouseEnter);
            this.btn3.MouseLeave += new System.EventHandler(this.Pbox_MouseLeave);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.Location = new System.Drawing.Point(96, 8);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 60);
            this.btn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn2.TabIndex = 7;
            this.btn2.TabStop = false;
            this.btn2.Click += new System.EventHandler(this.AudioBTN_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.Pbox_MouseEnter);
            this.btn2.MouseLeave += new System.EventHandler(this.Pbox_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.FileChangeCBox);
            this.Controls.Add(this.MF_menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MF_menuStrip;
            this.Name = "MainForm";
            this.Text = "VoiceMan";
            this.TopMost = true;
            this.MF_menuStrip.ResumeLayout(false);
            this.MF_menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MF_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 녹음파일변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox LangCombo;
        private System.Windows.Forms.ToolStripMenuItem 설명ToolStripMenuItem;
        private System.Windows.Forms.CheckBox FileChangeCBox;
        private System.Windows.Forms.ToolStripMenuItem 녹음파일보기ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox btn4;
        private System.Windows.Forms.PictureBox btn5;
        private System.Windows.Forms.PictureBox btn6;
        private System.Windows.Forms.PictureBox btn7;
        private System.Windows.Forms.PictureBox btn8;
        private System.Windows.Forms.PictureBox StopBTN;
        private System.Windows.Forms.PictureBox btn1;
        private System.Windows.Forms.PictureBox btn3;
        private System.Windows.Forms.PictureBox btn2;
    }
}

