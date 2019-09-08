using System;
using System.Collections.Generic;
using Abp.Domain.Entities;
using AngularRestApi.OrderGoods;

namespace AngularRestApi.Orders
{
	public interface IOrder
	{
		string Title { get; }
		int Count { get; }
		bool ShouldBeDelivered { get; }
		DateTime DeliveryDate { get; }
		List<OrderGood> OrderGoods { get; }
	}

	public class Order: Entity<long>, IOrder
	{
		public string Title { get; set; }
		public int Count { get; set; }
		public bool ShouldBeDelivered { get; set; }
		public DateTime DeliveryDate { get; set; }
		
		public List<OrderGood> OrderGoods { get; set; }
	}
}