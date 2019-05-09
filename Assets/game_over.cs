using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;

public class game_over : MonoBehaviour
{
    public Text gameOverText;
    private Rigidbody2D joueur;
    // Start is called before the first frame update
    void Start()
    {
        
        joueur = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D bang)
    {
        if ((bang.gameObject.name == "spikes(Clone)") || (bang.gameObject.name == "spikes_2(Clone)"))
        {
            gameOverText.text = "Game Over";
            Destroy(joueur);
            Task.Delay(5000);
            SceneManager.LoadScene("Jeu");
        }
    }

    }
