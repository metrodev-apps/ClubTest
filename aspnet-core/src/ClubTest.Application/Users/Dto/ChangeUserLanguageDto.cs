using System.ComponentModel.DataAnnotations;

namespace ClubTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}