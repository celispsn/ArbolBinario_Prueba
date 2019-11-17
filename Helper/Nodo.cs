namespace ArbolBinario_Prueba.Helper
{
    public class Nodo
    {
        public int nodeValue { get; set; }
        public Nodo rightChild { get; set; }
        public Nodo leftChild { get; set; }
        public Nodo() {  }
        public Nodo(int nodeValue) { this.nodeValue = nodeValue; }
    }
}
