using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{

    public string levelOne;

   public void OnPlayButtonPressed()
   {
     if(levelOne == "Level One")
     {
         SceneManager.LoadScene(levelOne);
     }
     else
     {
        Debug.Log("You don't have the correct scene name"); 
     }
   }
}
