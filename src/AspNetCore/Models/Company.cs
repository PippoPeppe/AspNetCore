using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public class Company : BaseEntity
    {
        [Display(Name = "Ragione Sociale")]
        public string Name { get; set; }
        [Display(Name = "Indirizzo")]
        public string Address { get; set; }
        [Display(Name = "Città")]
        public string City { get; set; }
        [Display(Name = "Stato")]
        public string Country { get; set; }
        [Display(Name = "CAP")]
        public string ZipCode { get; set; }
        [Display(Name = "Partita Iva")]
        public string VatNumber { get; set; }
        public string Email { get; set; }
        [Display(Name = "Telefono")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Cliente interno")]
        public bool IsInternal { get; set; }

        public Company()
        {
            IsInternal = false;
        }
    }
}
