using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHealthBar : MonoBehaviour
{
    public static UIHealthBar instance { get; private set; }

    float originalSize;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    public void SetValue(float value)
    {
       
    }
}
