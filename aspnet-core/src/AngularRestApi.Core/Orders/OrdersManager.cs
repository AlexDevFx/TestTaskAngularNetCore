using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using AngularRestApi.Goods;
using AngularRestApi.OrderGoods;
using Microsoft.EntityFrameworkCore;

namespace AngularRestApi.Orders
{
	public interface IOrdersManager
	{
		IOrder Create(Order order, List<IGood> goods);
		IOrder GetOrder(long orderId);
	}

	public class OrdersManager: DomainService, IOrdersManager
	{
		private readonly IRepository<Order, long> _ordersRepository;
		private readonly IRepository<OrderGood, long> _ordersGoodsRepository;

		public OrdersManager(IRepository<Order, long> ordersRepository,
			IRepository<OrderGood, long> ordersGoodsRepository)
		{
			_ordersGoodsRepository = ordersGoodsRepository;
			_ordersRepository = ordersRepository;
		}

		public IOrder Create(Order order, List<IGood> goods)
		{
			if (goods?.Any() != true)
			{
				return null;
			}

			Order savedOrder = order;
			
			foreach (var g in goods)
			{
				savedOrder.OrderGoods.Add(new OrderGood()
				{
					GoodId = g.Id,
					OrderId = savedOrder.Id
				});
			}

			return _ordersRepository.Insert(savedOrder);
		}
		
		public IOrder GetOrder(long orderId)
		{
			IOrder order = _ordersRepository.GetAll()
				.Include(e => e.OrderGoods).ThenInclude(e => e.Good)
				.FirstOrDefault(e => e.Id == orderId);

			return order;
		}
	}
}