using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem2 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
            if(gameObject.GetComponent<ParticleSystem>().isPlaying == true)
            {
                gameObject.GetComponent<ParticleSystem>().Stop();
                print("STOPPING PARTICLE");
            }
            else
            {
                gameObject.GetComponent<ParticleSystem>().Play();
                print("BEGINNING PARTICLE");
            }
    }
}
