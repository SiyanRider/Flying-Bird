using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
