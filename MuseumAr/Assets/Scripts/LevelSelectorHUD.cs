﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorHUD : HUDManager
{
    public override void Loadlevel(string level)
    {
        SceneManager.LoadScene(level);
        //SetMenuOff();
    }

    public override void SetMenuActive(GameObject gameObject)
    {
        throw new System.NotImplementedException();
    }

    public override void SetMenuOff(GameObject gameObject)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {// se encarga de comprar si el menu deberia activarse, en case de ser esto necesario se activa
        if(MenuManagerHUD.instance.unlock == true)
        {
            menus[1].SetActive(true);
            MenuManagerHUD.instance.unlock = false;
        }
    }

}
