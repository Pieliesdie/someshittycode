using System;
using System.IO;

namespace Task1
{
    public class Logger:IDisposable
    {
        private object obj = new object();
        private FileSystemWatcher watcher;
        private DateTime lastRead = DateTime.MinValue;
        private string loggsPath;
        private string backupPath;

        public Logger(string path,string loggsPath,string filter, bool includeSubFolders)
        {
            if (Directory.Exists(loggsPath))
            {
                throw new ArgumentException($"Folder {loggsPath} is already exist");
            }
            Directory.CreateDirectory(path);
            backupPath = loggsPath;
            this.loggsPath = loggsPath + "\\Logs.txt";
            watcher = new FileSystemWatcher(path,filter);
            watcher.IncludeSubdirectories = includeSubFolders;
            AddEventsToWatcher(watcher);
            MakeBackup(watcher);
        }

        private void MakeBackup(object sender)
        {
            string pathTo = Path.Combine(backupPath, DateTime.Now.ToString(@"dd-MM-yyyy@HH.mm.ss"));
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory((sender as FileSystemWatcher).Path,pathTo);
        }

        public bool RestoreBackup(string name)
        {
            watcher.EnableRaisingEvents = false;
            string pathFrom = Path.Combine(backupPath,name);
            if (!Directory.Exists(pathFrom))
            {
                return false;
            }
            string pathTo = watcher.Path;
            Directory.Delete(pathTo, true);
            Directory.CreateDirectory(pathTo);
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(pathFrom, pathTo);
            watcher.EnableRaisingEvents = true;
            return true;
        }

        private void AddEventsToWatcher(FileSystemWatcher watcher)
        {
            watcher.Deleted += OnDeleted;
            watcher.Created += OnCreated;
            watcher.Changed += OnChanged;
            watcher.Renamed += OnRenamed;
            watcher.EnableRaisingEvents = true;
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            MakeBackup(sender);
            string fileEvent = "renamed to " + e.FullPath;
            string filePath = e.OldFullPath;
            RecordEntry(fileEvent, filePath);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
            if (lastWriteTime != lastRead)
            {
                MakeBackup(sender);
                string fileEvent = "changed";
                string filePath = e.FullPath;
                RecordEntry(fileEvent, filePath);
                lastRead = lastWriteTime;
            }
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            MakeBackup(sender);
            string fileEvent = "created";
            string filePath = e.FullPath;
            RecordEntry(fileEvent, filePath);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "deleted";
            string filePath = e.FullPath;
            RecordEntry(fileEvent, filePath);
        }

        private void RecordEntry(string fileEvent, string filePath)
        {
            lock (obj)
            {
                using (StreamWriter writer = new StreamWriter(loggsPath, true))
                {
                    writer.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")} file {filePath} was {fileEvent}");
                    writer.Flush();
                }
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    watcher.Dispose();
                    obj = null;
                    loggsPath = null;
                    disposedValue = true;
                }
            }
        }

        ~Logger()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
