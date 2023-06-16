using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace FridayPresentationManager
{
    internal class Presentation
    {
        string path;
        string name;

        bool exist=false;

        PictureBox marker;
        //=========================================================================
        private void SetPresentationMarker(string imageName)
        {
            Gui.SetPicture((this.marker), (Image)Properties.Resources.ResourceManager.GetObject(imageName));
        }
        //=========================================================================
        public string Path() { return this.path; }
        public void Path(string name) 
        {
            this.path = System.IO.Path.Combine(Consts.configKeysName_presentationFolder, name, Consts.presentationEXTs[0]);
            if (File.Exists(this.path)) { this.exist = true; }
        }
        public string Name() { return this.name; }
        public void Name(string name) { this.name = name; }
        public void SetMarker(string mode) 
        { 
            switch(mode)
            {
                case "ok":break;
                case "err":break;
                case "cur":break;
            }
        }
        //public void Marker(PictureBox pictureBox) { this.marker = pictureBox; }
        //=========================================================================
        public Presentation(string name, PictureBox marker) 
        {
            this.Name(name);
            this.Path(name);

            this.marker = marker;

            this.SetPresentationMarker(Consts.imagesErrorPhoto);
        }

        /*public Presentation(string path, PictureBox marker) : this(path)
        {
            this.marker = marker;
        }*/
    }
}
