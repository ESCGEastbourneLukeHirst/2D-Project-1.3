using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public GameObject Explosion;

    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
        Destroy(Explosion, 3.0f);
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(Explosion, new Vector3(x, 6, z), Quaternion.identity);
    }
}
