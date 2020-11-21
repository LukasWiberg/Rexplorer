using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Permissions;
using System.Text;

namespace Rexplorer {
    class ReFileWatcher {
        FileSystemWatcher watcher;
        
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public void WatchFolder(string path, FileSystemEventHandler onChanged, RenamedEventHandler onRenamed) {
            if(watcher != null) {
                watcher.Dispose();
            }
            watcher = new FileSystemWatcher();
            watcher.Path = path;
            watcher.NotifyFilter = NotifyFilters.LastAccess
                                    | NotifyFilters.LastWrite
                                    | NotifyFilters.FileName
                                    | NotifyFilters.DirectoryName;

            watcher.Changed += onChanged;
            watcher.Created += onChanged;
            watcher.Deleted += onChanged;
            watcher.Renamed += onRenamed;

            watcher.EnableRaisingEvents = true;
        }
    }
}
