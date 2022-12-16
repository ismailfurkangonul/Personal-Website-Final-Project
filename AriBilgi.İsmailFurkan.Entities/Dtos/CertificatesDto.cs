using AriBilgi.IsmailFurkan.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Entities.Dtos
{
    public class CertificatesDto
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Certificate1 { get; set; }
        public string Certificate2 { get; set; }
        public string Certificate3 { get; set; }
        public string Certificate4 { get; set; }
        public string Certificate5 { get; set; }
        public string Certificate6 { get; set; }
    }
}
