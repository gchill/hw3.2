using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
   public Dropdown ColorDropdown; 
   public Text ColorText;
   public GameObject rotator;

    void Start()
    {
        rotator.GetComponent<Renderer>().material.color = Color.black;
    }
    public void ChooseColor()
    {
        switch (ColorDropdown.value)
        {
           case 1:
                ColorText.text = ColorDropdown.options[2].text;
                rotator.GetComponent<Renderer>().material.color = new Color(255,0,0);
                break;
        }
    }
}
