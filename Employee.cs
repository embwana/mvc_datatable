using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DatatableCRUD.Models.Extended
{  
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {

    }
    public class EmployeeMetadata
    {
        [Required (AllowEmptyStrings = false,ErrorMessage ="Please provide first name")]
        public string Firstname { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide last name")]
        public string Lirstname { get; set; }
    }
}