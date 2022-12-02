using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem5 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            if (gameObject.GetComponent<ParticleSystem>().isPlaying == true)
            {
                gameObject.GetComponent<ParticleSystem>().Stop();
            }
            else
            {
                gameObject.GetComponent<ParticleSystem>().Play();
            }
    }
}
