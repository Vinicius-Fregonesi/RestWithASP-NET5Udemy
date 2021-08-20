using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.HyperMidia.Filters
{
    public class HyperMediaFilter : ResultFilterAttribute
    {
        private readonly HyperMediaFilterOptions _hyperMediaFilterOptions;
        public HyperMediaFilter(HyperMediaFilterOptions hyperMediaFilterOptions)
        {
            _hyperMediaFilterOptions = hyperMediaFilterOptions;
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnricheResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnricheResult(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult objectResult)
            {
                var enricher = _hyperMediaFilterOptions.ContentReponseEnricherList.FirstOrDefault(
                        x=>x.CanEnrich(context)
                    );
                if (enricher!=null)
                {
                    Task.FromResult(enricher.Enrich(context));
                }
            }
        }
    }
}
