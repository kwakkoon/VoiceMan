using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;



namespace VoiceMan
{
    /// <summary>
    /// Action Class
    ///  - AudioPlay
    ///  - CreateDirectory
    /// </summary>
    class Action
    {
        public void AudioPlay(string currentLang, string btnName)
        {
            string filePath = Directory.GetCurrentDirectory();
            string _filePath = @"\audio\";

            switch(currentLang)
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

            }
            
            filePath += @"\"+currentLang;
            filePath += @"\123.mp3";

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            
            if (btnName != "StopBTN")
            {
                //주소 받기


                //주소 지정
                wplayer.URL = filePath;
                wplayer.controls.play();
            }
            else
            {
                wplayer.controls.stop();
            }
        }
        
        public void CreateDirectory()
        {
            
        }
    }
}
