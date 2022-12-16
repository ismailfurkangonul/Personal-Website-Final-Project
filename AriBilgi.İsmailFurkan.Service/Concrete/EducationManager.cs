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
    public class EducationManager:IEducationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EducationManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Result Add(EducationAddDto educationAddDto)
        {
            try
            {
                _unitOfWork.Educations.AddAsync(new Education
                {
                    Title = educationAddDto.Title,
                    Schoolname1 = educationAddDto.Schoolname1,
                    Schoolsubtitle1 = educationAddDto.Schoolsubtitle1,
                    Schoolname2 = educationAddDto.Schoolname2,
                    Schoolsubtitle2= educationAddDto.Schoolsubtitle2,
                    Image=educationAddDto.Image,
                    Image1= educationAddDto.Image1
                });
                _unitOfWork.SaveAsync();

                return new Result(200, new List<string> { "Eğitim bilgileri başarıyla eklenmiştir" });
            }
            catch (Exception ex)
            {
                return new Result(500, new List<string> { "Eğitim eklenirken sistemsel bir hata oluştu." }, ex);
            }
        }

        public DataResult<EducationDto> Get(EducationGetDto educationGetDto)
        {
            try
            {
                Education education = _unitOfWork.Educations.GetAsync(e => e.Id == educationGetDto.Id);

                EducationDto educationDto = new()
                {
                    Id = educationGetDto.Id,
                    Title = education.Title,
                    Schoolname1 = education.Schoolname1,
                    Schoolsubtitle1 = education.Schoolsubtitle1,
                    Schoolname2 = education.Schoolname2,
                    Schoolsubtitle2= education.Schoolsubtitle2,
                    Image=education.Image,
                    Image1=education.Image1 
                };

                return new DataResult<EducationDto>(200, educationDto, null);

            }
            catch (Exception ex)
            {

                return new DataResult<EducationDto>(200, null, new List<string>() { "Teknik bir hata oluştu." }, ex);
            }
        }

        public DataResult<List<EducationDto>> GetAll()
        {
            try
            {
                List<Education> education = _unitOfWork.Educations.GetAllAsync();

                List<EducationDto> educations = new();

                foreach (var item in education)
                {
                    educations.Add(new EducationDto
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Schoolname1 = item.Schoolname1,
                        Schoolsubtitle1 = item.Schoolsubtitle1,
                        Schoolname2 = item.Schoolname2,
                        Schoolsubtitle2= item.Schoolsubtitle2,
                        Image = item.Image,
                        Image1= item.Image1 
                    });
                }



                return new DataResult<List<EducationDto>>(200, educations, null);

            }
            catch (Exception ex)
            {

                return new DataResult<List<EducationDto>>(200, null, new List<string>() { "Teknik bir hata oluştu." }, ex);
            }
        }

        public Result Remove(EducationRemoveDto educationRemoveDto)
        {
            try
            {
                var education = _unitOfWork.Educations.GetAsync(e => e.Id == educationRemoveDto.Id);
                if (education != null)
                {
                    _unitOfWork.Educations.HardDeleteAsync(education);
                    _unitOfWork.SaveAsync();

                    return new Result(200, new List<string> { "Eğitim bilgileri başarıyla silinmiştir." });
                }
                return new Result(200, new List<string> { "Silmek istediğiniz bilgiler bulunumadı." });
            }
            catch (Exception ex)
            {

                return new Result(500, new List<string> { "Teknik bir sorun oluştu." }, ex);
            }
        }

        public Result Update(EducationUpdateDto educationUpdateDto)
        {
            try
            {
                var education = _unitOfWork.Educations.GetAsync(e => e.Id == educationUpdateDto.Id);
                if (education != null)
                {
                    education.Id = educationUpdateDto.Id;
                    education.Title = educationUpdateDto.Title;
                    education.Schoolname1 = educationUpdateDto.Schoolname1;
                    education.Schoolsubtitle1 = educationUpdateDto.Schoolsubtitle1;
                    education.Schoolname2 = educationUpdateDto.Schoolname2;
                    education.Schoolsubtitle2 = educationUpdateDto.Schoolsubtitle2;
                    education.Image= educationUpdateDto.Image;  
                    education.Image1 = educationUpdateDto.Image1;   



                    _unitOfWork.Educations.UpdateAsync(education);
                    _unitOfWork.SaveAsync();

                    return new Result(200, new List<string> { "Eğitim bilgileri başarıyla güncellenmiştir." });
                }
                return new Result(200, new List<string> { "Güncellemek istediğiniz bilgiler bulunumadı." });
            }
            catch (Exception ex)
            {

                return new Result(500, new List<string> { "Teknik bir sorun oluştu." }, ex);
            }
        }
    }
}
