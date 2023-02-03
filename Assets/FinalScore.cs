using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text fsc;
    // Start is called before the first frame update
    void Start()
    {
        fsc.text = "Final Score: " + PlayerPrefs.GetInt("Current Score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
