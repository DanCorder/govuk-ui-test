using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using GovUkDesignSystem.ModelBinders;
using GovUkDesignSystem.Validators;
using Microsoft.AspNetCore.Mvc;
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
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Test mandatory int", NameWithinSentence = "test mandatory int")]
        public int MandatoryInt { get; set; }
        
        public int? ID { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
}
