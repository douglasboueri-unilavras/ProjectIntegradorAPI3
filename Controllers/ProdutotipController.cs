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
    public class ProdutotipController : ControllerBase
    {
       [HttpGet]
        public List<produtotip> Listar()
        {
            return new List<produtotip>
            {
                new produtotip
                { 
                    
                    Nome = "bicoito recheado danix", 
                    Codigo = 0567, 
                    tipo = "biscoito recheado"
                
                    
                },

                new produtotip 
                { 
                   
                    
                    Nome = "iogurte vigor grego ", 
                    Codigo = 995, 
                    tipo = "bebida",
                
                
                },
                
              
                
                new produtotip {  Nome = "Cerveja Budweiser 330ml", Codigo = 745, tipo= "cerveja" },
                
                new produtotip {  Nome = " Ovo de Páscoa Diamante Negro", Codigo = 340, tipo =  "chocolate" },
                
                new produtotip{  Nome = "presunto sadia", Codigo = 456, tipo="suino" } 
                
            };
        }

    
        
        
    }
}
