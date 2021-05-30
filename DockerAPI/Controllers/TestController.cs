using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Net; 
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Logging; 

namespace DockerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController:ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string ris = ""; 

            ris = $"Machine Name: {Environment.MachineName}\nHostname: {Dns.GetHostName()}\nIp:{Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(o => o.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First()}"; 
            return ris; 
        }

    }
}
