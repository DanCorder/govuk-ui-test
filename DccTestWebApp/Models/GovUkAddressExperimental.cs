using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DccTestWebApp.Models
{
    public class GovUkAddressExperimental : GovUkViewModel //qq:DCC remove inheritance
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Test mandatory int", NameWithinSentence = "test mandatory int")]
        public int MandatoryInt { get; set; }

        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "ID", NameWithinSentence = "ID")]
        public int? ID { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }

        [Required]
        public DccAddressChild Child { get; set; } = new DccAddressChild();
    }

    public class DccAddressChild
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Child int", NameWithinSentence = "child int")]
        public int? ChildInt { get; set; }
    }
}
