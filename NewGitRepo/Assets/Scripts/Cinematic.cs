using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematic : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float speed;

    public Vector3 pos;
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();

        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.velocity = new Vector2(speed, playerRb.velocity.y);
    }

    void OnBecameInvisible()
    {

        Instantiate(playerPrefab, pos, transform.localRotation);
        Destroy(this.gameObject);
    }

}
