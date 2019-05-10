using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;

public class game_over : MonoBehaviour
{
    public Text gameOverText, retry;
    private Rigidbody2D joueur;
    bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        
        joueur = GetComponent<Rigidbody2D>();
        gameover = false;
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
            retry.text = "press Enter to retry";
            Destroy(joueur);
            gameover = true;
        }
    }
    private void FixedUpdate()
    {
        if (gameover)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                SceneManager.LoadScene("Jeu");
            }
        }
      
    }

}
