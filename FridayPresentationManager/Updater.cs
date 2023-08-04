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
        private void SynchronizeFolder(string source,string dest)
        {
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(source, dest);
        }
        internal bool ServerCheck(string server)
        {
            /*Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(server, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Address: {0}", reply.Address.ToString());
                Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
            }*/
            if (server.Length > 0){ return Directory.Exists(server); }
            else { return false; }
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

                    status.Status(sourcePath);

                    File.Copy(sourcePath, destPath);

                    status.PerfomsStep();
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
                    SynchronizeFolder(Path.Combine(serverDir, serverDate[i]), Path.Combine(currentDir, serverDate[i]) );
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
                    SynchronizeFolder(Path.Combine(serverDir, serverMonth[i]), Path.Combine(currentDir, serverMonth[i]));
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
                    SynchronizeFolder(Path.Combine(serverDir, serverYears[i]), Path.Combine(currentDir, serverYears[i]));
                }
                SynchronizeMonth(Path.Combine(serverDir, serverYears[i]), Path.Combine(currentDir, serverYears[i]));
            }
        }
        //void Synchronize
        internal void ServerDirectoryUpdate()
        {
            status = new ProgressStatus(MainWindow.mainWindow.pbarStatus,MainWindow.mainWindow.lStatus);
            
            SynchronizeYears(serverDir, currentDir);

            MainWindow.mainWindow.MainWindowLoad(true);
            //сделать лок и ожидание

            status.Status("");
            status.Value(status.Min());
            status.Visible();
        }

        public Updater(string serverDir, string currentDir)
        {
            this.serverDir = serverDir;
            this.currentDir = currentDir;

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
