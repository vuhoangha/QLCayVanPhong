using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoaLuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //using (Image image = Image.FromFile("10-dithering-opt.jpg"))
            //{
            //    using (MemoryStream m = new MemoryStream())
            //    {
            //        image.Save(m, image.RawFormat);
            //        byte[] imageBytes = m.ToArray();

            //        // Convert byte[] to Base64 String
            //        string base64String = Convert.ToBase64String(imageBytes);

            //        var b = Convert.FromBase64String(base64String);
            //        using (var mem = new MemoryStream(b))
            //        {
            //            pictureBox1.Image = Image.FromStream(mem);
            //        }

            //    }
            //}

        }
    }
}
