using DataHelper.Service.Contract;
using System.Collections.Generic;
using System.Web.Http;

namespace BxFinTask.ApiControllers
{
    [RoutePrefix("api/arraycalc")]
    public class ArrayCalcController : ApiController
    {
        private IArrayHelperService _arrayHelperService;
        public ArrayCalcController(IArrayHelperService arrayHelperService) {
            _arrayHelperService = arrayHelperService;
        }
        // GET api/arraycalc/reverse
        [Route("reverse"), HttpGet]
        public IEnumerable<int> Reverse([FromUri]int[] productIds)
        {
            var result = _arrayHelperService.Reverse(productIds);
            return result;
        }

        // GET api/arraycalc/deletepart
        [Route("deletepart"), HttpGet]
        public IEnumerable<int> DeletePart([FromUri]int[] productIds, int position = 0)
        {
            var result = _arrayHelperService.DeletePart(productIds, position);
            return result;
        }
    }
}