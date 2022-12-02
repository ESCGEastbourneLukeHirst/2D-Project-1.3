using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem1 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            if (gameObject.GetComponent<ParticleSystem>().isPlaying == true)
            {
                gameObject.GetComponent<ParticleSystem>().Stop();
                print("ENDING PARTICLE");
            }
            else
            {
                gameObject.GetComponent<ParticleSystem>().Play();
                print("STARTING PARTICLE");
            }
    }
}
