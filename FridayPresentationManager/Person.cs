using iniFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayPresentationManager
{
    internal class Person
    {
        string fio;
        string photoPath;

        bool defaultPhoto = false;
        //=========================================================================
        public Person(string fio, string photoPath)
        {
            this.FIO(fio);
            this.PhotoPath(GetPhotoPath(photoPath));
        }
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
        private string GetPhotoPath(string photoPath) { return Path.Combine(photoPath, this.fio, Consts.imagesEXT); }
    }
}
