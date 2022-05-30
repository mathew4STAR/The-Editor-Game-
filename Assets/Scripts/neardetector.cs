using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neardetector : MonoBehaviour
{
    private float x_dis;
    public bool go = false;
    public Transform parent;
    public float offset = 0.7f;
    public GameObject hint;
    public AudioSource movesound;
    public state st;

    public void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.tag == "collector")
        {
            parent = other.gameObject.transform.root;
            st = parent.GetComponent<state>();
            go = true;
            hint.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "collector")
        {
            go = false;
            hint.SetActive(false);
        }
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(go == true)
        {
            if(Input.GetKeyDown("up") && st.mademove == false)
            {
                parent.transform.Translate(Vector3.forward * offset);
                movesound.Play();
                st.mademove = true;
            }
            if(Input.GetKeyDown("down") && st.mademove == false)
            {
                parent.transform.Translate(Vector3.back * offset);
                movesound.Play();
                st.mademove = true;
            }
            if(Input.GetKeyDown("left") && st.mademove == false)
            {
                parent.transform.Translate(Vector3.right * offset);
                movesound.Play();
                st.mademove = true;
            }
            if(Input.GetKeyDown("right") && st.mademove == false)
            {
                parent.transform.Translate(Vector3.left * offset);
                movesound.Play();
                st.mademove = true;
            }
        }
    }
}
