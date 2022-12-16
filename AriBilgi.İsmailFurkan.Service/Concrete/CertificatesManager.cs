using AriBilgi.IsmailFurkan.Data.Abstract;
using AriBilgi.IsmailFurkan.Entities.Concrete;
using AriBilgi.IsmailFurkan.Entities.Dtos;
using AriBilgi.IsmailFurkan.Service.Abstract;
using AriBilgi.IsmailFurkan.Shared.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.İsmailFurkan.Service.Concrete
{
    public class CertificatesManager : ICertificatesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CertificatesManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Result Add(CertificatesAddDto certificatesAddDto)
        {
            try
            {
                _unitOfWork.Certificatess.AddAsync(new Certificates
                {
                    Title = certificatesAddDto.Title,
                    Certificate1 = certificatesAddDto.Certificate1,
                    Certificate2 = certificatesAddDto.Certificate2,
                    Certificate3 = certificatesAddDto.Certificate3,
                    Certificate4 = certificatesAddDto.Certificate4,
                    Certificate5 = certificatesAddDto.Certificate5,
                    Certificate6 = certificatesAddDto.Certificate6

                });
                _unitOfWork.SaveAsync();

                return new Result(200, new List<string> { "Sertifika bilgileri başarıyla eklenmiştir" });
            }
            catch (Exception ex)
            {
                return new Result(500, new List<string> { "Sertifika eklenirken sistemsel bir hata oluştu." }, ex);
            }
        }

        public DataResult<CertificatesDto> Get(CertificatesGetDto certificatesGetDto)
        {
            try
            {
                Certificates certificates = _unitOfWork.Certificatess.GetAsync(c => c.Id == certificatesGetDto.Id);

                CertificatesDto certificatesDto = new()
                {
                    Id = certificatesGetDto.Id,
                    Certificate1 = certificates.Certificate1,
                    Certificate2 = certificates.Certificate2,
                    Certificate3 = certificates.Certificate3,
                    Certificate4 = certificates.Certificate4,
                    Certificate5 = certificates.Certificate5,
                    Certificate6 = certificates.Certificate6
                };

                return new DataResult<CertificatesDto>(200, certificatesDto, null);

            }
            catch (Exception ex)
            {

                return new DataResult<CertificatesDto>(200, null, new List<string>() { "Teknik bir hata oluştu." }, ex);
            }
        }

        public DataResult<List<CertificatesDto>> GetAll()
        {
            try
            {
                List<Certificates> certificates = _unitOfWork.Certificatess.GetAllAsync();

                List<CertificatesDto> certificatess = new();

                foreach (var item in certificates)
                {
                    certificatess.Add(new CertificatesDto
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Certificate1 = item.Certificate1,
                        Certificate2 = item.Certificate2,
                        Certificate3 = item.Certificate3,
                        Certificate4 = item.Certificate4,   
                        Certificate5 = item.Certificate5,   
                        Certificate6 = item.Certificate6
                    });
                }



                return new DataResult<List<CertificatesDto>>(200, certificatess, null);

            }
            catch (Exception ex)
            {

                return new DataResult<List<CertificatesDto>>(200, null, new List<string>() { "Teknik bir hata oluştu." }, ex);
            }
        }

        public Result Remove(CertificatesRemoveDto certificatesRemoveDto)
        {
            try
            {
                var certificates = _unitOfWork.Certificatess.GetAsync(c => c.Id == certificatesRemoveDto.Id);
                if (certificates != null)
                {
                    _unitOfWork.Certificatess.HardDeleteAsync(certificates);
                    _unitOfWork.SaveAsync();

                    return new Result(200, new List<string> { "Sertifika başarıyla silinmiştir." });
                }
                return new Result(200, new List<string> { "Silmek istediğiniz sertifika bulunamadı." });
            }
            catch (Exception ex)
            {

                return new Result(500, new List<string> { "Teknik bir sorun oluştu." }, ex);
            }
        }

        public Result Update(CertificatesUpdateDto certificatesUpdateDto)
        {
            try
            {
                var certificates = _unitOfWork.Certificatess.GetAsync(c => c.Id == certificatesUpdateDto.Id);
                if (certificates != null)
                {
                    certificates.Id = certificatesUpdateDto.Id;
                    certificates.Title = certificatesUpdateDto.Title;
                    certificates.Certificate1 = certificatesUpdateDto.Certificate1;
                    certificates.Certificate2 = certificatesUpdateDto.Certificate2;
                    certificates.Certificate3 = certificatesUpdateDto.Certificate3;
                    certificates.Certificate4 = certificatesUpdateDto.Certificate4;
                    certificates.Certificate5 = certificatesUpdateDto.Certificate5;
                    certificates.Certificate6 = certificatesUpdateDto.Certificate6;



                    _unitOfWork.Certificatess.UpdateAsync(certificates);
                    _unitOfWork.SaveAsync();

                    return new Result(200, new List<string> { "Sertifika başarıyla güncellenmiştir." });
                }
                return new Result(200, new List<string> { "Güncellemek istediğiniz sertifika bulunamadı." });
            }
            catch (Exception ex)
            {

                return new Result(500, new List<string> { "Teknik bir sorun oluştu." }, ex);
            }
        }
    }
}
