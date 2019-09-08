using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Authorization;
using AngularRestApi.Goods.Dto;

namespace AngularRestApi.Goods
{
	[AbpAllowAnonymous]
	public class GoodsAppService: AngularRestApiAppServiceBase
	{
		private readonly IGoodsManager _goodsManager;

		public GoodsAppService(IGoodsManager goodsManager)
		{
			_goodsManager = goodsManager;
		}

		public async Task<List<GoodDto>> GetAll()
		{
			var goods = await _goodsManager.GetAll();

			return ObjectMapper.Map<List<GoodDto>>(goods);
		}
	}
}