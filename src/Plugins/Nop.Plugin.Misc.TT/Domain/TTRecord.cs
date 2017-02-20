using Nop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.TT.Domain
{
    public class TTRecord : BaseEntity
    {
        public virtual int TTId { get; set; }

        public virtual int ProductId { get; set; }
        public virtual string CustomName { get; set; }
    }
}
