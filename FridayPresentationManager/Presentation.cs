using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using FridayPresentationManager.Properties;

namespace FridayPresentationManager
{
    public class Presentation
    {
        string presentationPath;
        string name;
        string currentStatus;

        bool exist=false;
        bool defaultMarkers = true;

        PictureBox marker;
        //=========================================================================
        private void SetPresentationMarkerImage(string imageName)
        {
            if (this.defaultMarkers) { Gui.SetPicture(this.marker, (Image)Resources.ResourceManager.GetObject(imageName)); }
            else { Gui.SetPicture(this.marker, Image.FromFile(GetMarkerPath(Consts.imagesDefaultPath, imageName) )); }
        }
        private string GetMarkerPath(string markerPath,string markerName) { return Path.Combine(markerPath, markerName, Consts.imagesEXT); }
        private string GetPresentationPath(string folder,string name) { return Path.Combine(folder, name + Consts.presentationEXTs[0]); }
        //=========================================================================
        public string PresentationPath() { return this.presentationPath; }
        public void PresentationPath(string path) 
        {
            this.presentationPath = path;
            if (File.Exists(this.presentationPath)) { this.exist = true; }
        }
        public string Name() { return this.name; }
        public void Name(string name) { this.name = name; }
        public void StatusDraw() 
        {
            string marker = "";
            if (this.Status().Equals(Consts._presentationStatusERR)) { marker = Consts.imagesErrorPhoto; }
            else if (this.Status().Equals(Consts._presentationStatusOK)) { marker = Consts.imagesOKPhoto; }
            else if (this.Status().Equals(Consts._presentationStatusCUR)) { marker = Consts.imagesCurrentPhoto; }

            if (File.Exists(GetMarkerPath(Consts.imagesDefaultPath, marker))) { this.defaultMarkers = false; }
            
            this.SetPresentationMarkerImage(marker);
        }
        public void Status(string status) { this.currentStatus = status; }
        public string Status() { return this.currentStatus; }
        public void Marker(PictureBox marker) { this.marker = marker; }
        //=========================================================================
        public Presentation(string folder, string name, PictureBox marker) 
        {
            this.Name(name);
            this.PresentationPath(this.GetPresentationPath(folder,name));
            this.Marker(marker);

            if (this.exist) { this.Status(Consts._presentationStatusOK); }
            else { this.Status(Consts._presentationStatusERR); }
            this.StatusDraw();
        }
    }
}
