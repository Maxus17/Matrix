using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinterMenu : MonoBehaviour
{
    public GameObject levelMenu;
    public GameObject parallax;
    public GameObject menuSet;
    public GameObject lvl1;
    //public static WinterMenu Ins;

    private void Start()
    {
        ShowLevelMenu();
    }

    /*private void Awake()
    {
        if (Ins == null)
        {
            Ins = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }*/

    public void ShowLevelMenu()
    {
        levelMenu.SetActive(true);
        parallax.SetActive(true);
        HideMenuSet();
        HideLVL1();
    }
    public void HideLevelMenu()
    {
        levelMenu.SetActive(false);
    }

    public void ShowLVL1()
    {
        lvl1.SetActive(true);
        parallax.SetActive(false);
        HideMenuSet();
        HideLevelMenu();
    }
    public void HideLVL1()
    {
        lvl1.SetActive(false);
    }

    public void ShowMenuSet()
    {
        menuSet.SetActive(true);

    }
    public void HideMenuSet()
    {
        menuSet.SetActive(false);
    }
}
