using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WebData.Models;

namespace WebData.Configuration
{
    public class GioHangChiTietConfig : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.HasKey(x => x.IdGioHang);
            builder.HasKey(x => x.IdSanPhamChiTiet);
            builder.HasOne(x=>x.GioHang).WithMany(x=>x.GioHangChiTiets).HasForeignKey(x=>x.IdGioHang);
            builder.HasOne(x=>x.SanPhamChiTiet).WithMany(x=>x.GioHangChiTiets).HasForeignKey(x=>x.IdSanPhamChiTiet);
        }
    }
}
