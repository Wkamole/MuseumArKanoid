using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Clase encargada de manejar los menus asociados a MuseumHUD
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
    // override de la clase HUDManager, permite cargar la escena deseada
    public override void Loadlevel(string level)
    {
        SceneManager.LoadScene(level);

    }
    //Override de la clase HUDManager, permite activar un game objetc

    public override void SetMenuActive(GameObject gameObject)
    {
        gameObject.SetActive(true);

    }
    //Override de la clase HUDManager, permite desactivar un game objetc

    public override void SetMenuOff(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    //activar el menu de inicio al volver a la escena inicial
    public void goBack()
    {
        MenuManagerHUD.instance.menus[0].SetActive(true);

    }
}
