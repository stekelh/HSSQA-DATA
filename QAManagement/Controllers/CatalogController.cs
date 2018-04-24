using Microsoft.AspNetCore.Mvc;
using QAData;
using QAManagement.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAManagement.Controllers
{
    public class CatalogController : Controller
    {
      private IQAAsset _assets;
      public  CatalogController(IQAAsset assets)
      {
          _assets = assets;

      }
      public IActionResult Index()
      {
          var assetModels = _assets.GetAll();
          var listingResult = assetModels
             .Select(result => new AssetIndexListingModel
             {  
                 Id = result.Id,
                 Title = result.Title,
                 AuthorOrDirector = _assets.GetAuthororDirector(result.Id),
                 DataCallNumber= _assets.GetQATCI(result.Id),
                 Type = _assets.GetType(result.Id)
            });

      }
    }
}