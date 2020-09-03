using System;
using System.Collections.Generic;

public class Node
{
    public List<Node> Edges { get; private set; }

    public int Distance { get; private set; }

    public string Label { get; private set; }

    public bool Visited { get; private set; }

    public Node(string label)
    {
        this.Edges = new List<Node>();
        this.Label = label.ToUpper();
        this.Visited = false;
        this.Distance = 1;
    }

    public void AddRelationship(Node node)
    {
        this.Edges.Add(node);
    }

    public void NodeVisited()
    {
        this.Visited = true;
    }

    public void SetDistance(int distance)
    {
        this.Distance = distance;
    }

    public void CleanNode()
    {
        this.Visited = false;
        this.Distance = 1;
    }
}

public class Graph
{

    public List<Node> Nodes { get; private set; }

    public int MaxChain { get; private set; }

    public Graph()
    {
        this.Nodes = new List<Node>();
        this.MaxChain = 0;
    }

    public void AddNode(Node node)
    {
        Node nodeVerify = GetNodeByName(node.Label);
        if (nodeVerify == null)
            this.Nodes.Add(node);
    }

    public void AddRelationship(string passive, string active)
    {
        Node nodeActive = GetNodeByName(active);
        Node nodePassive = GetNodeByName(passive);

        nodePassive.AddRelationship(nodeActive);
        nodeActive.AddRelationship(nodePassive);
    }

    public void SearchBreadthFirst()
    {
        foreach (Node firstNode in this.Nodes)
        {
            BreadthFirst(firstNode);
        }
    }

    private void BreadthFirst(Node first)
    {
        int distance = 1;
        Queue<Node> queeu = new Queue<Node>();
        CleanGraph();

        queeu.Enqueue(first);
        first.SetDistance(distance);
        first.NodeVisited();

        while (queeu.Count > 0)
        {
            Node node = queeu.Dequeue();

            foreach (Node edge in node.Edges)
            {
                if (edge.Visited == false)
                {
                    edge.SetDistance(node.Distance + 1);
                    edge.NodeVisited();
                    queeu.Enqueue(edge);
                    distance++;
                }
            }
        }

        if (distance > this.MaxChain)
            this.MaxChain = distance;
    }

    private Node GetNodeByName(string name)
    {
        foreach (Node node in Nodes)
        {
            if (node.Label.Equals(name.ToUpper()))
                return node;
        }
        return null;
    }

    private void CleanGraph()
    {
        foreach (Node node in this.Nodes)
        {
            node.CleanNode();
        }
    }
}

public class Test
{
    class celula
    {
        public celula ant { get; set; }
        public celula prox { get; set; }

        public int dado { get; set; }
    }
    class lista
    {
        private celula Inicio;
        private celula Fim;
        private int Tam;

        public lista(int n)
        {
            celula temp = new celula();
            temp.dado = 1;
            temp.ant = temp.prox = null;
            Tam = 1;
            Inicio = Fim = temp;
            while (Tam < n)
            {
                Tam++;
                temp = new celula();
                temp.dado = Tam;
                temp.prox = null;
                temp.ant = Fim;
                Fim.prox = temp;
                Fim = temp;
            }
            Fim.prox = Inicio;
            Inicio.ant = Fim;
        }

        public int Tamanho()
        {
            return Tam;
        }
        public bool Vazia()
        {
            return Inicio == Fim;
        }

        public void Inserir(int dado)
        {
            celula temp = new celula();
            temp.dado = dado;
            temp.prox = Inicio;
            temp.ant = Fim;

            Fim.prox = temp;
            Fim = temp;
            Fim.prox = Inicio;
            Inicio.ant = Fim;
            Tam++;
        }

        public void Imprimir()
        {
            int cont = 0;
            celula temp = Inicio;
            while (cont < Tam)
            {
                Console.WriteLine(temp.dado);
                temp = temp.prox;
                cont++;
            }
        }

        public void ImprimirInvertido()
        {
            celula temp = Fim;

            while (temp != Inicio)
            {
                Console.WriteLine(temp.dado);
                temp = temp.ant;
            }

        }

        public int Remover(int m, int o)
        {
            celula temp = Inicio;
            for (int i = 1; i < m; i++)
            {
                temp = temp.prox;
            }
            while (Tam > 1)
            {
                for (int j = 0; j < o; j++)
                {
                    temp = temp.prox;
                }
                RemoverCelula(temp);
            }
            Imprimir();
            return temp.dado;
        }

        public void RemoverCelula(celula temp)
        {
            Tam--;
            celula ant = temp.ant;
            celula prox = temp.prox;
            ant.prox = prox;
            prox.ant = ant;
            if (temp == Inicio)
            {
                Inicio = temp.prox;
                Inicio.ant = Fim;
            }
            if (temp == Fim)
            {
                Fim = temp.ant;
                Fim.prox = Inicio;
            }
        }
    }
    static void Main(string[] args)
    {
        int nNodes = 0, nRelations = 0;
        Graph graph;
        string length;
        List<int> resp = new List<int>();

        length = Console.ReadLine();
        nNodes = Convert.ToInt32(length.Split(' ')[0]);
        nRelations = Convert.ToInt32(length.Split(' ')[1]);
        while (nNodes != 0 && nRelations != 0)
        {
            graph = new Graph();

            for (int i = 0; i < nNodes; i++)
            {
                string nodeLabel = Console.ReadLine();
                graph.AddNode(new Node(nodeLabel));
            }

            for (int i = 0; i < nRelations; i++)
            {
                string relation = Console.ReadLine();
                string passive = relation.Split(' ')[0];
                string active = relation.Split(' ')[1];
                graph.AddRelationship(passive, active);
            }

            //Stopwatch watch = Stopwatch.StartNew();

            graph.SearchBreadthFirst();

            resp.Add(graph.MaxChain);

            //watch.Stop();
            Console.WriteLine();
            length = Console.ReadLine();
            nNodes = Convert.ToInt32(length.Split(' ')[0]);
            nRelations = Convert.ToInt32(length.Split(' ')[1]);
        }

        foreach (int x in resp)
        {
            Console.WriteLine(x);
        }
    }
}