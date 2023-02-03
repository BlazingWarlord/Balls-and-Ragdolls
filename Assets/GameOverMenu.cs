using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    float level;
    int[] levellist = { 1, 4 };
    // Start is called before the first frame update
    public void PlayGame()
    {
    level = Random.Range(0, 2);
    SceneManager.LoadScene(levellist[(int)level]);
        
        
}
    public void Quit_Game()
    {
        Application.Quit();
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(3);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    
}

