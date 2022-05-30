using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cominin : MonoBehaviour
{
    public GameObject player;
    public Text button_text;
    public camera_controller cam;
    public GameObject camera;
    public AudioSource entersound;

    public void click()
    {
        if(button_text.text == "Enter")
        {
            player.SetActive(true);
            button_text.text = "Exit";
            cam.entered = true;
            entersound.Play();
        }
        else
        {
            player.SetActive(false);
            button_text.text = "Enter";
            cam.entered = false;
            entersound.Play();
        } 
        
    }
    // Start is called before the first frame update
    void Start()
    {
        cam = camera.GetComponent<camera_controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
