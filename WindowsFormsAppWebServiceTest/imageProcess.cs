using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWebServiceTest
{
    internal class imageProcess
    {
        public byte[] PhotoProcess(System.Drawing.Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms,ImageFormat.Png);
            var photo = ms.ToArray();
            return photo;

        }

        public Image PhotoBuilder(byte[] imageData)
        {
            var fs = new FileStream("image.bmp", FileMode.Create);
            fs.Write(imageData,0,imageData.Length);
            var image = Image.FromStream(fs);
            fs.Close();
            return image;
        }

        public Bitmap GetPhoto()
        {
            var open = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *bmp; *.png; *.jfif"
            };

            if(open.ShowDialog() == DialogResult.OK)
            {
                var image = new Bitmap(open.FileName);  
                return image;
            }
            return null;
        }
    }
}
