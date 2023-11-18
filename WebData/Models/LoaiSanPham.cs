using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class LoaiSanPham
    {
        public Guid Id { get; set; }
        public string TenLoaiSanPham { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
