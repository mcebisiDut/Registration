using System.Threading.Tasks;
using Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Sales.Api.Controllers {
    [Route("[controller]")]
    public class UsersController : Controller {
        private readonly IBusClient _busClient;
        public UsersController (IBusClient busClient) {
            _busClient = busClient;
        }

        [HttpPost ("register")]
        public async Task<IActionResult> Post ([FromBody] RegisterUser command) {
            await _busClient.PublishAsync (command);

            return Accepted ();
        }
    }
}