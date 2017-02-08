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
            this.btn1 = new System.Windows.Forms.Button();
            this.MF_menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.녹음파일보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.녹음파일변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangCombo = new System.Windows.Forms.ToolStripComboBox();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설명ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.FileChangeCBox = new System.Windows.Forms.CheckBox();
            this.MF_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(11, 43);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 93);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.AudioBTN_Click);
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
            this.녹음파일보기ToolStripMenuItem,
            this.녹음파일변경ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 녹음파일보기ToolStripMenuItem
            // 
            this.녹음파일보기ToolStripMenuItem.Name = "녹음파일보기ToolStripMenuItem";
            this.녹음파일보기ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.녹음파일보기ToolStripMenuItem.Text = "녹음파일 보기";
            this.녹음파일보기ToolStripMenuItem.Click += new System.EventHandler(this.녹음파일보기ToolStripMenuItem_Click);
            // 
            // 녹음파일변경ToolStripMenuItem
            // 
            this.녹음파일변경ToolStripMenuItem.Name = "녹음파일변경ToolStripMenuItem";
            this.녹음파일변경ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
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
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(117, 43);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 93);
            this.btn2.TabIndex = 0;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(223, 43);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 93);
            this.btn3.TabIndex = 0;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(11, 142);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 93);
            this.btn4.TabIndex = 0;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(117, 142);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 93);
            this.btn5.TabIndex = 0;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(223, 142);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 93);
            this.btn6.TabIndex = 0;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(11, 241);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 93);
            this.btn7.TabIndex = 0;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(117, 241);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 93);
            this.btn8.TabIndex = 0;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.AudioBTN_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Location = new System.Drawing.Point(223, 241);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(100, 93);
            this.StopBTN.TabIndex = 0;
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // FileChangeCBox
            // 
            this.FileChangeCBox.AutoSize = true;
            this.FileChangeCBox.Location = new System.Drawing.Point(247, 340);
            this.FileChangeCBox.Name = "FileChangeCBox";
            this.FileChangeCBox.Size = new System.Drawing.Size(89, 19);
            this.FileChangeCBox.TabIndex = 2;
            this.FileChangeCBox.Text = "파일설정";
            this.FileChangeCBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 364);
            this.Controls.Add(this.FileChangeCBox);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.MF_menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MF_menuStrip;
            this.Name = "MainForm";
            this.Text = "VoiceMan";
            this.MF_menuStrip.ResumeLayout(false);
            this.MF_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.MenuStrip MF_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 녹음파일변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.ToolStripComboBox LangCombo;
        private System.Windows.Forms.ToolStripMenuItem 설명ToolStripMenuItem;
        private System.Windows.Forms.CheckBox FileChangeCBox;
        private System.Windows.Forms.ToolStripMenuItem 녹음파일보기ToolStripMenuItem;
    }
}

