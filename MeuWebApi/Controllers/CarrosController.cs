using MeuWebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MeuWebApi.Controllers
{
    public class CarrosController : ApiController
    {
        public List<Carro> Carros
        {
            get
            {
                if (HttpContext.Current.Application["Carros"] == null)
                {
                    HttpContext.Current.Application["Carros"] = new List<Carro>
                    {
                        new Carro
                        {
                            Id = 1,
                            Cor = "Prata",
                            Nome = "Peugeot 160"
                        },
                        new Carro
                        {
                            Id = 2,
                            Cor = "Branco",
                            Nome = "JAC J3"
                        }
                    };

                }

                return (List<Carro>)HttpContext.Current.Application["Carros"];
            }
        }

        public IHttpActionResult Get()
        {
            return Ok(Carros);
        }

        public IHttpActionResult Get(int id)
        {
            var carro = Carros.FirstOrDefault(c => c.Id == id);

            if (carro != null)
                return Ok(carro);
            return NotFound();
        }

        public IHttpActionResult Post(Carro carro)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Carros.Add(carro);
            return CreatedAtRoute("DefaultApi", new { id = carro.Id }, carro);
        }

        public IHttpActionResult Put(int id, [FromBody]Carro carro)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var car = Carros.FirstOrDefault(c => c.Id == id);

            if (car != null)
            {
                car.Nome = carro.Nome;
                car.Cor = carro.Cor;
                return Ok();
            }

            return NotFound();
        }
    }
}
