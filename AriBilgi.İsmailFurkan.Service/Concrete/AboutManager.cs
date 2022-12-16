using AriBilgi.IsmailFurkan.Data.Abstract;
using AriBilgi.IsmailFurkan.Entities.Concrete;
using AriBilgi.IsmailFurkan.Entities.Dtos;
using AriBilgi.IsmailFurkan.Service.Abstract;
using AriBilgi.IsmailFurkan.Shared.Result;
using System;
using System.Collections.Generic;

namespace AriBilgi.IsmailFurkan.Service.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AboutManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Result Add(AboutAddDto aboutAddDto)
        {
            try
            {
                _unitOfWork.Abouts.AddAsync(new About
                {
                    Name = aboutAddDto.Name,
                    Explain = aboutAddDto.Explain,
                    Job= aboutAddDto.Job,   
                    Social= aboutAddDto.Social,
                    Image= aboutAddDto.Image
                   
                });
                _unitOfWork.SaveAsync();

                return new Result(200, new List<string> { "Hakkımda bilgileri başarıyla eklenmiştir" });
            }
            catch (Exception ex)
            {
                return new Result(500, new List<string> { "Hakkımda eklenirken sistemsel bir hata oluştu." }, ex);
            }
        }

        public Result Update(AboutUpdateDto aboutUpdateDto)
        {

            try
            {
                var about = _unitOfWork.Abouts.GetAsync(a => a.Id == aboutUpdateDto.Id);
                if (about != null)
                {
                    about.Id = aboutUpdateDto.Id;
                    about.Name = aboutUpdateDto.Name;
                    about.Explain = aboutUpdateDto.Explain;
                    about.Job = aboutUpdateDto.Job;
                    about.Social = aboutUpdateDto.Social;
                    about.Image = aboutUpdateDto.Image; 
                   

                    _unitOfWork.Abouts.UpdateAsync(about);
                    _unitOfWork.SaveAsync();

                    return new Result(200, new List<string> { "hakkımda başarıyla güncellenmiştir." });
                }
                return new Result(200, new List<string> { "Güncellemek istediğiniz bilgiler bulunumadı." });
            }
            catch (Exception ex)
            {

                return new Result(500, new List<string> { "Teknik bir sorun oluştu." }, ex);
            }

        }

        public Result Remove(AboutRemoveDto aboutRemoveDto)
        {
            try
            {
                var about = _unitOfWork.Abouts.GetAsync(a => a.Id == aboutRemoveDto.Id);
                if (about != null)
                {
                    _unitOfWork.Abouts.HardDeleteAsync(about);
                    _unitOfWork.SaveAsync();

                    return new Result(200, new List<string> { "Hakkımda başarıyla silinmiştir." });
                }
                return new Result(200, new List<string> { "Silmek istediğiniz bilgiler bulunumadı." });
            }
            catch (Exception ex)
            {

                return new Result(500, new List<string> { "Teknik bir sorun oluştu." }, ex);
            }
        }
        


        public DataResult<List<AboutDto>> GetAll()
        {
            try
            {
                List<About> about = _unitOfWork.Abouts.GetAllAsync();

                List<AboutDto> abouts = new();

                foreach (var item in about)
                {
                    abouts.Add(new AboutDto
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Explain = item.Explain,
                        Job= item.Job,  
                        Social= item.Social,
                        Image= item.Image
                       
                    });
                }



                return new DataResult<List<AboutDto>>(200, abouts, null);

            }
            catch (Exception ex)
            {

                return new DataResult<List<AboutDto>>(200, null, new List<string>() { "Teknik bir hata oluştu." }, ex);
            }

        }

        public DataResult<AboutDto> Get(AboutGetDto aboutGetDto)
        {
            try
            {
                About about = _unitOfWork.Abouts.GetAsync(x => x.Id == aboutGetDto.Id);

                AboutDto aboutDto = new()
                {
                    Id = aboutGetDto.Id,
                    Name = about.Name,
                    Explain = about.Explain,
                    Job= about.Job, 
                    Social= about.Social,
                    Image= about.Image
                   
                };

                return new DataResult<AboutDto>(200, aboutDto, null);

            }
            catch (Exception ex)
            {

                return new DataResult<AboutDto>(200, null, new List<string>() { "Teknik bir hata oluştu." }, ex);
            }
        }
    }
}
