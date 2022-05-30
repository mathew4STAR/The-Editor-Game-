using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public Text scoretext;
    public int score_num;
    public GameObject winscreen;

    void Update()
    {
        scoretext.text = "Score: " + score_num.ToString();
        if(score_num == 2)
        {
            winscreen.SetActive(true);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void NextLevel()
    {
        //Debug.Log("Not there yet");
        SceneManager.LoadScene("level2");
    }
}
