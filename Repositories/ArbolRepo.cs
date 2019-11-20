using System;
using System.Linq;
using System.Threading.Tasks;
using ArbolBinario_Prueba.DTOs.Arbol;
using ArbolBinario_Prueba.Helper;

namespace ArbolBinario_Prueba.Repositories
{
    public class ArbolRepo : IArbolRepo
    {
        public Nodo createArbol(CrearArbol crearArbol)
        {
            if(crearArbol == null){
                return null;
            }
            Nodo nodoRaiz = new Nodo(crearArbol.nodeValues[0]); // Nodo Inicial
            foreach (var nodeValue in crearArbol.nodeValues.Skip(1))
            {
                insertNodo(nodoRaiz, nodeValue);
            }
            return nodoRaiz;
        }

        public Nodo arbolaBuscar(CrearArbol crearArbol)
        {
            if(crearArbol == null){
                return null;
            }
            Nodo nodoRaiz = new Nodo(crearArbol.nodeValues[0]); // Nodo Inicial
            foreach (var nodeValue in crearArbol.nodeValues.Skip(1))
            {
                insertNodo(nodoRaiz, nodeValue);
            }
            return nodoRaiz;
        }

        private void insertNodo(Nodo nodoRaiz, int nodeValue)
        {
            Nodo nodoNuevo = new Nodo(nodeValue);
            if(nodoNuevo.nodeValue < nodoRaiz.nodeValue){
                if(nodoRaiz.leftChild == null){
                    nodoRaiz.leftChild = nodoNuevo;
                }else{
                    insertNodo(nodoRaiz.leftChild, nodeValue);
                }
            }else {
                // It's a Right Child
                if(nodoRaiz.rightChild == null){
                    nodoRaiz.rightChild = nodoNuevo;
                }else{
                    insertNodo(nodoRaiz.rightChild, nodeValue);
                }
            }
        }

        public int LowestCommonAncestor(LowestCommonAncestor lowestCommonAncestor)
        {
            CrearArbol arbol = new CrearArbol(){
                nodeValues = lowestCommonAncestor.nodeValues
            };
            Nodo nodoRaiz = arbolaBuscar(arbol);
            Nodo lcaValue = FindLca(nodoRaiz, lowestCommonAncestor.valueOne, lowestCommonAncestor.valueTwo);
            if(lcaValue == null){
                return 0;
            }
            return lcaValue.nodeValue;
        }

        public Nodo FindLca(Nodo nodoRevisando, int valueOne, int valueTwo)
        {

            if(nodoRevisando == null){
                return null;
            }

            if(nodoRevisando.nodeValue > valueOne && nodoRevisando.nodeValue > valueTwo){
                return FindLca(nodoRevisando.leftChild, valueOne, valueTwo);
            }

            if(nodoRevisando.nodeValue < valueOne && nodoRevisando.nodeValue < valueTwo){
                return FindLca(nodoRevisando.rightChild, valueOne, valueTwo);
            }
            return nodoRevisando;
        }
    }
}

