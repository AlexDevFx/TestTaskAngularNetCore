using System.Collections.Generic;
using Abp.Domain.Entities;
using AngularRestApi.OrderGoods;

namespace AngularRestApi.Goods
{
	public interface IGood: IEntity<long>
	{
		string Title { get; }
		decimal Price { get; }
		List<OrderGood> OrderGoods { get; }
	}

	public class Good: Entity<long>, IGood
	{
		public string Title { get; set; }
		public decimal Price { get; set; }
		
		public List<OrderGood> OrderGoods { get; set; }
	}
}