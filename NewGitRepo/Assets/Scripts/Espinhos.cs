using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Espinhos : MonoBehaviour
{
    private Rigidbody2D espinhoRb;
    public int atritoMax;
    private int atrito;
    public Vector3 pos;
    public GameObject espinhoPrefab;
    public float p = 1;
    // Start is called before the first frame update
    void Start()
    {
        espinhoRb = GetComponent<Rigidbody2D>();

        atrito = Random.Range(1, atritoMax);

        espinhoRb.drag = atrito;

        //-----------------

        pos = transform.position;
    }


    void OnBecameInvisible()
    {

        Instantiate(espinhoPrefab, pos, transform.localRotation);
        Rank.pontos += 1;
        Destroy(this.gameObject);
    }
}
