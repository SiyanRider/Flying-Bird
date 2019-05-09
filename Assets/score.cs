using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class score : MonoBehaviour
{
    private Rigidbody2D joueur;
    public int scoreJoueur, nb_spikes;
    public Text scoreAfficher;
    public GameObject rnd_spikes;
    // Start is called before the first frame update
    void Start()
    {
        scoreJoueur = 0;
        joueur = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreAfficher.text = Convert.ToString(scoreJoueur);
        instance_spikes(scoreJoueur);
    }
    private void OnCollisionEnter2D(Collision2D bang)
    {
        //A chaque colision avec le bord gauche ou droit, incrémentation du score de 1
        if ((bang.gameObject.name == "ghost_object_droite") || (bang.gameObject.name == "ghost_object_gauche"))
        {
            scoreJoueur = scoreJoueur + 1;
            
        }
        if (bang.gameObject.name == "ghost_object_droite")
        //On instancie sur l'axe Y aléatoirement des spikes, le nombre varie en fonction du score grâce à la methode instance_spikes 
        {
            for (int i = 0; i < nb_spikes; i++)
            {
                Instantiate(rnd_spikes, new Vector3(-7.11f, UnityEngine.Random.Range(-3.7f, 3.8f), 0), Quaternion.Euler(0, 0, -90));
            }
        }
        if (bang.gameObject.name == "ghost_object_gauche")
        //On instancie sur l'axe Y aléatoirement des spikes, le nombre varie en fonction du score grâce à la methode instance_spikes 
        {
            for (int i = 0; i < nb_spikes; i++)
            {
                Instantiate(rnd_spikes, new Vector3(7.114f, UnityEngine.Random.Range(-3.7f, 3.8f), 0), Quaternion.Euler(0, 0, 90));
            }
        }

    }
    private int instance_spikes(int scoreJoueur)
    {
        if (scoreJoueur < 3)
        {
            nb_spikes = 2;
        }
        else if (scoreJoueur < 5)
        {
            nb_spikes = 3;
        }
        else if (scoreJoueur < 7)
        {
            nb_spikes = 5;
        }
        else if (scoreJoueur < 15)
        {
            nb_spikes = 6;
        }
        else if (scoreJoueur < 20)
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
