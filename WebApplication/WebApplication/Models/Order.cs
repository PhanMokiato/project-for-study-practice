﻿namespace WebApplication.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; } // имя фамилия покупателя
        public string Address { get; set; } // адрес покупателя
        public string ContactPhone { get; set; } // контактный телефон покупателя
 
        public int FlowerId { get; set; } // ссылка на связанную модель цветка
        public Flower Flower { get; set; }
    }
}