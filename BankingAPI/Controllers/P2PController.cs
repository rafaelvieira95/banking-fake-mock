using System;
using BankingAPI.Mapping;
using BankingAPI.Models.Request;
using BankingAPI.Models.Response;
using BankingAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankingAPI.Controllers
{
    [Route("[controller]/[action]")]
    public class P2PController: ControllerBase
    {

        private readonly IP2PInternalService _internalService;
        
        public P2PController(IP2PInternalService internalService)
        {
            _internalService = internalService;
        }

        [HttpPost]
        public IActionResult InternalTransfer([FromBody] P2PInternalTransferRequest p2PInternalTransferRequest)
        {
            var transfer = _internalService.Get(p2PInternalTransferRequest.PartnerId);

            if (transfer != null)
            {
                //era retornar o numero de documento da transferencia.
                var response = ResponseMapper.Map(true, transfer.FromTaxNumber, "Success");
                return Ok(response);
            }

            var error = ResponseMapper.Map(false, new object[] { }, "An error occurred");
            return NotFound(error);
        }

        /*
        [HttpPost]
        public IActionResult MultipleInternalTransfers([FromBody] P2PMultipleInnerTransferRequest p2PMultipleInnerTransferRequest)
        {
            return Ok(null);
        }
        
        [HttpPost]
        public IActionResult GetInternalTransferById(long id)
        {
            var transfer = _internalService.Get(id);
            return Ok(null);
        }

        [HttpPost]
        public IActionResult GetInternalTransferByDate()
        {
            return Ok(null);
        }

        [HttpPost]
        public IActionResult CancelInternalTransfer()
        {
            return Ok(null);
        }
       */    
    }
    
}