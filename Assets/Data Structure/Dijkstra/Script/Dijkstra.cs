using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dijkstra : MonoBehaviour
{
    public RandomGraph randomGraph;
    int V;
    int src;
    // Start is called before the first frame update
    void Start()
    {
        src = 0;
    }

    int minDistance(int[] dist, bool[] sptSet)
    {
        int min = int.MaxValue, min_index = -1;

        for (int v = 0; v < V; v++)
            if (sptSet[v] == false && dist[v] <= min)
            {
                min = dist[v];
                min_index = v;
            }

        return min_index;
    }


    public void dijkstra()
    {
        V = randomGraph.vertices;
        int[] dist = new int[V];
        bool[] sptSet = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        dist[src] = 0;
        var mat = randomGraph.adjacencyList.Keys.ToList()[src].Element.GetComponentsInChildren<Renderer>()[1].material;
        mat.color = Color.white;
        for (int count = 0; count < V - 1; count++)
        {
            int u = minDistance(dist, sptSet);
            sptSet[u] = true;
            for (int v = 0; v < V; v++)
            {

                if (randomGraph.edgeList.ContainsKey((u, v)))
                {
                    var e = (randomGraph.edgeList.GetValueOrDefault((u, v)));
                    var value = e.weight;

                    var line=e.Element.GetComponent<LineRenderer>();
                    float alpha = 1.0f;
                    Gradient gradient = new Gradient();
                    gradient.SetKeys(
                        new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.yellow, 1.0f) },
                        new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
                    );
                    line.colorGradient = gradient;
                    if (!sptSet[v] && value != 0
                        && dist[u] != int.MaxValue
                        && dist[u] + value < dist[v])
                        dist[v] = dist[u] + value;
                }

            }
        }
    }

        void Update(){
        if(Application.platform==RuntimePlatform.Android){
            if(Input.GetKey(KeyCode.Escape)){
                SceneManager.LoadScene("Data Structure");
                return;
            }
        }
    }
}
