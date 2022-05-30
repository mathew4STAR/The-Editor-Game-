using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidertestscrpt : MonoBehaviour
{
    public Slider _slider;
    public GameObject target;
    private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = target.GetComponent<Animator>();
        _slider.onValueChanged.AddListener((v) =>{
            Debug.Log(v);
            mAnimator.SetFloat("time", v);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
