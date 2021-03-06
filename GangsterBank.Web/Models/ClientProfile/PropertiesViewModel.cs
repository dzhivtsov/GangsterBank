﻿namespace GangsterBank.Web.Models.ClientProfile
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using GangsterBank.Web.Infrastructure.ValidatonAttributes;
    using GangsterBank.Web.Infrastructure.Validators;

    public class PropertiesViewModel
    {
        [Required]
        [Positive]
        [HiddenInput(DisplayValue = false)]
        public int ClientId { get; set; }

        public IEnumerable<PropertyViewModel> Properties { get; set; }
    }
}