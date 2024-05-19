using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEngine : MonoBehaviour
{
    public Image musicButton;
    public bool isOn;
    public Sprite MusicOn;
    public Sprite MusicOff;
    
    void Start()
    {
        isOn = true;
    }

    public void OnOffSound()
    {
        if(!isOn)
        {
            AudioListener.volume = 1.0f;
            isOn = true;
            musicButton.GetComponent<Image>().sprite = MusicOn;

        }
        else if(isOn)
        {
            AudioListener.volume = 0f;
            isOn = false;
            musicButton.GetComponent<Image>().sprite = MusicOff;
        }
    }

    public void NextLocation(int sceneNumb)
    {
        SceneManager.LoadScene(sceneNumb);

    }
    
}
