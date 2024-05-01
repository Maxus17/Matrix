using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject setMenu;
    public GameObject levelMenu;
    public GameObject Parallax;
    public GameObject winterParallax;
    void Start()
    {
        ShowMainMenu();
        Debug.Log("start");
    }

    private void Awake()
    {
        ShowMainMenu();
        Debug.Log("awake");
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        Parallax.SetActive(true);
        winterParallax.SetActive(false);
        HideMenuSet();
        HideLevelMenu();
    }
    public void HideMainMenu()
    {
        mainMenu.SetActive(false);
    }

    public void ShowMenuSet()
    {
        setMenu.SetActive(true);
        HideMainMenu();
    }
    public void HideMenuSet()
    {
        setMenu.SetActive(false);
    }

    public void ShowLevelMenu()
    {
        levelMenu.SetActive(true);
        winterParallax.SetActive(true);
        //Parallax.SetActive(false);
        //HideMainMenu();
    }
   public void HideLevelMenu()
    {
        levelMenu.SetActive(false);
    }
}
