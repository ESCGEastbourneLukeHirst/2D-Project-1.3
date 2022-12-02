using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem4 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
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