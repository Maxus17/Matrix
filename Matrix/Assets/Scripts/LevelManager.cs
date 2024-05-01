using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadNextLevel()
    {
        var SceneInd = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneInd + 1);
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
}