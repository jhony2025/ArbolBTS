using System;

class ArbolBST
{
    public Nodo Raiz;

    public ArbolBST()
    {
        Raiz = null;
    }

    // INSERTAR
    public Nodo Insertar(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = Insertar(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = Insertar(nodo.Derecho, valor);

        return nodo;
    }

    // BUSCAR
    public bool Buscar(Nodo nodo, int valor)
    {
        if (nodo == null)
            return false;

        if (valor == nodo.Valor)
            return true;

        if (valor < nodo.Valor)
            return Buscar(nodo.Izquierdo, valor);
        else
            return Buscar(nodo.Derecho, valor);
    }

    // RECORRIDO INORDEN
    public void Inorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Inorden(nodo.Izquierdo);
            // Removed Console.Write
            Inorden(nodo.Derecho);
        }
    }

    // RECORRIDO PREORDEN
    public void Preorden(Nodo nodo)
    {
        if (nodo != null)
        {
            // Removed Console.Write
            Preorden(nodo.Izquierdo);
            Preorden(nodo.Derecho);
        }
    }

    // RECORRIDO POSTORDEN
    public void Postorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izquierdo);
            Postorden(nodo.Derecho);
            // Removed Console.Write
        }
    }

    // VALOR MINIMO
    public int Minimo(Nodo nodo)
    {
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;

        return nodo.Valor;
    }

    // VALOR MAXIMO
    public int Maximo(Nodo nodo)
    {
        while (nodo.Derecho != null)
            nodo = nodo.Derecho;

        return nodo.Valor;
    }

    // ALTURA DEL ARBOL
    public int Altura(Nodo nodo)
    {
        if (nodo == null)
            return -1;

        int izquierda = Altura(nodo.Izquierdo);
        int derecha = Altura(nodo.Derecho);

        return Math.Max(izquierda, derecha) + 1;
    }

    // ELIMINAR
    public Nodo Eliminar(Nodo nodo, int valor)
    {
        if (nodo == null)
            return nodo;

        if (valor < nodo.Valor)
            nodo.Izquierdo = Eliminar(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = Eliminar(nodo.Derecho, valor);
        else
        {
            if (nodo.Izquierdo == null)
                return nodo.Derecho;
            else if (nodo.Derecho == null)
                return nodo.Izquierdo;

            nodo.Valor = Minimo(nodo.Derecho);
            nodo.Derecho = Eliminar(nodo.Derecho, nodo.Valor);
        }

        return nodo;
    }

    // LIMPIAR
    public void Limpiar()
    {
        Raiz = null;
    }
}
