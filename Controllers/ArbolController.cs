using ArbolBinario_Prueba.DTOs.Arbol;
using ArbolBinario_Prueba.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ArbolBinario_Prueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArbolController : ControllerBase
    {
        private readonly IArbolRepo arbolRepo;
        public ArbolController(IArbolRepo arbolRepo)
        {
            this.arbolRepo = arbolRepo;
        }
        
        [HttpPost("crear")]
        public IActionResult crearArbol(CrearArbol crearArbol)
        {
            var nodoRaiz = arbolRepo.createArbol(crearArbol);
            if(nodoRaiz != null){
                return Ok(nodoRaiz);
            }
            return BadRequest();
        }

        [HttpPost("lowest")]
        public IActionResult lcaFind(LowestCommonAncestor lowestCommonAncestor)
        {
            var lcaValue = arbolRepo.LowestCommonAncestor(lowestCommonAncestor);
            if(lcaValue == 0){
                return BadRequest();
            }        
            return Ok(lcaValue);
        }
    }
}
