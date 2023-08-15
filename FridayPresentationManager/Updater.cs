using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FridayPresentationManager
{
    internal class Updater
    {
        string serverDir { get; set; }
        string currentDir { get; set; }
        Thread synchonizer = null;
        ProgressStatus status;
        //---------------------------------------------------------------------------------------
        private bool FileSynchronize(string sourcePath, string destPath)
        {
            FileInfo fi = new FileInfo(sourcePath);
            string fPath = Path.Combine(destPath, fi.Name);
            if (File.Exists(fPath) ||fi.Extension.Equals("db")) { return true; }
            bool result = false;
            status.Status(sourcePath);
            try 
            { 
                File.Copy(sourcePath, fPath); 
                result = true;
            }
            catch (Exception e)
            { 
                status.Status(e.Message);
            }
            
            status.PerfomsStep();
            return result;
        }
        //---------------------------------------------------------------------------------------
        private void SynchronizeFolder(string source,string dest)
        {
            string[] sourceFolders = Directory.GetDirectories(source);
            foreach(string sFolder in sourceFolders)
            {
                DirectoryInfo sDI = new DirectoryInfo(sFolder);
                string newDest = Path.Combine(dest, sDI.Name);

                if (!Directory.Exists(newDest))
                {
                    Directory.CreateDirectory(newDest);
                }

                SynchronizeFolder(sFolder, newDest);
            }
            string[] files = Directory.GetFiles(source);
            status.PBLimits(new int[] { 0, files.Length, 1 });
            foreach (string sFile in files)
            {
                FileSynchronize(sFile, dest);
            }
            status.Value(status.PBLimitsMin());
        }
        internal void ServerDirectoryUpdate()
        {
            status.Visible(true);
            SynchronizeFolder(serverDir, currentDir);
            MainWindow.mainWindow.MainWindowLoad(true);

            //сделать лок и ожидание

            status.Destroy();
            status = null;
        }

        public Updater(string serverDir, string currentDir)
        {
            this.serverDir = serverDir;
            this.currentDir = currentDir;
            this.status = new ProgressStatus(MainWindow.mainWindow.pbarStatus,MainWindow.mainWindow.lStatus);

            synchonizer = new Thread(ServerDirectoryUpdate);
            synchonizer.Start();
        }
        public void Destroy()
        {
            if (synchonizer != null) 
            {
                synchonizer.Abort();
                synchonizer = null;
                serverDir = "";
                currentDir = "";
            }
            status = null;
        }
    }
}
