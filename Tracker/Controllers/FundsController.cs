using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Tracker.Models;
using Tracker.Models.Dao;
using Tracker.Models.Dto;

namespace Tracker.Controllers
{
    [Route("api/v1/[Controller]")]
    public class FundsController : Controller
    {
        private readonly ILogger<FundsController> _logger;

        public FundsController(ILogger<FundsController> logger)
        {
            _logger = logger;
        }

        // "/api/v1/funds/fund-types"
        [HttpGet("fund-types")]
        public IActionResult GetFundTypes()
        {
            return new OkObjectResult(FundTypeOptions.ToList());
        }

        // "/api/v1/funds/fund-types/mutual-fund/funds"
        [HttpGet("fund-types/{fundType}/funds")]
        public IActionResult GetFundsForFundType([FromRoute] FundType fundType)
        {
            switch (fundType)
            {
                case FundType.Index:

                    var indexResult = AllIndicesMetadata.Select(indexMetadata => new IndexOption
                    {
                        OptionValue = indexMetadata.IndexType,
                        OptionName = indexMetadata.IndexName,
                    }).ToList();
                    
                    return new OkObjectResult(indexResult);

                case FundType.TotalReturnIndex:

                    var triResult = AllTotalReturnIndicesMetadata.Select(triMetadata => new TotalReturnIndexOption
                    {
                        OptionValue = triMetadata.TotalReturnIndexType,
                        OptionName = triMetadata.TotalReturnIndexName,
                    }).ToList();

                    return new OkObjectResult(triResult);

                case FundType.MutualFund:

                    var result = AllMutualFundsMetadata.Select(mfMetadata => new MutualFundOption
                    {
                        OptionValue = mfMetadata.Id,
                        OptionName = $"{mfMetadata.FundHouse} {mfMetadata.FundName} - {mfMetadata.Plan}, {mfMetadata.Mode}",
                    }).ToList();

                    return new OkObjectResult(result);

                default:
                    return StatusCode(500, "Fund type is not known or metadata files are missing.");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static readonly IEnumerable<FundTypeOption> FundTypeOptions = new List<FundTypeOption>
        {
            new FundTypeOption { OptionValue = FundType.Index, OptionName = "Index" },
            new FundTypeOption { OptionValue = FundType.TotalReturnIndex, OptionName = "Total Returns Index" },
            new FundTypeOption { OptionValue = FundType.Stock, OptionName = "Stock" },
            new FundTypeOption { OptionValue = FundType.MutualFund, OptionName = "Mutual Fund" },
            new FundTypeOption { OptionValue = FundType.Insurance, OptionName = "Insurance" },
        };

        private static IEnumerable<IndexMetadata>? _allIndicesMetadata = null;
        
        private static IEnumerable<IndexMetadata> AllIndicesMetadata
        {
            get
            {
                if (_allIndicesMetadata == null)
                {
                    var metadataFileContents = System.IO.File.ReadAllText("./StaticData/IndexMetadata.json");

                    _allIndicesMetadata = JsonConvert.DeserializeObject<IEnumerable<IndexMetadata>>(metadataFileContents);
                }

                return _allIndicesMetadata!;
            }
        }

        private static IEnumerable<TotalReturnIndexMetadata>? _allTotalReturnIndicesMetadata = null;

        private static IEnumerable<TotalReturnIndexMetadata> AllTotalReturnIndicesMetadata
        {
            get
            {
                if (_allTotalReturnIndicesMetadata == null)
                {
                    var metadataFileContents = System.IO.File.ReadAllText("./StaticData/TotalReturnIndexMetadata.json");

                    _allTotalReturnIndicesMetadata = JsonConvert.DeserializeObject<IEnumerable<TotalReturnIndexMetadata>>(metadataFileContents);
                }

                return _allTotalReturnIndicesMetadata!;
            }
        }

        private static IEnumerable<MutualFundMetadata>? _allMutualFundsMetadata = null;

        private static IEnumerable<MutualFundMetadata> AllMutualFundsMetadata
        {
            get
            {
                if (_allMutualFundsMetadata == null)
                {
                    var metadataFileContents = System.IO.File.ReadAllText("./StaticData/MutualFundMetadata.json");

                    _allMutualFundsMetadata = JsonConvert.DeserializeObject<IEnumerable<MutualFundMetadata>>(metadataFileContents);
                }

                return _allMutualFundsMetadata!;
            }
        }
    }
}
