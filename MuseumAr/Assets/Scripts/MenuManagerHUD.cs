﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerHUD : HUDManager
{
    public override void Loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    public static MenuManagerHUD instance;
    public int count;
    public bool unlock;

    // Start is called before the first frame update
    void Start()
    {
        unlock = false;
        menus[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCount(int i)
    {
        count = i;
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    public override void SetMenuActive(GameObject gameObject)
    {
       // SetMenuOff();
        gameObject.SetActive(true);
    }

    public override void SetMenuOff(GameObject gameObject)
    {
        gameObject.SetActive(false);
        /* for (int i = 0; i < menus.Count; i++)
         {
             menus[i].SetActive(false);
         }*/
    }

    /*   for(int i = 0;i<4;i++)
   {
       menus[i].SetActive(false);
   }

SetMenuOff();
gameObject.SetActive(true);*/
}