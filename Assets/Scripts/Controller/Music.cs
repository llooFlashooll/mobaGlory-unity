using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource audio;
    private int count = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
           Application.Quit();

        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            count = count + 1;
            if(count % 2 == 0)
            {
                audio.Play();
            }
            else if(count % 2 == 1)
            {
                audio.Pause();
            }
            
        }
    }
}
