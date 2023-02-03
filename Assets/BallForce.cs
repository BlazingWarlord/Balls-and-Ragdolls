using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    float delay;
    float countdown;
    public Rigidbody2D rb;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        delay = Random.Range(2f, 5f);
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0)
        {
            speed = Random.Range(10f, 20f);
            rb.velocity = (transform.up * speed);
            rb.velocity = (transform.right * speed);
            delay = Random.Range(2f, 5f);
            countdown = delay;
        }
        countdown -= Time.deltaTime;
    }
}
