using System.ComponentModel.DataAnnotations;

namespace AngularRestApi.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}