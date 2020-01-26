using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using GovUkDesignSystem.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccTestWebApp.Models
{
    public class GovUkAddressExperimental : GovUkViewModel //qq:DCC remove inheritance
    {
        [GovUkIntegerValidator]
        [GovUkIntegerValidator2]
        public int MandatoryInt { get; set; }
        
        public int? ID { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
}
