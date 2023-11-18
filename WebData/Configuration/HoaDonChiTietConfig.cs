using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebData.Models;

namespace WebData.Configuration
{
    public class HoaDonChiTietConfig : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.HasKey(x => x.IdHoaDon);
            builder.HasKey(x => x.IdSanPhamChiTiet);
            builder.HasOne(x => x.HoaDon).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.IdHoaDon);
            builder.HasOne(x => x.SanPhamChiTiet).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.IdSanPhamChiTiet);
        }
    }
}
