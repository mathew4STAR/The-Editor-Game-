using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderlevel2 : MonoBehaviour
{
    public Slider _slider;
    public GameObject bot1;
    public GameObject bot2;
    public GameObject bot3;
    public GameObject bot4;
    private Animator bot1Animator;
    private Animator bot2Animator;
    private Animator bot3Animator;
    private Animator bot4Animator;
    // Start is called before the first frame update
    void Start()
    {
        bot1Animator = bot1.GetComponent<Animator>();
        bot2Animator = bot2.GetComponent<Animator>();
        bot3Animator = bot3.GetComponent<Animator>();
        bot4Animator = bot4.GetComponent<Animator>();
        _slider.onValueChanged.AddListener((v) =>{
            bot1Animator.SetFloat("time", v);
            bot2Animator.SetFloat("time", v);
            bot3Animator.SetFloat("time", v);
            bot4Animator.SetFloat("time", v);
        });
    }
}
