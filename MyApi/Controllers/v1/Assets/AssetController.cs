using AutoMapper;
using Data.Repositories;
using Entities.Assets;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class AssetController : CrudController<AssetDto, Asset>
    {
        public AssetController(IRepository<Asset> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
