using iniFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FridayPresentationManager.Properties;

namespace FridayPresentationManager
{
    public class Person
    {
        string fio;
        string photoPath;

        bool defaultPhoto = false;
        //=========================================================================
        private string GetPhotoPath(string photoPath) { return Path.Combine(photoPath, this.fio + Consts.imagesEXT); }
        //=========================================================================
        public string FIO() { return this.fio; }
        public void FIO(string fio) { this.fio = fio; }

        public string PhotoPath() { return this.photoPath; }
        public void PhotoPath(string photoPath)
        {
            this.photoPath = photoPath;
            if (!File.Exists(this.photoPath))
            {
                this.defaultPhoto = true;
                this.photoPath = Consts.imagesDefaultPhoto;
            }
        }
        //=========================================================================
        public Person(string fio, string photoPath)
        {
            this.FIO(fio);
            this.PhotoPath(GetPhotoPath(photoPath));
        }
        
        public void DrawPhoto(PictureBox pictureBox)
        {
            if (this.defaultPhoto) { Gui.SetPicture(pictureBox, (Image)Resources.ResourceManager.GetObject(this.photoPath)); }
            else { Gui.SetPicture(pictureBox, Image.FromFile(this.photoPath)); }
        }
    }
}
