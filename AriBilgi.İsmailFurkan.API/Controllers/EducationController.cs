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
    public class EducationController : ControllerBase
    {
       EducationManager educationManager;
        public EducationController()
        {
            educationManager = new EducationManager(new UnitOfWork());
        }

        [HttpPost]
        [Route("EducationAdd")]
        public Result EducationAdd(EducationAddDto educationAddDto)
        {
            return educationManager.Add(educationAddDto);
        }

        [HttpPost]
        [Route("EducationGet")]
        public DataResult<EducationDto> EducationGet(EducationGetDto educationGetDto)
        {
            return educationManager.Get(educationGetDto);
        }

        [HttpPost]
        [Route("EducationGetList")]
        public DataResult<List<EducationDto>> EducationGetList()
        {
            return educationManager.GetAll();
        }

        [HttpPost]
        [Route("EducationRemove")]
        public Result EducationRemove(EducationRemoveDto educationRemoveDto)
        {
            return educationManager.Remove(educationRemoveDto);
        }

        [HttpPost]
        [Route("EducationUpdate")]
        public Result EducationUpdate(EducationUpdateDto educationUpdateDto)
        {
            return educationManager.Update(educationUpdateDto);
        }
    }
}
