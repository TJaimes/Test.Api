using DA.Models;
using DA.Providers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api.Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductosController
    {
        [HttpGet ("GetProductos")]
        public async Task<string> GetProductos()
        {
            TestProvider productos = new TestProvider();
            IEnumerable<Alphabetical_list_of_products> resultado = await productos.LeerProductos();
            return JsonConvert.SerializeObject(resultado);
        }
    }
}
