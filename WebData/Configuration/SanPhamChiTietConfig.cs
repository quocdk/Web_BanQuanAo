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
    public class SanPhamChiTietConfig : IEntityTypeConfiguration<SanPhamChiTiet>
    {
        public void Configure(EntityTypeBuilder<SanPhamChiTiet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.SanPham).WithMany(x => x.SanPhamChiTiets).HasForeignKey(x => x.IdSanPham);
            builder.HasOne(x => x.MauSac).WithMany(x => x.SanPhamChiTiets).HasForeignKey(x => x.IdMauSac);
            builder.HasOne(x => x.Size).WithMany(x => x.SanPhamChiTiets).HasForeignKey(x => x.IdSize);
        }
    }
}
