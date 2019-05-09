using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class randomspikes : MonoBehaviour
{
    public Text scoreAfficher;
    public int score;
    int nb_spikes;
    public GameObject rnd_spikes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        instance_spikes(score);
        print(nb_spikes);
    }
    void OnCollisionEnter2D(Collision2D bang)
    {
        if (bang.gameObject.name == "ghost_object_droite")
        {
            for (int i = 0; i < nb_spikes; i++)
            {
                Instantiate(rnd_spikes, new Vector3(-7f, UnityEngine.Random.Range(-3.7f, 3.8f), 0), Quaternion.identity);
            }
        }
        if (bang.gameObject.name == "ghost_object_gauche")
        {

        }
    }
    private int instance_spikes(int scoreJoueur)
    {
        if (scoreJoueur<3)
        {
            nb_spikes = 2;
        }
        else if (scoreJoueur <5)
        {
            nb_spikes = 3;
        }
        else if (scoreJoueur <7)
        {
            nb_spikes = 5;
        }
        else if (scoreJoueur < 15)
        {
            nb_spikes = 6;
        }
        else if (scoreJoueur <20)
        {
            nb_spikes = 7;
        }
        else
        {
            nb_spikes = 10;
        }
        return nb_spikes;
    }
}
