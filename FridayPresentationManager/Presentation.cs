using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridayPresentationManager
{
    internal class Presentation
    {
        string path;
        string name;

        //PictureBox marker;
        //=========================================================================
        //configKeysName_presentationFolder
        private void GetPresentationPath()
        {
            //return Path.Combine(this.path, this.name, Consts.presentationEXTs[0]);
        }
        //=========================================================================
        public string Path() { return this.path; }
        public void Path(string path) { this.path = path; }
        //public void Marker(PictureBox pictureBox) { this.marker = pictureBox; }
        //=========================================================================
        public Presentation(string path) { this.Path(path); }
        /*public Presentation(string path, PictureBox marker) : this(path)
        {
            this.marker = marker;
        }*/
    }
}
