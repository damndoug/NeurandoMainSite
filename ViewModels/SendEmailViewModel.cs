using System.ComponentModel.DataAnnotations;

namespace Neurando.ViewModels
{
    public class SendEmailViewModel
    {
        [Required(ErrorMessage = "Well, the name is required!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "The email is required, sir!")]
        public string UserMail { get; set; }
        [Required(ErrorMessage = "Please, send a message to us!")]
        public string UserMessage { get; set; }
    }
}
