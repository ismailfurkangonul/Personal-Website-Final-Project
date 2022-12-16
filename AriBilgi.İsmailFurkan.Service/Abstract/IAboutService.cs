using AriBilgi.IsmailFurkan.Entities.Dtos;
using AriBilgi.IsmailFurkan.Shared.Result;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AriBilgi.IsmailFurkan.Service.Abstract
{
    public interface IAboutService
    {
        Result Add(AboutAddDto aboutAddDto);
        Result Update(AboutUpdateDto aboutUpdateDto);
        Result Remove(AboutRemoveDto aboutRemoveDto);
        DataResult<AboutDto> Get(AboutGetDto aboutGetDto);

        DataResult<List<AboutDto>> GetAll();

    }
}
