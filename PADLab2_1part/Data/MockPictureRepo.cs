using PADLab2_1part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PADLab2_1part.Data
{
    public class MockPictureRepo : IPictureRepo
    {
        static readonly List<Picture> pictures = new List<Picture>();
        
        public Picture CreatePicture(Picture picture)
        {
            pictures.Add(picture);
            Console.WriteLine(pictures);
            return picture;
        }

        public void Delete(int id)
        {
            pictures.RemoveAll(s=>s.Id == id);
        }

        public Picture GetPictureById(int id)
        {
            var picture = pictures.Where(s => s.Id == id);
            return picture.FirstOrDefault();
        }

        public IEnumerable<Picture> GetPictures()
        {
            return pictures;
        }

        public Picture Update(Picture picture)
        {
            var _picture = pictures.Where(s => s.Id == picture.Id).FirstOrDefault();
            _picture.Copy(picture);
            Console.WriteLine(pictures);
            return _picture;
        }
    }
}
