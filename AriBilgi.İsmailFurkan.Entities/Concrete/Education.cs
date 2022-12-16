using AriBilgi.IsmailFurkan.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Entities.Concrete
{
    public class Education : EntityBase, IEntity
    {

        public string Title { get; set; }
        public string Schoolname1 { get; set; }
        public string Schoolsubtitle1 { get; set; } 
        public string Schoolname2 { get; set; }
        public string Schoolsubtitle2 { get; set; }
        public string Image { get; set; }   
        public string Image1 { get; set; }
    }
}
