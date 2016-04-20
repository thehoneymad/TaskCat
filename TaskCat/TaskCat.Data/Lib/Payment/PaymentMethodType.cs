﻿namespace TaskCat.Data.Lib.Payment
{
    /// <summary>
    /// Represents a payment method type
    /// </summary>
    public enum PaymentMethodType
    {
        /// <summary>
        /// All payment information is entered on the site
        /// </summary>
        Standard = 10,
        /// <summary>
        /// A customer is redirected to a third-party site in order to complete the payment
        /// </summary>
        Redirection = 15,
        /// <summary>
        /// Third-party button, like pay with *something*
        /// </summary>
        Button = 20,
    }
}

