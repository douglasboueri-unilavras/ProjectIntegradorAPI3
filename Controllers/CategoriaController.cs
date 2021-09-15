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
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        
        public List<Categoria> listar()
        {
             List<Categoria> categoria = new List<Categoria>();

            Categoria suco = new Categoria
            {
                Id = 1,
                Nome = "suco"
            };

            categoria.Add(suco);


            Categoria cerveja = new Categoria
            {
                Id = 2,
                Nome = "cerveja"
            };

            categoria.Add(cerveja);



            Categoria bovino = new Categoria
            {
                Id = 3,
                Nome = "bovino"
            };

            categoria.Add(bovino);

            Categoria suino  = new Categoria
            {
                Id = 4,
                Nome = "suino "
            };

            categoria.Add(suino);

            Categoria aves = new Categoria
            {
                Id = 5,
                Nome = "aves"
            };

            categoria.Add(aves);



            Categoria chocolate = new Categoria
            {
                Id = 6,
                Nome = "chocolate"
            };

            categoria.Add(chocolate);


            

            Categoria refrigerante = new Categoria
            {
                Id = 7,
                Nome = "refrigerante"
            };

            categoria.Add(refrigerante);


            Categoria salgado = new Categoria
            {
                Id = 8,
                Nome = "salgado"
            };

            categoria.Add(salgado);



            return categoria;
        }
    }
}


        
       

