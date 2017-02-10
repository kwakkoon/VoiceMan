using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace VoiceMan
{
    /// <summary>
    /// Action Class
    ///  - AudioPlay
    ///  - AudioStop
    ///  
    ///  - DirectoryCreate
    ///  
    ///  - LangSelect
    ///  - BtnSelect
    /// </summary>

    class Action
    {
        MediaPlayer.MediaPlayerClass player = new MediaPlayer.MediaPlayerClass();

        public void AudioPlay(string theFileName)
        {
            player.FileName = theFileName;
            player.Play();
        }

        public void AudioStop()
        {
            player.Stop();
        }

        public string LangSelect(string currentLang)
        {
            switch (currentLang)
            {
                case "한국어":
                    currentLang = "kor";
                    break;

                case "일본어":
                    currentLang = "jap";
                    break;

                case "영어":
                    currentLang = "eng";
                    break;

                case "중국어":
                    currentLang = "ch";
                    break;

                default:
                    currentLang = "kor";
                    break;
            }
            return currentLang;
        }

        public string BtnSelect(string btnName)
        {
            string btnNumber = null;

            switch(btnName)
            {
                case "btn1":
                    btnNumber = "1";
                    break;
                case "btn2":
                    btnNumber = "2";
                    break;
                case "btn3":
                    btnNumber = "3";
                    break;
                case "btn4":
                    btnNumber = "4";
                    break;
                case "btn5":
                    btnNumber = "5";
                    break;
                case "btn6":
                    btnNumber = "6";
                    break;
                case "btn7":
                    btnNumber = "7";
                    break;
                case "btn8":
                    btnNumber = "8";
                    break;
            }
            return btnNumber;
        }

        public void DirectoryCreate(string directoryPath)
        {
            DirectoryInfo dir = new DirectoryInfo(directoryPath);
            if (dir.Exists == false)
                dir.Create();
        }


    }
}
