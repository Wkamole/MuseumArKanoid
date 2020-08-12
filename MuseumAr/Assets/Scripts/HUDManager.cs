using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class HUDManager : MonoBehaviour
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
    }

    // Update is called once per frame
    void Update()
    {

    }

    public abstract void SetMenuActive(GameObject gameObject);


    public abstract void SetMenuOff(GameObject gameObject);


    public abstract void Loadlevel(string level);

}
