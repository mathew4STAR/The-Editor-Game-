using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincount : MonoBehaviour
{
    public int count = 0;
    public GameObject countText;
    public score scr;
    public AudioSource coinpickup;

    void Start()
    {
        scr = countText.GetComponent<score>();
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


