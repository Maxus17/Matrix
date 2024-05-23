using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLvl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col){
        
          
        var SceneInd = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }
       
    
    
}
