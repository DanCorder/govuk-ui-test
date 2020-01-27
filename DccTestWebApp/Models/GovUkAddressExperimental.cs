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
        [GovUkAdditionalMetadataValue(GovUkMandatoryIntBinder.NameAtStartOfSentenceKey, "Test mandatory int")]
        [GovUkAdditionalMetadataValue(GovUkMandatoryIntBinder.NameWithinSentenceKey, "test mandatory int")]
        //[ModelBinder(typeof(GovUkMandatoryIntBinder), Name = "qq:DCC name")] // Doesn't work because we need the correct name to get the submitted value from the context
        //[GovUkDisplayNameForErrors(NameAtStartOfSentence = "Test mandatory int", NameWithinSentence = "test mandatory int")]
        //[ModelBinderWithParameters(typeof(GovUkMandatoryIntBinder), "Test mandatory int", "test mandatory int")]
        public int MandatoryInt { get; set; }
        
        public int? ID { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
}
