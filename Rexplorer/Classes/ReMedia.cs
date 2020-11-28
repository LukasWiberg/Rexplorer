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

            using(Process cmdProcess = new Process()) {
                cmdProcess.StartInfo.FileName = "CMD.exe";
                cmdProcess.StartInfo.RedirectStandardInput = true;
                cmdProcess.StartInfo.RedirectStandardOutput = false;
                cmdProcess.StartInfo.UseShellExecute = false;
                cmdProcess.StartInfo.RedirectStandardError = false;
                cmdProcess.StartInfo.CreateNoWindow = true;

                cmdProcess.Start();

                using(StreamWriter cmdWriter = cmdProcess.StandardInput) {
                    List<string> commands = new List<string>();
                    for(int i = 0; i < files.Length; i++) {
                        string file = files[i].Replace('\\', '/');
                        commands.Add(GetConvertMediaCommand(file, outDirectory, subtitleTrack, audioTrack));
                    }
                    RunCommand(cmdWriter, string.Join("&", commands));
                }
                cmdProcess.WaitForExit();
            }
        }


        public static void ConvertMedia(StreamWriter cmdWriter, string file, string outputFolder, int subtitleTrack = 0, int audioTrack = 0) {
            string[] pathParts = file.Split('/');
            string command = String.Format("Y:/ffmpeg/bin/ffmpeg -y -hide_banner -loglevel warning -hwaccel cuda -i \"{0}\" -map 0:a:{1} -filter_complex [0:v]format=yuv420p10le,subtitles=\"{2}:si={3}\" -c:v hevc_nvenc -level 5.2 -rc vbr_hq -c:a aac \"{4}\"", file, audioTrack, Regex.Escape(file.Replace(":", @"\:")).Replace("[", @"\\[").Replace("]", @"\]"), subtitleTrack, outputFolder + "/" + pathParts[pathParts.Length - 1]);
            //string command = String.Format("/C Y:/ffmpeg/bin/ffmpeg -hwaccel cuda -i \"{0}\" -c:v hevc_nvenc -acodec copy -preset fast \"{2}\"", file, Regex.Escape(file.Replace(":", @"\:")).Replace("[", @"\\[").Replace("]", @"\]"), outputFolder+"/"+pathParts[pathParts.Length-1]);
            //Process a = Process.Start("CMD.exe", command).WaitForExit();
            cmdWriter.WriteLine(command);
        }

        public static void RunCommand(StreamWriter cmdWriter, string command) {
            cmdWriter.WriteLine(command);
        }

        public static string GetConvertMediaCommand(string file, string outputFolder, int subtitleTrack = 0, int audioTrack = 0) {
            string[] pathParts = file.Split('/');
            string command = String.Format("Y:/ffmpeg/bin/ffmpeg -y -hide_banner -loglevel warning -hwaccel cuda -i \"{0}\" -map 0:a:{1} -filter_complex [0:v]format=yuv420p10le,subtitles=\"{2}:si={3}\" -c:v hevc_nvenc -level 5.2 -rc vbr_hq -c:a aac \"{4}\"", file, audioTrack, Regex.Escape(file.Replace(":", @"\:")).Replace("[", @"\\[").Replace("]", @"\]"), subtitleTrack, outputFolder + "/" + pathParts[pathParts.Length - 1]);
            return command;
        }
    }
}
