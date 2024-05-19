using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col){
        
          
        var SceneInd = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneInd + 1);
    }
       
    
    
}
