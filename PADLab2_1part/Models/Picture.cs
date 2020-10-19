using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PADLab2_1part.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public void Copy(Picture picture)
        {
            Name = picture.Name;
            Image = picture.Image;
            Author = picture.Author;
            Description = picture.Description;
        }

    }
}
