using AutoMapper;
using Data.Repositories;
using Entities.Assets;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class AssetPartsController : CrudController<AssetPartsDto, AssetPart>
    {
        public AssetPartsController(IRepository<AssetPart> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
