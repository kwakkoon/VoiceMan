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
            this.button1 = new System.Windows.Forms.Button();
            this.MF_menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.녹음파일변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangCombo = new System.Windows.Forms.ToolStripComboBox();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.설명ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MF_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 93);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AudioBTN_Click);
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
            this.MF_menuStrip.Size = new System.Drawing.Size(336, 32);
            this.MF_menuStrip.TabIndex = 1;
            this.MF_menuStrip.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.녹음파일변경ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
            this.파일ToolStripMenuItem.Text = "파일";
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
            this.LangCombo.Items.AddRange(new object[] {
            "한국어",
            "일본어",
            "중국어",
            "영어"});
            this.LangCombo.Name = "LangCombo";
            this.LangCombo.Size = new System.Drawing.Size(121, 28);
            this.LangCombo.Text = "언어선택";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 93);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 93);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 93);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(118, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 93);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(224, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 93);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 252);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 93);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(118, 252);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 93);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Location = new System.Drawing.Point(224, 252);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(100, 93);
            this.StopBTN.TabIndex = 0;
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // 설명ToolStripMenuItem
            // 
            this.설명ToolStripMenuItem.Name = "설명ToolStripMenuItem";
            this.설명ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.설명ToolStripMenuItem.Text = "설명";
            this.설명ToolStripMenuItem.Click += new System.EventHandler(this.설명ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 353);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MF_menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MF_menuStrip;
            this.Name = "MainForm";
            this.Text = "VoiceMan";
            this.TopMost = true;
            this.MF_menuStrip.ResumeLayout(false);
            this.MF_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip MF_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 녹음파일변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.ToolStripComboBox LangCombo;
        private System.Windows.Forms.ToolStripMenuItem 설명ToolStripMenuItem;
    }
}

