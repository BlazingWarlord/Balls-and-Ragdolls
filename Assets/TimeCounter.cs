using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text score;
    public int time;
    float counter;
    public Transform ballpos;
    int count30;
    public GameObject ball;
    public bool GO = false;
    static int final_score;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Current Score", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(GO);
        if (GO != true)
        {
            score.text = "Time: " + time.ToString();
            counter += Time.deltaTime;
            
            if (counter >= 1)
            {
                time += 1;
                PlayerPrefs.SetInt("Current Score", time);
                count30 += 1;
                counter = 0f;
            }
            if (count30 >= 30)
            {
                Instantiate(ball, ballpos.position, ballpos.rotation);
                count30 = 0;
            }
        }
       
    }
}
