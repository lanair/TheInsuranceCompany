﻿namespace TIC.WebAPI.Models.Responses
{
    public class GetDutchTravelInsuranceResponse
    {
        public IEnumerable<string> Name { get; set; }
        public IEnumerable<string> Description { get; set; }

        public IEnumerable<decimal> InsurancePremium { get; set; }

        public IEnumerable<decimal> InsuredAmount { get; set; }
    }
}
