using System.Collections.Generic;
using System.Linq;
using Abp.AutoMapper;
using AngularRestApi.Goods.Dto;
using AngularRestApi.Orders.Dto;
using AutoMapper;

namespace AngularRestApi.Orders
{
	public class OrdersMapProfile: Profile
	{
		public OrdersMapProfile()
		{
			List<GoodDto> goods = new List<GoodDto>();
			CreateMap<Order, OrderDto>()
				.ForMember(e => e.Goods,
					s => s.MapFrom(e => e.OrderGoods.Select(g => 
						new GoodDto()
					{
						Price = g.Good.Price,
						Title = g.Good.Title
					})
						.ToList()));
			
			CreateMap<IOrder, OrderDto>()
				.ForMember(e => e.Goods,
					s => s.MapFrom(e => e.OrderGoods.Select(g => 
							new GoodDto()
							{
								Price = g.Good.Price,
								Title = g.Good.Title
							})
						.ToList()));
		}
	}
}