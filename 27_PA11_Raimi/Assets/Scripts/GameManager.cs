using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoretxt;
    private int Score = 0;

    public static GameManager gameManager;

    

    // Start is called before the first frame update
    void Start()
    {

     if(gameManager == null)
        {
            gameManager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int score)
    {
        Score += score;
        scoretxt.text = "Score: " + Score;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameOver()
    {

        SceneManager.LoadScene("GameOver");
         
    }
}
