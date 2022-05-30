using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    public Slider _slider;
    public GameObject bot1;
    public GameObject bot2;
    private Animator bot1Animator;
    private Animator bot2Animator;
    // Start is called before the first frame update
    void Start()
    {
        bot1Animator = bot1.GetComponent<Animator>();
        bot2Animator = bot2.GetComponent<Animator>();
        _slider.onValueChanged.AddListener((v) =>{
            bot1Animator.SetFloat("time", v);
            bot2Animator.SetFloat("time", v);
        });
    }
}
