using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuseumHUD : HUDManager
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MenuManagerHUD.instance.unlock2 == true)
        {
            button.gameObject.SetActive(true);
            MenuManagerHUD.instance.unlock2 = false;
        }
    }

    public override void Loadlevel(string level)
    {
        SceneManager.LoadScene(level);
        //SetMenuOff();
       /* if(count == 0)
        {
            Debug.Log(library.objects[0]);
            library.objects[0].gameObject.SetActive(true);
        }
        else
        {
            if(count == 1)
            {
                library.objects[1].gameObject.SetActive(true);
            }
        }*/
       // library.SetObjectActive(library.gameObject);

    }

    public override void SetMenuActive(GameObject gameObject)
    {
        gameObject.SetActive(true);

    }

    public override void SetMenuOff(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void goBack()
    {
        MenuManagerHUD.instance.menus[0].SetActive(true);

    }
}
