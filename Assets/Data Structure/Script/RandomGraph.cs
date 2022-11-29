using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = System.Random;
using RandomU = UnityEngine.Random;

public class RandomGraph : MonoBehaviour
{
    public int vertices;
    public int edges;

    public GameObject vertex;
    public GameObject edge;
    int MAX_LIMIT = 15;

    public Dictionary<(int, int), Edge> edgeList;
    public Edge[,] edgesW;
    int i = 0;

    Random random = new Random();
    public Dictionary<Vertex, List<Vertex>> adjacencyList;


    void Start()
    {
        this.vertices = random.Next(MAX_LIMIT) + 1;

        this.edges
            = random.Next(computeMaxEdges(vertices)) + 1;
        edgeList = new Dictionary<(int, int), Edge>(edges);
        adjacencyList = new Dictionary<Vertex, List<Vertex>>(vertices);

        for (int i = 0; i < vertices; i++)
        {
            Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(RandomU.Range(2, Screen.width - 2), RandomU.Range(2, Screen.height - 2), Camera.main.farClipPlane / 20));
            adjacencyList.Add(new Vertex(i, Instantiate(vertex, screenPosition, Quaternion.identity)), new List<Vertex>());
        }


        for (int i = 0; i < edges; i++)
        {
            int v = random.Next(vertices);
            int w = random.Next(vertices);

            addEdge(v, w);
        }
    }




    int computeMaxEdges(int numOfVertices)
    {
        return numOfVertices * ((numOfVertices - 1) / 2);
    }

    void addEdge(int v, int w)
    {
        edgeList.TryAdd((v, w), new Edge(adjacencyList.Keys.ToList()[v], adjacencyList.Keys.ToList()[w], Instantiate(edge, Vector3.back, Quaternion.identity), random.Next(20)));
        adjacencyList[adjacencyList.Keys.ToList()[v]].Add(adjacencyList.Keys.ToList()[w]);

        adjacencyList[adjacencyList.Keys.ToList()[w]].Add(adjacencyList.Keys.ToList()[v]);
    }
}
