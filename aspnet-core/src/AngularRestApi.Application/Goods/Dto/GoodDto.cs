using Abp.AutoMapper;

namespace AngularRestApi.Goods.Dto
{
	[AutoMapFrom(typeof(IGood))]
	[AutoMapTo(typeof(IGood))]
	public class GoodDto
	{
		public long Id { get; set; }
		public string Title { get; set; }
		public decimal Price { get; set; }
		public int Count { get; set; }
	}
}