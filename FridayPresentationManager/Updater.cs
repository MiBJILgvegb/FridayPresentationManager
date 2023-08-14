using FridayPresentationManager.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
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
        private string[] DirToDirInfo(string[] strings)
        {
            string[] returnedStrings = strings;
            for (int i = 0; i < returnedStrings.Length; i++)
            {
                DirectoryInfo di = new DirectoryInfo(returnedStrings[i]);
                returnedStrings[i] = di.Name;
            }

            return returnedStrings;
        }
        private bool FileSynchronize(string sourcePath, string destPath)
        {
            bool result = false;
            status.Status(sourcePath);
            try 
            { 
                File.Copy(sourcePath, destPath); 
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
            //Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(source, dest);

            string[] sourceFolders = Directory.GetDirectories(source);
            foreach(string sFolder in sourceFolders)
            {
                if (Directory.Exists(sFolder)) 
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(sFolder);

                    string newDest = Path.Combine(dest, directoryInfo.Name);
                    Directory.CreateDirectory(newDest);
                    
                    SynchronizeFolder(sFolder, newDest); 
                }

                string[] files=Directory.GetFiles(sFolder);
                foreach(string sFile in files)
                {
                    FileSynchronize(sFile, dest);
                }
                    
            }
        }
        internal void SynchronizePresentations(string serverDir, string currentDir)
        {
            string[] serverPresentations= Directory.GetFiles(serverDir, "*" + Consts.presentationEXTs[0], SearchOption.TopDirectoryOnly);
            if (serverPresentations.Count() < 0) return;
            serverPresentations = DirToDirInfo(serverPresentations);

            status.PBLimits(new int[] { 0, serverPresentations.Length, 1});
            for (int i = 0; i < serverPresentations.Length; i++)
            {
                if (!File.Exists(Path.Combine(currentDir, serverPresentations[i])))
                {
                    string sourcePath = Path.Combine(serverDir, serverPresentations[i]);
                    string destPath = Path.Combine(currentDir, serverPresentations[i]);

                    FileSynchronize(sourcePath, destPath);
                }
            }
        }
        private void SynchronizeDate(string serverDir, string currentDir)
        {
            string[] serverDate = Directory.GetDirectories(serverDir, "*", SearchOption.TopDirectoryOnly);
            if (serverDate.Count() < 0) return;
            serverDate = DirToDirInfo(serverDate);

            string[] currentDate = Directory.GetDirectories(currentDir, "*", SearchOption.TopDirectoryOnly);
            currentDate = DirToDirInfo(currentDate);

            for (int i = 0; i < serverDate.Length; i++)
            {
                if (!currentDate.Contains(serverDate[i]))
                {
                    //SynchronizeFolder(Path.Combine(serverDir, serverDate[i]), Path.Combine(currentDir, serverDate[i]) );
                    Directory.CreateDirectory(Path.Combine(currentDir, serverDate[i]));
                }
                SynchronizePresentations(Path.Combine(serverDir, serverDate[i]), Path.Combine(currentDir, serverDate[i]));
            }
        }
        private void SynchronizeMonth(string serverDir, string currentDir)
        {
            string[] serverMonth = Directory.GetDirectories(serverDir, "*", SearchOption.TopDirectoryOnly);
            if (serverMonth.Count() < 0) return;
            serverMonth=DirToDirInfo(serverMonth);

            string[] currentMonth = Directory.GetDirectories(currentDir, "*", SearchOption.TopDirectoryOnly);
            currentMonth = DirToDirInfo(currentMonth);

            for (int i = 0; i < serverMonth.Length; i++)
            {
                if (!currentMonth.Contains(serverMonth[i]))
                {
                    //SynchronizeFolder(Path.Combine(serverDir, serverMonth[i]), Path.Combine(currentDir, serverMonth[i]));
                    Directory.CreateDirectory(Path.Combine(currentDir, serverMonth[i]));
                }
                SynchronizeDate(Path.Combine(serverDir, serverMonth[i]), Path.Combine(currentDir, serverMonth[i]));
            }
        }
        private void SynchronizeYears(string serverDir, string currentDir)
        {
            string[] serverYears = Directory.GetDirectories(serverDir,"*", SearchOption.TopDirectoryOnly);
            if (serverYears.Count() < 0) return;
            serverYears = DirToDirInfo(serverYears);

            string[] currentYears = Directory.GetDirectories(currentDir, "*", SearchOption.TopDirectoryOnly);
            currentYears = DirToDirInfo(currentYears);

            for (int i = 0; i < serverYears.Length; i++)
            {
                if (!currentYears.Contains(serverYears[i]))
                {
                    //SynchronizeFolder(Path.Combine(serverDir, serverYears[i]), Path.Combine(currentDir, serverYears[i]));
                    Directory.CreateDirectory(Path.Combine(currentDir, serverYears[i]));
                }
                SynchronizeMonth(Path.Combine(serverDir, serverYears[i]), Path.Combine(currentDir, serverYears[i]));
            }
        }
        internal void ServerDirectoryUpdate()
        {
            SynchronizeFolder(serverDir, currentDir);
            //SynchronizeYears(serverDir, currentDir);
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
