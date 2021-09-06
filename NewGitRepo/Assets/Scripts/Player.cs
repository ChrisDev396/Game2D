using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{

    private SpriteRenderer playerSprite;
    public bool flipX;

    private Rigidbody2D playerRb;
    public  float speed;
    public float arm, arm2;
    float p;
    
    // Start is called before the first frame update
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();

        playerRb = GetComponent<Rigidbody2D>();
        p = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (p == 1)
        {
            if (Rank.pontos >= 3)
            {
                p = 2;
                speed = speed * 1.5f;

            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            flipX = !flipX;
            playerSprite.flipX = flipX;
            speed = speed * -1;
            
        }

        playerRb.velocity = new Vector2(speed, playerRb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Espinho")
        {
            SceneManager.LoadScene("GameOver");
            print("Chuva de espinhos");
        }
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "Espinho")
        {
            SceneManager.LoadScene("GameOver");
            print("Parede de espinhos");
        }
    }
}
