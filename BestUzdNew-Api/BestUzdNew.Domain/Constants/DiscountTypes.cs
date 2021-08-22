using System;
using System.Collections.Generic;
using System.Text;

namespace BestUzdNew.Domain.Constants
{
    public static class DefaultDiscountTypes
    {
        public static readonly DefaultDiscountType Percent = new DefaultDiscountType() 
        {
            NameAlias = "Percent",
            DescriptionAlias = "Discount in percent"
        };

        public static readonly DefaultDiscountType Value = new DefaultDiscountType()
        {
            NameAlias = "Value",
            DescriptionAlias = "Price minus value"
        };
    }

    public class DefaultDiscountType
    {
        public string NameAlias { get; set; }
        public string DescriptionAlias { get; set; }
    }
}

