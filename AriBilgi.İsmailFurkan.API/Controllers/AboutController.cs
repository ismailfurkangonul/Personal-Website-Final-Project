using AriBilgi.IsmailFurkan.Data.Concrete;
using AriBilgi.IsmailFurkan.Entities.Dtos;
using AriBilgi.IsmailFurkan.Service.Concrete;
using AriBilgi.IsmailFurkan.Shared.Result;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AriBilgi.IsmailFurkan.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class AboutController : ControllerBase
    {
        AboutManager aboutManager;
        public AboutController()
        {
            aboutManager = new AboutManager(new UnitOfWork());
        }

        [HttpPost]
        [Route("AboutAdd")]
        public Result AboutAdd(AboutAddDto aboutAddDto)
        {
            return aboutManager.Add(aboutAddDto);
        }

        [HttpPost]
        [Route("AboutGet")]
        public DataResult<AboutDto> AboutGet(AboutGetDto aboutGetDto)
        {
            return aboutManager.Get(aboutGetDto);
        }

        [HttpPost]
        [Route("AboutGetList")]
        public DataResult<List<AboutDto>> AboutGetList()
        {
            return aboutManager.GetAll();
        }

        [HttpPost]
        [Route("AboutRemove")]
        public Result AboutRemove(AboutRemoveDto aboutRemoveDto)
        {
            return aboutManager.Remove(aboutRemoveDto);
        }

        [HttpPost]
        [Route("AboutUpdate")]
        public Result AboutUpdate(AboutUpdateDto aboutUpdateDto)
        {
            return aboutManager.Update(aboutUpdateDto);
        }
    }
}
