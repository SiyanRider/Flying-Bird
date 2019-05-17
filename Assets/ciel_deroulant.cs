using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Auteur : Yanis PETIT
 * Date : 5/05/2019
 * Ce sript Unity sert à afficher un ciel déroulant en arrière plan à l'infini.
 * */

public class ciel_deroulant : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);

        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
