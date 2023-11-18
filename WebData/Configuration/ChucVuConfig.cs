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
    public class ChucVuConfig : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
