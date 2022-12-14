using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

#nullable disable

namespace EHSApi.Models
{
    public partial class Seller
    {
        public Seller()
        {
            Properties = new HashSet<Property>();
        }

        public int SellerId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public string PhoneNo { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string EmailId { get; set; }
        [JsonIgnore]

        public virtual ICollection<Property> Properties { get; set; }
    }
}
