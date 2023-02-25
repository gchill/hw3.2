using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Data : MonoBehaviour
{
   public static string PlayerName;
   public static float RSpeed;
   public static float PSpeed;
   
   public InputField PlayerNameInput;
   public Text ShowPlayerName;
   public Slider RSlider;
   public Slider PSlider;
   public Text RText;
   public Text PText;
   public GameObject Rotator;
   public GameObject Pin;
   public Rigidbody2D rb;

   public void ShowName()
   {
      PlayerName = PlayerNameInput.text;
      
   }
   public void Start()
   {
      ShowPlayerName.text = PlayerName;
        transform.Rotate(0f,0f,RSpeed*Time.deltaTime);
   }
   public void Update()
   {
      RSpeed = RSlider.value;
      PSpeed = PSlider.value;
      RText.text = RSpeed.ToString("Rotator Speed: " + RSpeed);
      PText.text = PSpeed.ToString("Pin Speed: " + PSpeed);
      rb.MovePosition(rb.position + Vector2.up * PSpeed * Time.deltaTime);
      transform.Rotate(0f,0f,RSpeed*Time.deltaTime);
   }
}
