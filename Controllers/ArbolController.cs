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
            var stateArbol = arbolRepo.createArbol(crearArbol);
            return Ok();
        }

        [HttpPost("lowest")]
        public IActionResult lcaFind(LowestCommonAncestor lowestCommonAncestor)
        {
            var lcaValue = arbolRepo.LowestCommonAncestor(lowestCommonAncestor);
            return Ok(lcaValue);
        }
    }
}
