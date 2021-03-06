﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerMenu : MonoBehaviour {

    public GameObject homeMenu;
    public GameObject menu1Menu;
    public GameObject menu2Menu;
    public GameObject menu4Menu;
    public GameObject menu5Menu;
    public GameObject activeMenu;

    public Button practice;

    public Toggle button1;
    public Toggle button2;
    public Toggle buttonHome;
    public Toggle button4;
    public Toggle button5;


    // Use this for initialization
    void Awake ()
    {
        homeMenu.SetActive(true);
        activeMenu = homeMenu;
        menu1Menu.SetActive(false);
        menu2Menu.SetActive(false);
        menu4Menu.SetActive(false);
        menu5Menu.SetActive(false);
        
    }

    void Start()
    {
        buttonHome.Select();
    }

    // Update is called once per frame
    void Update ()
    {
        if(button1.isOn)
        {
            activeMenu.SetActive(false);
            menu1Menu.SetActive(true);
            activeMenu = menu1Menu;
        }
        if (button2.isOn)
        {
            activeMenu.SetActive(false);
            menu2Menu.SetActive(true);
            activeMenu = menu2Menu;
        }
        if (buttonHome.isOn)
        {
            activeMenu.SetActive(false);
            homeMenu.SetActive(true);
            activeMenu = homeMenu;
        }
        if (button4.isOn)
        {
            activeMenu.SetActive(false);
            menu4Menu.SetActive(true);
            activeMenu = menu4Menu;
        }
        if (button5.isOn)
        {
            activeMenu.SetActive(false);
            menu5Menu.SetActive(true);
            activeMenu = menu5Menu;
        }

        practice.onClick.AddListener(() => PracticeClicked());

    }

    void PracticeClicked()
    {
        Debug.Log("Opened");
        practice.onClick.RemoveListener(() => PracticeClicked());
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
