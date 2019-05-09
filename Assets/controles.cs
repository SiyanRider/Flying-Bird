using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controles : MonoBehaviour
{
    private Rigidbody2D joueur;
    Vector2 voler = new Vector2();
    Vector2 gravité = new Vector2();
    // Start is called before the first frame update
    void Start()
    {
        joueur = GetComponent<Rigidbody2D>();
        gravité = Vector2.right;
        joueur.AddForce(gravité * 150);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            voler = Vector2.up;
            joueur.AddForce(voler * 100);
        }  
        if (Input.GetKeyUp(KeyCode.Space))
        {
            voler = Vector2.up;
            joueur.AddForce(voler*0);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D bang)
    {
        //Si l'oiseau entre en colision avec le bord droit
        if (bang.gameObject.name == "ghost_object_droite")
        {
            joueur.transform.Rotate(0,180,0);
            gravité = Vector2.left;
            joueur.AddForce(gravité * 150);

        }
        //Si il entre en colision avec le coté gauche
        if (bang.gameObject.name == "ghost_object_gauche")
        {
            joueur.transform.Rotate(0,180,0);
            gravité = Vector2.right;
            joueur.AddForce(gravité * 150);
        }
    }
    }
