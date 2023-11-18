using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class Size
    {
        public Guid Id { get; set; }
        public string TenSize { get; set; }
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }

    }
}
