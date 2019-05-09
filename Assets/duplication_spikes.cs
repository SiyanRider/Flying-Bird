using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplication_spikes : MonoBehaviour
{
    public GameObject spikes;
    float x = -6.39f;
    float y = 4.694f;
    // Start is called before the first frame update
    void Start()
    {
        //Boucle qui duplique le gameobject spikes 6 fois, en haut et en bas de la caméra 
        for (int i = 0; i < 6; i++)
        {
            Instantiate(spikes, new Vector3(x, y, 0), Quaternion.identity);
            Instantiate(spikes, new Vector3(x, -4.7f, 0), Quaternion.Euler(x, 0, 180));
            x = x + 2.5f;

        }
    }
}
