using AriBilgi.IsmailFurkan.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AriBilgi.IsmailFurkan.Entities.Dtos
{
    public class EducationUpdateDto
    {

        public int Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Title { get; set; }

        [DisplayName("OkulAdı1")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string Schoolname1 { get; set; }
        [DisplayName("Altyazı1")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string Schoolsubtitle1 { get; set; }

        [DisplayName("OkulAdı2")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string Schoolname2 { get; set; }
        [DisplayName("Altyazı2")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string Schoolsubtitle2 { get; set; }
        public string Image { get; set; }
        public string Image1 { get; set; }


    }
}
