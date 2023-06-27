using System.Windows.Forms;
using System.IO;
using System.Drawing;
using FridayPresentationManager.Properties;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace FridayPresentationManager
{
    public class Presentation
    {
        string presentationPath;
        internal string name { get; set; }
        string currentStatus;

        bool exist { get; set; } = false;
        bool defaultMarkers { get; set; } = true;

        PictureBox marker { get; set; }
        PowerPoint.Presentation presentation { get; set; }
        //=========================================================================
        private void StatusDraw()
        {
            string marker = "";
            if (this.CurrentStatus.Equals(Consts._presentationStatusERR)) { marker = Consts.imagesErrorPhoto; }
            else if (this.CurrentStatus.Equals(Consts._presentationStatusOK)) { marker = Consts.imagesOKPhoto; }
            else if (this.CurrentStatus.Equals(Consts._presentationStatusCUR)) { marker = Consts.imagesCurrentPhoto; }

            if (File.Exists(GetMarkerPath(Consts.imagesDefaultPath, marker))) { this.defaultMarkers = false; }

            this.SetPresentationMarkerImage(marker);
        }
        private void SetPresentationMarkerImage(string imageName)
        {
            Image image;
            if (this.defaultMarkers) { image= (Image)Resources.ResourceManager.GetObject(imageName); }
            else { image= Image.FromFile(GetMarkerPath(Consts.imagesDefaultPath, imageName)); }

            Gui.SetPicture(this.marker, image);
        }
        private string GetMarkerPath(string markerPath,string markerName) { return Path.Combine(markerPath, markerName, Consts.imagesEXT); }
        private string GetPresentationPath(string folder,string name) { return Path.Combine(folder, name + Consts.presentationEXTs[0]); }
        private void OpenPresentation()
        {
            PowerPoint.Application objApp = new PowerPoint.Application();
            PowerPoint.Presentations objPresSet = objApp.Presentations;
            this.presentation = objPresSet.Open(this.PresentationPath);
        }
        //=========================================================================
        public string CurrentStatus
        {
            get { return this.currentStatus; }
            set
            {
                this.currentStatus = value;
                this.StatusDraw();
            }
        }
        public string PresentationPath
        {
            get { return this.presentationPath; }
            set 
            {
                this.presentationPath = value;
                if (File.Exists(this.PresentationPath)) { this.exist = true; }
            }
        }
        
        public void Open(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.CurrentStatus = Consts._presentationStatusCUR;
                this.OpenPresentation();
                this.presentation.SlideShowSettings.Run();
            }
        }
        //=========================================================================
        public Presentation(string folder, string name, PictureBox marker) 
        {
            this.name=name;
            this.PresentationPath=this.GetPresentationPath(folder,name);
            this.marker=marker;

            if (this.exist) { this.CurrentStatus = Consts._presentationStatusOK; }
            else { this.CurrentStatus = Consts._presentationStatusERR; }
            
        }
        ~Presentation()
        {
            this.presentation=null;
            this.presentationPath=null;
            this.marker = null;
            this.exist = false;
            this.defaultMarkers = false;
            this.name = null;
            this.currentStatus = null;
        }
    }
}
