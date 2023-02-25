using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
   public GameObject pinPrefab;

   void Update()
   {
    if(Input.GetButtonDown("Fire1"))
    {
        spawnpin();
    }
   }
   void spawnpin()
   {
    Instantiate(pinPrefab, transform.position, transform.rotation);
   }
}
