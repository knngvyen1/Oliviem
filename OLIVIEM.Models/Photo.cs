using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Models
{
    public class Photo
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public int Sort { get; set; }

        public Photo() { }

        public Photo(string name, string path, int sort)
        {
            this.Name = name;
            this.Path = path;
            this.Sort = sort;
        }

        public Photo(int id, string name, string path, int sort)
        {
            this.ID = id;
            this.Name = name;
            this.Path = path;
            this.Sort = sort;
        }
    }
}
