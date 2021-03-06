﻿using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.Attributes.DataBinding;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using GovUkDesignSystem.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DccTestWebApp.Models
{
    public enum RadioButtonValues
    {
        [GovUkRadioCheckboxLabelText(Text = "Value 1")]
        radioValue1,

        [GovUkRadioCheckboxLabelText(Text = "Value 2")]
        radioValue2,

        [GovUkRadioCheckboxLabelText(Text = "Value 3")]
        radioValue3
    }

    public enum CheckboxValues
    {
        [GovUkRadioCheckboxLabelText(Text = "Value 1")]
        checkboxValue1,

        [GovUkRadioCheckboxLabelText(Text = "Value 2")]
        checkboxValue2,

        [GovUkRadioCheckboxLabelText(Text = "Value 3")]
        checkboxValue3,

        [GovUkRadioCheckboxLabelText(Text = "Value 4")]
        checkboxValue4,

        [GovUkRadioCheckboxLabelText(Text = "Value 5")]
        checkboxValue5
    }

    public class GovUkAddressExperimental
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDataBindingMandatoryIntErrorText("Enter a binder validated int", "Binder validated int")]
        public int? BinderValidatedInt { get; set; }

        [ModelBinder(typeof(GovUkOptionalIntBinder))]
        [GovUkDataBindingOptionalIntErrorText("Binder validated optional int")]
        public int? BinderValidatedOptionalInt { get; set; }

        [ModelBinder(typeof(GovUkOptionalIntBinder))]
        [GovUkDataBindingOptionalIntErrorText("Binder validated optional int without UI")]
        public int? BinderValidatedOptionalIntWithoutUI { get; set; }

        [GovUkValidateRequired(ErrorMessageIfMissing = "Enter a binder validated string")]
        public string BinderValidatedString { get; set; }

        [GovUkValidateRequired(ErrorMessageIfMissing = "Enter a binder validated text area string")]
        public string BinderValidatedTextArea { get; set; }

        [GovUkValidateRequired(ErrorMessageIfMissing = "Select a binder validated radio option")]
        public RadioButtonValues? BinderValidatedRadio { get; set; }

        [GovUkValidateCheckboxNumberOfResponsesRange(MinimumSelected = 2, MaximumSelected = 4, PropertyNameForErrorMessage = "binder validated checkbox values")]
        public List<CheckboxValues> BinderValidatedCheckboxes { get; set; } = new List<CheckboxValues>();

        [GovUkValidateCharacterCount(MaxCharacters = 20, NameAtStartOfSentence = "Binder counted string", NameWithinSentence = "binder counted string")]
        public string BinderCountedString { get; set; }

        [GovUkValidateRequired]
        public DccAddressChild Child { get; set; } = new DccAddressChild();
    }

    public class DccAddressChild
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDataBindingMandatoryIntErrorText("Enter a child int", "Child int")]
        public int? ChildInt { get; set; }

        [ModelBinder(typeof(GovUkOptionalIntBinder))]
        [GovUkDataBindingOptionalIntErrorText("Child optional int")]
        public int? ChildOptionalInt { get; set; }

        [GovUkValidateRequired(ErrorMessageIfMissing = "Enter a child string")]
        public string ChildString { get; set; }

        [GovUkValidateRequired(ErrorMessageIfMissing = "Enter a child text area string")]
        public string ChildTextArea { get; set; }

        [GovUkValidateCheckboxNumberOfResponsesRange(MinimumSelected = 2, MaximumSelected = 4, PropertyNameForErrorMessage = "child checkbox values")]
        public List<CheckboxValues> ChildCheckboxes { get; set; } = new List<CheckboxValues>();

        [GovUkValidateRequired(ErrorMessageIfMissing = "Select a child radio option")]
        public RadioButtonValues? ChildValidatedRadio { get; set; }

        [GovUkValidateCharacterCount(MaxCharacters = 20, IsRequired = true, NameAtStartOfSentence = "Child counted string", NameWithinSentence = "child counted string")]
        public string ChildCountedString { get; set; }
    }
}
