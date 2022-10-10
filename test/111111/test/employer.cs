using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2011064952_PhungVIetNguyen
{
    public class employer
    {
        [Key]
        public int id { get; set; }
        //ràng buộc độ dài ký tự

        public string name { get; set; }
        
        public string phone { get; set; }

        public string email { get; set; }

        public string diachi { get; set; }

        public string image { get; set; }

        public DateTime? ngaysinh { get; set; }
    }
}
