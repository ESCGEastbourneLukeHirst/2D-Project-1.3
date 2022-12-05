using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject ExplosionB;
    public GameObject ExplosionC;
    public GameObject ExplosionD;

    void Start()
    {
        Invoke("SpawnObject", 0.3f);
        Destroy(Explosion, 2f);
        Destroy(ExplosionB, 3f);
        Destroy(ExplosionC, 4f);
        Destroy(ExplosionD, 5f);
    }

    void SpawnObject()
    {
        Instantiate(Explosion, new Vector2(3, 2), Quaternion.identity);
        Instantiate(ExplosionB, new Vector2(3, 2), Quaternion.identity);
        Instantiate(ExplosionC, new Vector2(3, 2), Quaternion.identity);
        Instantiate(ExplosionD, new Vector2(3, 2), Quaternion.identity);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            // After 15 seconds, Cancel the Invoked Method with this key |
            //                                                           |
            //                                                           |
            //                                                           \/
            //                                                           X
            CancelInvoke();
        }
    }
}
