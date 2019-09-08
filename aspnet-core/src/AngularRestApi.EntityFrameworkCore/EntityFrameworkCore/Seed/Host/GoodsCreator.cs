using System.Collections.Generic;
using System.Linq;
using AngularRestApi.Goods;
using Microsoft.EntityFrameworkCore;

namespace AngularRestApi.EntityFrameworkCore.Seed.Host
{
	public class GoodsCreator
	{
		private readonly AngularRestApiDbContext _context;

		public GoodsCreator(AngularRestApiDbContext context)
		{
			_context = context;
		}
		
		public void Create()
		{
			List<Good> goods = new List<Good>()
			{
				new Good() { Title = "Брюки", Price = 50m },
				new Good() { Title = "Рубашка", Price = 30m },
				new Good() { Title = "Пиджак", Price = 70m },
				new Good() { Title = "Шляпа", Price = 10m },
			};
			CreateGoods(goods);
		}

		private void CreateGoods(List<Good> goods)
		{
			foreach (var g in goods)
			{
				if (!_context.Goods.IgnoreQueryFilters().Any(e => e.Title == g.Title))
				{
					_context.Add(g);
				}
			}
			_context.SaveChanges();
		}
	}
}