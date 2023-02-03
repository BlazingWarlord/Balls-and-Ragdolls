using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball_Collide : MonoBehaviour
{
    public Collider2D col;
    public GameObject explosion;
    public GameObject player;
    private float delay = 3f;
    float countdown;
    public GameObject ui;
    TimeCounter tc;
    Collision2D coll;
    public int count;
    
    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
        tc = ui.GetComponent<TimeCounter>();
        countdown = delay;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player" && count == 0)
        {

            coll = collision;
            count += 1;
            AfterCollide(coll);

        }
        
    }
    void AfterCollide(Collision2D colli)
    {
        Instantiate(explosion, colli.transform.position, colli.transform.rotation);
        //Destroy(explosion);
        Destroy(player);
        Destroy(gameObject);
        tc.GO = true;
        
        while (countdown > 0)
        {
            countdown -= Time.deltaTime;

        }
        SceneManager.LoadScene(2);
    }
}
