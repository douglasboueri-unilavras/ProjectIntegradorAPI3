using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projeto_teste.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        [HttpGet]
        public List<Colaborador> Listar()
        {
            return new List<Colaborador>
            {
                new Colaborador 
                { 
                    
                    Nome = "biscoito recheado", 
                    Quantidade = 47, 
                    categoria = "chocolate"
                
                    
                },

                new Colaborador 
                { 
                   
                    
                    Nome = "suco po tang ", 
                    Quantidade = 70, 
                    categoria = "suco",
                
                
                },
                
               new Colaborador {  Nome = "Steak de Frango Sadia", Quantidade = 80, categoria =  "aves"},
                
                new Colaborador {  Nome = "Cerveja Budweiser 330ml", Quantidade = 45, categoria = "cerveja" },
                
                new Colaborador {  Nome = "Coca Cola 350m", Quantidade = 200 , categoria = "refrigerante"  },
                
                new Colaborador {  Nome = " Ovo de Páscoa Diamante Negro", Quantidade = 350, categoria =  "chocolate" },
                
                new Colaborador {  Nome = "Cerveja Brahma Duplo Malte", Quantidade = 220, categoria =  "cerveja" },
                
                new Colaborador {  Nome = "salgadinhos chips",Quantidade = 25, categoria = "salgado" },
                
                new Colaborador {  Nome = "presunto sadia", Quantidade = 57, categoria="suino" } 
                
            };
        }

    
        
        
    }
}
