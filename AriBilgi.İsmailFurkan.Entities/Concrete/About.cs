using AriBilgi.IsmailFurkan.Entities.Concrete;
using AriBilgi.IsmailFurkan.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Entities.Concrete
{
    public class About : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Explain { get; set; }
        public string Job { get; set; }
        public string Social { get; set; }  
        public string Image { get; set; }
          

    }
}
