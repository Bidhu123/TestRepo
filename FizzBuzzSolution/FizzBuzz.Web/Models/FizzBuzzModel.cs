using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FizzBuzz.Web.Models
{
    public class FizzBuzzModel
    {
    [Required(ErrorMessage = "Number is required.")]
    [RegularExpression("([0-9]+)", ErrorMessage = "Please Enter Valid Number")]    
    [Range(1,1000, ErrorMessage = "Not allowed to enter number greater than 1000 and less than 1")]
    public int Number { get; set; }

    public int PageSize { get; set; }
    public List<string> NumberList { get; set; }

    }
}