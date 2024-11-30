using ServiceBusDemo.Models;
using ServiceBusDemo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceBusDemo.Controllers
{
    public class CarsController : ControllerBase
    {
        private readonly IServiceBus _serviceBus;
        public CarsController(IServiceBus serviceBus)
        {
            _serviceBus = serviceBus;
        }
        /// <summary>
        /// Send Order Details
        /// </summary>
        /// <param name="carDetails"></param>
        /// <returns></returns>
        [HttpPost("OrderDetails")]
        public async Task<IActionResult> OrderDetails(CarDetails carDetails)
        {
            if (carDetails != null)
            {
                await _serviceBus.SendMessageAsync(carDetails);
            }
            return Ok();
        }
    }
}
