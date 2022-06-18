using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameplayUI : MonoBehaviour
{
   public void RestartButton(){
       SceneManager.LoadScene("Gameplay");

   }
   public void HomeButton(){
       SceneManager.LoadScene("MainMenu");
   }
}
