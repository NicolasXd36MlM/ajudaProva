using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    GameObject moedaPrefab;

    private void Start()
    {
        spawn();
    }
    void spawn() 
    {
        for (int i = 0; i < 10; i++) 
        {
            Instantiate(moedaPrefab, new Vector3(Random.Range(-8, 8), Random.Range(-1, 4)), Quaternion.identity);
        }       
    }
}
