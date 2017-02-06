using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceMan
{
    public partial class MainForm : Form
    {
        Action MainAction = new Action(); // 오디오 플레이 / 파일변경 / 도움말(라이센스)
        List<string> Dia_filePath = new List<string>();

        string CurrntLang = "한국어";
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void LangCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //녹음 파일 Path 파일 경로 설정 (언어선택)
            CurrntLang = LangCombo.SelectedItem.ToString();
        }

        private void AudioBTN_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            string btnName = btn.Name.ToString();
            MainAction.AudioPlay(CurrntLang, btnName);
        }

        private void 녹음파일변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // openfile_Dig 다중선택 진행중..
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Multiselect = true;
            OpenFile.Filter = "녹음 파일 (*.mp3;*.wma;)|*.mp3;*.wma|" +
                            "All files (*.*)|*.*";

            

            if (OpenFile.ShowDialog()==DialogResult.OK)
            {
                /*
                foreach(var idx in )
                filePath = OpenFile.FileName; //전체경로
                */
            }
        }

        private void 설명ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 녹음파일 지정할 때 한 언어마다 8개까지 지정가능하며 (파일명ex : 1.mp3) \n 좌측 상단부터 1 2 3 4 5 6 7 8로 지정됩니다. \n 버튼 이미지 변경은 추후에 업데이트하겠습니다 \n\n 감사합니다.");
        }
    }
}
