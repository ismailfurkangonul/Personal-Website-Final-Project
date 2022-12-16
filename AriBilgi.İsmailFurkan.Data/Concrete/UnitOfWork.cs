using AriBilgi.IsmailFurkan.Data.Abstract;
using AriBilgi.IsmailFurkan.Data.Concrete.EntityFramework.Contexts;
using AriBilgi.IsmailFurkan.Data.Concrete.EntityFramework.Repository;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IsmailFurkanContext _context;
        private readonly AboutRepository _aboutRepository;
        private readonly CertificatesRepository _certificatesRepository;
        private readonly EducationRepository _educationRepository;
       

        public UnitOfWork()
        {
            _context = new IsmailFurkanContext();
        }

       

        public IAboutRepository Abouts => _aboutRepository ?? new AboutRepository(_context);


        public ICertificatesRepository Certificatess => _certificatesRepository ?? new CertificatesRepository(_context);

        public IEducationRepository Educations => _educationRepository ?? new EducationRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
