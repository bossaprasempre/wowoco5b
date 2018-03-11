using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecarouselGrid.Model
{
    public class Greetings //Name of the Model; collection of all the greetings users create
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Friend's Name")]
        [Display(Prompt = "Friend's Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string inputFriendName { get; set; }

        [DisplayName("Friend's Email")]
        [Display(Prompt = "Friend's Email")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string inputFriendEmail { get; set; }

        [DisplayName("Subject")]
        [Display(Prompt = "Subject")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string inputSubject { get; set; }

        [DisplayName("Message")]
        [Display(Prompt = "Message")]
        [Required(ErrorMessage = "Required")]
        [StringLength(240, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 240 characters")]
        public string inputTextarea { get; set; }

        [DisplayName("Sender's Name")]
        [Display(Prompt = "Sender's Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string inputSenderName { get; set; }

        [DisplayName("Sender's Email")]
        [Display(Prompt = "Sender's Email")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string inputSenderEmail { get; set; }

    }
}
