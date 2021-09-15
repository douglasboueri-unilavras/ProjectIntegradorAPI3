using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro___Produtos.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TipoController : ControllerBase
    {
    
        [HttpGet]
        
        public List<Tipo> listar()
        {
             List<Tipo> Tipo = new List<Tipo>();

            Tipo bebida = new Tipo
            {
                Id = 1,
                Nome = "bebida"
            };

            Tipo.Add(bebida);


            Tipo carne = new Tipo
            {
                Id = 2,
                Nome = "carne"
            };

            Tipo.Add(carne);



            Tipo bicoito = new Tipo
            {
                Id = 3,
                Nome = "biscoito"
            };

            Tipo.Add(bicoito);

            Tipo suino  = new Tipo
            {
                Id = 4,
                Nome = "suino "
            };

            Tipo.Add(suino);

            Tipo Laticinios = new Tipo
            {
                Id = 5,
                Nome = "laticinios"
            };

            Tipo.Add(Laticinios);



            Tipo chocolate = new Tipo
            {
                Id = 6,
                Nome = "chocolate"
            };

            Tipo.Add(chocolate);


            

            Tipo refrigerante = new Tipo
            {
                Id = 7,
                Nome = "refrigerante"
            };

            Tipo.Add(refrigerante);


            Tipo salgado = new Tipo
            {
                Id = 8,
                Nome = "salgado"
            };

            Tipo.Add(salgado);



            return Tipo;
        }
    }
}


        
       

