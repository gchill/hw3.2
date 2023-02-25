using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float RSpeed = Data.RSpeed;

    public void Update()
    {
        transform.Rotate(0f,0f,Data.RSpeed*Time.deltaTime);
        
    }
}
