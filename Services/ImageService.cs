using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStation14_EventCardCreator.Services
{
    public static class ImageService
    {
        public static string WrapImage(string FileName) 
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Bitmap));
            return Convert.ToBase64String((byte[])converter.ConvertTo(new Bitmap(FileName), typeof(byte[])));
        }
        public static MemoryStream UnwrapImage(string CodeString) 
        {
            byte[] bytes = Convert.FromBase64String(CodeString);
            return new MemoryStream(bytes);
        }
        public static MemoryStream PutImage(Bitmap obj) 
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Bitmap));
            return new MemoryStream((byte[])converter.ConvertTo(obj, typeof(byte[])));
        }
    }
}
