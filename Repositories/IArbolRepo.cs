using ArbolBinario_Prueba.DTOs.Arbol;

namespace ArbolBinario_Prueba.Repositories
{
    public interface IArbolRepo
    {
        bool createArbol(CrearArbol crearArbol);
        int LowestCommonAncestor(LowestCommonAncestor lowestCommonAncestor);
    }
}