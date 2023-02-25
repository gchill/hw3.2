using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
   public static int PinCount;
   public static int TempScore;
   public Text text;
   public Text Score;

   void Start()
   {
      PinCount = 0;
    
   }
   void Update()
   {
      Score.text = PinCount.ToString();
   }
}
