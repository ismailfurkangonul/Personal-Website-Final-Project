using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Data.Abstract
{
    public interface IUnitOfWork
    {
        IAboutRepository Abouts { get; }
       
        ICertificatesRepository Certificatess { get; }
        IEducationRepository Educations { get; }
      
        

        Task<int> SaveAsync();
    }
}
