using Catalog.API;
using Catalog.API.Protos;
using Grpc.Core;

namespace Catalog.API.Services
{


	public class CatalogService : Protos.CatalogService.CatalogServiceBase
	{
		private readonly ILogger<CatalogService> _logger;
		public CatalogService(ILogger<CatalogService> logger)
		{
			_logger = logger;
		}

	
		public override Task<CatalogItem> GetItemById(GetItemByIdRequest request, ServerCallContext context)
		{
		
			return  Task.FromResult(new CatalogItem
			{
				Id = new Guid().ToString(),
				Name = "Test",
				Description = "Test",
				Price = 4,
				PictureFileName = string.Empty,
				PictureUri = string.Empty,
				CatalogTypeId = string.Empty,
				CatalogBrandId = string.Empty
			});
		}


	}
}