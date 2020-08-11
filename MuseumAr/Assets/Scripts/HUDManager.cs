using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDManager : MonoBehaviour
{
    public Canvas maincanvas;
    public List<GameObject> menus;
   /* public GameObject mainMenu;
    public GameObject selecctionMenu;
    public GameObject MuseumMenu;
    public GameObject QRmenu;*/

    // Start is called before the first frame update
    void Start()
    {
        menus[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMenuActive(GameObject gameObject)
    {
        SetMenuOff();
        gameObject.SetActive(true);
    }

    public void SetMenuOff()
    {
        for(int i = 0;i<4;i++)
        {
            menus[i].SetActive(false);
        }
      /*  mainMenu.SetActive(false);
        selecctionMenu.SetActive(false);
        MuseumMenu.SetActive(false);
        QRmenu.SetActive(false);*/
    }

    public void Loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }

}
