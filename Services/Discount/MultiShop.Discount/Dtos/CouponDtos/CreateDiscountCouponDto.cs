﻿namespace MultiShop.Discount.Dtos.CouponDtos
{
    public class CreateDiscountCouponDto
    {
       
        public string CouponCode { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
        public DateTime ValidDate { get; set; }
    }
}
