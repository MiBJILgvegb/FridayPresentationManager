using System.IO;
using System.Windows.Forms;
using System.Drawing;
using FridayPresentationManager.Properties;

namespace FridayPresentationManager
{
    public class Person
    {
        public string fio { get; set; }
        private string photoPath;
        public string title { get; set; }

        bool _defaultPhoto { get; set; } = false;
        public Image photo;
        //=========================================================================
        private string GetPhotoPath(string photoPath) { return Path.Combine(photoPath, this.fio + Consts.imagesEXT); }
        private Image CreatePhoto()
        {
            if(this._defaultPhoto){ return (Image)Resources.ResourceManager.GetObject(this.photoPath); }
            else { return Image.FromFile(this.photoPath); }
        }
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
        public Image Photo
        {
            get { return photo; }
            private set { photo = value; }
        }
        //=========================================================================
        public Person(string fio,string title, string photoPath)
        {
            this.fio = fio;
            this.title = title;
            this.PhotoPath = photoPath;
            this.Photo = CreatePhoto();
        }
        public void Destroy()
        {
            this.fio = "";
            this.title = "";
            this.PhotoPath = "";
            this.Photo = null;
        }
        public void DrawPhoto(PictureBox pictureBox){ Gui.SetPicture(pictureBox, this.Photo); }
    }
}
