﻿namespace SimpleFactory.Products.Interfaces
{
    public interface ICreditCard
    {
        string GetCardType();
        decimal GetCreditCardLimit();
        decimal GetAnnualCharge();
    }
}