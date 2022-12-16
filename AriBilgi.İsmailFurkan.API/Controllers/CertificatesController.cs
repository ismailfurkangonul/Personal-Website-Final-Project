using AriBilgi.IsmailFurkan.Data.Concrete;
using AriBilgi.IsmailFurkan.Entities.Dtos;
using AriBilgi.IsmailFurkan.Service.Concrete;
using AriBilgi.İsmailFurkan.Service.Concrete;
using AriBilgi.IsmailFurkan.Shared.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AriBilgi.İsmailFurkan.API.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        CertificatesManager certificatesManager;
        public CertificatesController()
        {
            certificatesManager = new CertificatesManager(new UnitOfWork());
        }

        [HttpPost]
        [Route("CertificatesAdd")]
        public Result CertificatesAdd(CertificatesAddDto certificatesAddDto)
        {
            return certificatesManager.Add(certificatesAddDto);
        }

        [HttpPost]
        [Route("CertificatesGet")]
        public DataResult<CertificatesDto> CertificatesGet(CertificatesGetDto certificatesGetDto)
        {
            return certificatesManager.Get(certificatesGetDto);
        }

        [HttpPost]
        [Route("CertificatesGetList")]
        public DataResult<List<CertificatesDto>> CertificatesGetList()
        {
            return certificatesManager.GetAll();
        }

        [HttpPost]
        [Route("CertificatesRemove")]
        public Result CertificatesRemove(CertificatesRemoveDto certificatesRemoveDto)
        {
            return certificatesManager.Remove(certificatesRemoveDto);
        }

        [HttpPost]
        [Route("CertificatesUpdate")]
        public Result CertificatesUpdate(CertificatesUpdateDto certificatesUpdateDto)
        {
            return certificatesManager.Update(certificatesUpdateDto);
        }
    }
}
