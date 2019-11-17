using System;
using System.Linq;
using ArbolBinario_Prueba.DTOs.Arbol;
using ArbolBinario_Prueba.Helper;

namespace ArbolBinario_Prueba.Repositories
{
    public class ArbolRepo : IArbolRepo
    {
        public bool createArbol(CrearArbol crearArbol)
        {
            if(crearArbol == null){
                return false;
            }
            Nodo nodoRaiz = new Nodo(crearArbol.nodeValues[0]); // Nodo Inicial
            foreach (var nodeValue in crearArbol.nodeValues.Skip(1))
            {
                insertNodo(nodoRaiz, nodeValue);
            }
            displayNode(nodoRaiz);
            return true;
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

        public void displayNode(Nodo nodoRaiz)
        {
            if(nodoRaiz == null) { return; }
            displayNode(nodoRaiz.leftChild);
            Console.WriteLine(nodoRaiz.nodeValue);
            displayNode(nodoRaiz.rightChild);
        }
    }
}
