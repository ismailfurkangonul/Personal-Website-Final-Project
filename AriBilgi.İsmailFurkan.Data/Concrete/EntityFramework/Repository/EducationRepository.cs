using AriBilgi.IsmailFurkan.Data.Abstract;
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
    public class EducationRepository : Repository<Education>, IEducationRepository
    {
        public EducationRepository(DbContext context):base(context)
        {

        }
    }
}
