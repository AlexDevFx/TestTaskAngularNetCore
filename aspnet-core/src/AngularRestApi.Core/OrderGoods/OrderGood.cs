using Abp.Domain.Entities;
using AngularRestApi.Goods;
using AngularRestApi.Orders;

namespace AngularRestApi.OrderGoods
{
	public class OrderGood: Entity<long>
	{
		public long OrderId { get; set; }
		public Order Order { get; set; }
		
		public long GoodId { get; set; }
		public Good Good { get; set; }
	}
}