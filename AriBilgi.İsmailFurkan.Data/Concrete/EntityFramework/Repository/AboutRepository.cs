using AriBilgi.IsmailFurkan.Data.Abstract;
using AriBilgi.IsmailFurkan.Data.Concrete.EntityFramework.Contexts;
using AriBilgi.IsmailFurkan.Entities.Concrete;
using AriBilgi.IsmailFurkan.Shared.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Data.Concrete.EntityFramework.Repository
{
    public class AboutRepository : Repository<About>, IAboutRepository
    {
        public AboutRepository(DbContext context) : base(context)
        {
            
        }

        
    }
}
