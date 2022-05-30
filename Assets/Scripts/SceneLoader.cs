using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{

    public GameObject about;
    public void LevelOne()
    {
        SceneManager.LoadScene("Main");
    }
    // Start is called before the first frame update
    public void About()
    {
        about.SetActive(true);
    }
    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
    public void About_Back()
    {
        about.SetActive(false);
    }
}
