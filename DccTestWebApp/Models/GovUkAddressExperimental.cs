using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using GovUkDesignSystem.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DccTestWebApp.Models
{
    public class GovUkAddressExperimental : GovUkViewModel //qq:DCC remove inheritance
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Binder validated int", NameWithinSentence = "binder validated int")]
        public int? BinderValidatedInt { get; set; }

        [ModelBinder(typeof(GovUkMandatoryStringBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Binder validated string", NameWithinSentence = "binder validated string")]
        public string BinderValidatedString { get; set; }

        [GovUkValidateRequired(ErrorMessageIfMissing = "Enter a custom validated String")]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Custom validated string", NameWithinSentence = "custom validated string")]
        public string CustomValidatedString { get; set; }

        [Required]
        public DccAddressChild Child { get; set; } = new DccAddressChild();
    }

    public class DccAddressChild
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Child int", NameWithinSentence = "child int")]
        public int? ChildInt { get; set; }

        [ModelBinder(typeof(GovUkMandatoryStringBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Child string", NameWithinSentence = "child string")]
        public string ChildString { get; set; }
    }
}
