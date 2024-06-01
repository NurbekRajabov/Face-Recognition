using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Face_Recognition
{
    public class FaceInfo
    {
        public string Name { get; set; }
        public Image<Gray, byte> GrayImage { get; set; }
        public DateTime SavedDate { get; set; }
    }
}
