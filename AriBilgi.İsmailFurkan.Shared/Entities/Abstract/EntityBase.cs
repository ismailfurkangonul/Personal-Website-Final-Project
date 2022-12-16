using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Shared.Entities.Abstract
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        public int? CreatedBy { get; set; } = 1;
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
    }
}
