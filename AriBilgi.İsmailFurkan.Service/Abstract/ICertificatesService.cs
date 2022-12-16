using AriBilgi.IsmailFurkan.Entities.Dtos;
using AriBilgi.IsmailFurkan.Shared.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Service.Abstract
{
    public interface ICertificatesService
    {
        Result Add(CertificatesAddDto certificatesAddDto);
        Result Update(CertificatesUpdateDto certificatesUpdateDto);
        Result Remove(CertificatesRemoveDto certificatesRemoveDto);
        DataResult<CertificatesDto> Get(CertificatesGetDto certificatesGetDto);

        DataResult<List<CertificatesDto>> GetAll();
    }
}
