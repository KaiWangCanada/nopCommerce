using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nop.Plugin.Misc.TT.Domain;

namespace Nop.Plugin.Misc.TT.Data
{
    public class TTRecordMap : EntityTypeConfiguration<TTRecord>
    {
        public TTRecordMap()
        {
            ToTable("TT");
            HasKey(m => m.TTId);

            Property(m => m.ProductId);
            Property(m => m.CustomName);
        }
    }
}
