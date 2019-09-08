using System.Collections.Generic;
using Abp.Authorization;
using AngularRestApi.Goods;
using AngularRestApi.Orders.Dto;

namespace AngularRestApi.Orders
{
	[AbpAllowAnonymous]
	public class OrdersAppService: AngularRestApiAppServiceBase
	{
		private IOrdersManager _ordersManager;

		public OrdersAppService(IOrdersManager ordersManager)
		{
			_ordersManager = ordersManager;
		}

		public OrderDto Create(OrderDto inputOrder)
		{
			IOrder order = _ordersManager.Create(ObjectMapper.Map<Order>(inputOrder), ObjectMapper.Map<List<IGood>>(inputOrder.Goods));

			return ObjectMapper.Map<OrderDto>(order);
		}
		
		public List<OrderDto> Get(long orderId)
		{
			var orders = _ordersManager.GetOrder(orderId);

			return ObjectMapper.Map<List<OrderDto>>(orders);
		}
	}
}