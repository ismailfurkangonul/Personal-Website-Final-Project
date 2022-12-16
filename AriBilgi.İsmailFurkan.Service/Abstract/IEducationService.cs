using AriBilgi.IsmailFurkan.Entities.Dtos;
using AriBilgi.IsmailFurkan.Shared.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Service.Abstract
{
    public interface IEducationService
    {
        Result Add(EducationAddDto educationAddDto);
        Result Update(EducationUpdateDto educationUpdateDto);
        Result Remove(EducationRemoveDto educationRemoveDto);
        DataResult<EducationDto> Get(EducationGetDto educationGetDto);

        DataResult<List<EducationDto>> GetAll();
    }
}
