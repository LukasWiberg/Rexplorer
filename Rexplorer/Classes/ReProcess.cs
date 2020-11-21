using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Rexplorer.Classes {
    public sealed class ReProcess {
        public static readonly ReProcess instance = new ReProcess();
        private string currentDirectory;

        ReFileWatcher watcher;
        public ReProcess() {
            watcher = new ReFileWatcher();
        }

        public static void Navigate(string path) {
            WatchFolder(path);
            instance.currentDirectory = path;
        }

        public static void WatchFolder(string path) {
            instance.watchFolder(path);
        }
        private void watchFolder(string path) {
            watcher.WatchFolder(path, WatchChanged, WatchRenamed);
        }

        private static void WatchChanged(object source, FileSystemEventArgs e) {
            Debug.WriteLine($"File: {e.FullPath} {e.ChangeType}");
        }

        private static void WatchRenamed(object source, RenamedEventArgs e) {
            Debug.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
        }
    }
}
