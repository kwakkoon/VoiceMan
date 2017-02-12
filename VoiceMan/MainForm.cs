using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VoiceMan
{
    public partial class MainForm : Form
    {
        Action MF_Action = new Action(); // 오디오 재생,정지 / 파일변경 / 현재버튼,현재언어 설정 / 디렉토리 생성 
       
        string Dia_filePath = null;
        string CurrLang = "한국어";    // default 언어 한국어
        string CurrDirectory = Directory.GetCurrentDirectory();

        public MainForm()
        {
            InitializeComponent();
            LangCombo.Text = "한국어";
            
        }

        private void LangCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //녹음 파일 Path 파일 경로 설정 (언어선택)
            CurrLang = LangCombo.SelectedItem.ToString();
        }
        Process[] mprocess = null;
        private void AudioBTN_Click(object sender, EventArgs e)
        {
            //선택된 버튼 지정 1
            PictureBox btn = sender as PictureBox;

            //선택된 언어
            CurrLang = MF_Action.LangSelect(LangCombo.Text);
            CurrDirectory = Path.Combine(Directory.GetCurrentDirectory(), "audio" ,CurrLang);

            //선택된 버튼 지정 2 -> 파일경로 설정
            string btnName = btn.Name.ToString();
            string theFileName = MF_Action.BtnSelect(btnName);

            theFileName += ".mp3";
            theFileName = Path.Combine(CurrDirectory, theFileName);

            MF_Action.AudioStop();

            if (FileChangeCBox.Checked == true) //파일수정 체크 확인
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Filter = "녹음 파일 (*.mp3;*.wav;)|*.mp3;*.wav|" +
                            "All files (*.*)|*.*";

                if (OpenFile.ShowDialog()==DialogResult.OK)
                {
                    FileChangeCBox.Checked = false;
                    MF_Action.DirectoryCreate(CurrDirectory);
                    
                    Dia_filePath = OpenFile.FileName;

                    FileInfo currmusic = new FileInfo(theFileName);
                    if(File.Exists(theFileName))
                    {
                        File.SetAttributes(theFileName, FileAttributes.Normal);

                        File.Delete(theFileName);
                        
                    }
                    File.Copy(Dia_filePath, theFileName);
                    File.SetAttributes(theFileName, FileAttributes.Normal);
                }
            }
            else
            {
                try
                {
                    if (File.Exists(theFileName) == true)
                        MF_Action.AudioPlay(theFileName);
                    else
                        MessageBox.Show("선택된 파일이 없습니다. \n파일을 설정해주세요.");
                }
                catch(Exception)
                {
                    MessageBox.Show("오류가 발생하였습니다.\n프로그램을 종료합니다.");
                    Close();
                }
            }

        }

        private void 녹음파일변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MF_Action.AudioStop();

            CurrLang = MF_Action.LangSelect(LangCombo.Text);
            CurrDirectory = Path.Combine(Directory.GetCurrentDirectory(), "audio", CurrLang);
            
            OpenFileDialog OpenFiles = new OpenFileDialog();
            OpenFiles.Multiselect = true;
            OpenFiles.Filter = "녹음 파일 (*.mp3;*.wav;)|*.mp3;*.wav|" +
                            "All files (*.*)|*.*";

            reDialogStart:
            if (OpenFiles.ShowDialog()==DialogResult.OK)
            {
                int FilesIndex = OpenFiles.FileNames.Length;
                if (FilesIndex > 8)
                {
                    MessageBox.Show("선택된 파일 개수가 너무 많습니다.\n8개까지 설정가능합니다.");
                    goto reDialogStart;
                }
                else
                {
                    MF_Action.DirectoryCreate(CurrDirectory);
                    string theFileName = null;
                    int temp;

                    for (int i = 0; i < FilesIndex; i++)
                    {
                        theFileName = null;
                        temp = i + 1;
                        theFileName = temp.ToString() + ".mp3";
                        theFileName = Path.Combine(CurrDirectory, theFileName);
                        
                        File.Delete(theFileName);

                        File.Copy(OpenFiles.FileNames[i], theFileName, true);
                        File.SetAttributes(theFileName, FileAttributes.Normal);
                    }
                }
            }
        }

        private void 설명ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 녹음파일 지정할 때 한 언어마다 8개까지 지정가능하며 (파일명ex : 1.mp3) \n 좌측 상단부터 1 2 3 4 5 6 7 8로 지정됩니다. \n 또는 파일수정 체크 후 수정하고자하는 버튼을 클릭해서 수정가능합니다. \n\n 버튼 이미지 변경은 추후에 업데이트하겠습니다. \n\n 감사합니다.");
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            MF_Action.AudioStop();
        }

        private void 녹음파일보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrLang = MF_Action.LangSelect(LangCombo.Text);
            string dirPath = Path.Combine(Directory.GetCurrentDirectory(), "audio", CurrLang);
            
            Process.Start(dirPath);
            
        }

        //PictureBox 마우스 이벤트 크기 조절
        private void Pbox_MouseEnter(object sender, EventArgs e)
        {
            Control ctl = sender as Control;
            if (ctl != null)
            {
                ctl.Size = new Size(85, 65);
            }
        }
        private void Pbox_MouseLeave(object sender, EventArgs e)
        {
            Control ctl = sender as Control;
            if (ctl != null)
            {
                ctl.Size = new Size(70, 50);
            }
        }
    }
}
