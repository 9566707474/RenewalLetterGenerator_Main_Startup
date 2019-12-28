﻿namespace RenewalLatterGenerator.Features.Rules
{
    using RenewalLatterGenerator.Exceptions;
    using RenewalLatterGenerator.Models;

    /// <summary>
    /// Used to calculate the average monthly premium amount
    /// </summary>
    public class AverageMonthlyPremiumRule : IRule
    {
        /// <summary>
        /// Apply Average Monthly Premium Rule
        /// </summary>
        /// <param name="customerProduct">customer product</param>
        /// <returns>customer product</returns>
        public CustomerProduct Apply(CustomerProduct customerProduct)
        {
            if (customerProduct?.TotalPremium == null)
            {
                throw new RuleException("Customer product total premium not found");
            }
            customerProduct.AverageMonthlyPremium = customerProduct.TotalPremium / 12;
            return customerProduct;
        }
    }
}
