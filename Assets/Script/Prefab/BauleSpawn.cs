using UnityEngine;
using System;
using System.Collections.Generic;

public class BauleSpawn : MonoBehaviour
{
    public GameObject baule;
    public GameObject coin;

    [SerializeField]
    Vector3 pos_baule;

    // lista per verificare di non instanziare i prefab nella stessa posizione

    List<Vector3> vectorList = new List<Vector3>();
    Vector3 coinPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // lato destra della stanza
        for (int i = 0; i < 2; i++)
        {
            float x = -7.989f;
            float z = UnityEngine.Random.Range(-14.202f, -6.66f);
            float y = 0.3f;

            Vector3 newVector = new Vector3(x, y, z);

            if (!vectorList.Contains(newVector))
            {
                vectorList.Add(newVector);
            }


            pos_baule = newVector;
            Instantiate(baule, pos_baule, Quaternion.identity);
            coinPos = pos_baule + new Vector3(0.45f, 0.09f, 0);
            Instantiate(coin, coinPos, Quaternion.Euler(0, 0, -90));
        }

        // lato sinistra della stanza
        for (int i = 0; i < 1; i++)
        {
            float x = 5.259f;
            float z = UnityEngine.Random.Range(-6.651f, -12.317f);
            float y = 0.3f;

            Vector3 newVector = new Vector3(x, y, z);

            if (!vectorList.Contains(newVector))
            {
                vectorList.Add(newVector);
            }


            pos_baule = newVector;
            Instantiate(baule, pos_baule, Quaternion.identity);
            coinPos = pos_baule + new Vector3(0.5f, 0.08f, 0);
            Instantiate(coin, coinPos, Quaternion.Euler(0, 0, -90));
        }

        // sopra all'armadio
        Vector3 newVectorArmadio = new Vector3(-3.651f, 3.896f, -13.893f);
        pos_baule = newVectorArmadio;
        Instantiate(baule, pos_baule, Quaternion.identity);
        coinPos = pos_baule + new Vector3(0.5f, 0.09f, 0);
        Instantiate(coin, coinPos, Quaternion.Euler(0, 0, -90));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
