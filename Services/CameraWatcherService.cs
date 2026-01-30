using System;
using System.IO;

namespace PhotoboothVipstudios.Services
{
    public class CameraWatcherService
    {
        private FileSystemWatcher? _watcher;

        public event Action<string>? OnPhotoCaptured;

        public void StartWatching(string folderPath)
        {
            StopWatching();

            if (!Directory.Exists(folderPath))
                throw new DirectoryNotFoundException(folderPath);

            _watcher = new FileSystemWatcher(folderPath);
            _watcher.Filter = "*.jpg";
            _watcher.Created += Watcher_Created;
            _watcher.EnableRaisingEvents = true;
        }

        public void StopWatching()
        {
            if (_watcher != null)
            {
                _watcher.EnableRaisingEvents = false;
                _watcher.Dispose();
                _watcher = null;
            }
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                // Tunggu file siap write
                System.Threading.Thread.Sleep(500);

                OnPhotoCaptured?.Invoke(e.FullPath);
            }
            catch
            {
                // Silent fail (production safe)
            }
        }
    }
}
