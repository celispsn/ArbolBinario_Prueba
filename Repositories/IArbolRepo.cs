using ArbolBinario_Prueba.DTOs.Arbol;
using ArbolBinario_Prueba.Helper;

namespace ArbolBinario_Prueba.Repositories
{
    public interface IArbolRepo
    {
        Nodo createArbol(CrearArbol crearArbol);
        int LowestCommonAncestor(LowestCommonAncestor lowestCommonAncestor);
    }
}
