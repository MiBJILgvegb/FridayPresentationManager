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
        private string fio { get; set; }
        private string photoPath;

        bool _defaultPhoto { get; set; } = false;
        //=========================================================================
        public string PhotoPath
        {
            get { return photoPath; }
            set
            {
                this.photoPath = GetPhotoPath(value);
                if (!File.Exists(this.photoPath))
                {
                    this._defaultPhoto = true;
                    this.photoPath = Consts.imagesDefaultPhoto;
                }
            }
        }
        //=========================================================================
        private string GetPhotoPath(string photoPath) { return Path.Combine(photoPath, this.fio + Consts.imagesEXT); }
        //=========================================================================
        public Person(string fio, string photoPath)
        {
            this.fio = fio;
            this.photoPath = photoPath;
        }
        
        public void DrawPhoto(PictureBox pictureBox)
        {
            if (this._defaultPhoto) { Gui.SetPicture(pictureBox, (Image)Resources.ResourceManager.GetObject(this.photoPath)); }
            else { Gui.SetPicture(pictureBox, Image.FromFile(this.photoPath)); }
        }
    }
}
