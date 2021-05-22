using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadGame(){
         SceneManager.LoadScene("SampleScene"); 
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("QUIT!");
    }
      
   
}

    
