using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletFire : MonoBehaviour
{
    public int score;
    public float speed;
    public Rigidbody2D rb;

    private void Update()
    {
        rb.velocity = transform.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Destroy")
        {
            Destroy(gameObject);
            Debug.Log(score);
        }
    }
}