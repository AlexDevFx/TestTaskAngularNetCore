using System;
using System.Collections.Generic;
using Abp.AutoMapper;
using AngularRestApi.Goods.Dto;

namespace AngularRestApi.Orders.Dto
{
	[AutoMapTo(typeof(Order))]
	public class OrderDto
	{
		public string Title { get; set; }
		public int Count { get; set; }
		public bool ShouldBeDelivered { get; set; }
		public DateTime DeliveryDate { get; set; }
		
		public List<GoodDto> Goods { get; set; }
	}
}