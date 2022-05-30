using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincountlevel2 : MonoBehaviour
{
    public int count = 0;
    public GameObject countText;
    public scorelevel2 scr;
    public AudioSource coinpickup;

    void Start()
    {
        scr = countText.GetComponent<scorelevel2>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            coinpickup.Play();
            Destroy(other.gameObject);
            scr.score_num += 1;
        }
    }
    
}


