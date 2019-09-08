using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace AngularRestApi.Goods
{
	public interface IGoodsManager
	{
		Task<List<IGood>> GetAll();
	}

	public class GoodsManager: DomainService, IGoodsManager
	{
		private readonly IRepository<Good, long> _goodsRepository;

		public GoodsManager(IRepository<Good, long> goodsRepository)
		{
			_goodsRepository = goodsRepository;
		}

		public Task<List<IGood>> GetAll()
		{
			return _goodsRepository.GetAll().Cast<IGood>().ToListAsync();
		}
	}
}