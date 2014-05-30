using System.Web.Http;
using MeuWebApi.Models;

namespace MeuWebApi.Controllers
{
    public class CarrosController : ApiController
    {
        public IHttpActionResult Get()
        {
            return null;
        }

        public IHttpActionResult Get(int id)
        {
            return null;
        }

        public IHttpActionResult Post(Carro carro)
        {
            return null;
        }
        public IHttpActionResult Put(int id, [FromBody]Carro carro)
        {
            return null;
        }
    }
}
