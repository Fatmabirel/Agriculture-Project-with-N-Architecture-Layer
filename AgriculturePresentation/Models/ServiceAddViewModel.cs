using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Başlık boş olamaz")]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama boş olamaz")]
        public string Description { get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel url boş olamaz")]
        public string Image { get; set; }
    }

}
