using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccTestWebApp.Models
{
    public class GovUkAddress : GovUkViewModel
    {
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Address ID", NameWithinSentence = "address ID")]
        [GovUkValidateRequired(ErrorMessageIfMissing = "Enter an ID")]
        public int? ID { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
}
