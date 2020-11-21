using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rexplorer.Classes {
    public class ReMedia {
        public static Task ConvertMediaFolderTask(string inputFolder, string outputFolder, int subtitleTrack = 0, int audioTrack = 0) {
            ConvertMediaFolder(inputFolder, outputFolder, subtitleTrack, audioTrack);
            return null;
        }

        public static void ConvertMediaFolder(string inputFolder, string outputFolder, int subtitleTrack = 0, int audioTrack = 0) {
            string inDirectory = inputFolder.Replace('\\', '/');
            string outDirectory = outputFolder.Replace('\\', '/');
            string[] files = Directory.GetFiles(inDirectory);
            for(int i = 0; i < files.Length; i++) {
                string file = files[i].Replace('\\', '/');
                ConvertMedia(file, outDirectory, subtitleTrack, audioTrack);
            }
        }


        public static void ConvertMedia(string file, string outputFolder, int subtitleTrack = 0, int audioTrack = 0) {
            string[] pathParts = file.Split('/');
            string command = String.Format("/C Y:/ffmpeg/bin/ffmpeg -hwaccel cuda -i \"{0}\" -map 0:a:{1} -filter_complex [0:v]format=yuv420p10le,subtitles=\"{2}:si={3}\" -c:v hevc_nvenc -level 5.2 -rc vbr_hq -c:a aac \"{4}\"", file, audioTrack, Regex.Escape(file.Replace(":", @"\:")).Replace("[", @"\\[").Replace("]", @"\]"), subtitleTrack, outputFolder + "/" + pathParts[pathParts.Length - 1]);
            //string command = String.Format("/C Y:/ffmpeg/bin/ffmpeg -hwaccel cuda -i \"{0}\" -c:v hevc_nvenc -acodec copy -preset fast \"{2}\"", file, Regex.Escape(file.Replace(":", @"\:")).Replace("[", @"\\[").Replace("]", @"\]"), outputFolder+"/"+pathParts[pathParts.Length-1]);
            Process.Start("CMD.exe", command).WaitForExit();
        }
    }
}
