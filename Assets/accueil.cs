using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*Auteur : Yanis PETIT
 * Date : 10/05/2019
 * 
Ce script Unity sert à afficher la scene "Accueil" du jeu et à laner la scene "Jeu" lors d'un appui sur la touche espace.

    */
public class accueil : MonoBehaviour
{
    private Rigidbody2D joueur;
    public Text spacebar;
    // Start is called before the first frame update
    void Start()
    {
        spacebar.text = "Press spacebar to begin";
        joueur = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Jeu");
        }
    }
}
