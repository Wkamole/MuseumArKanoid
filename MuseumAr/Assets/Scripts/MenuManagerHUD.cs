using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Esta clase se encarga de controlar los menus principales y funciona a mode de clase centrar donde guardar la informacion, debido a que no se destruye
public class MenuManagerHUD : HUDManager
{
    // override de la clase HUDManager, permite cargar la escena deseada
    public override void Loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    
    public static MenuManagerHUD instance;

    //banderas usadas para comprobar el desbloqueo de objeto, son provicionales, ya que el producto final deberia tener un sistema de guardado de data que ayude a no necesitar de esto
    public int count;
    public bool unlock;
    public bool unlock2;

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

    //Permite asignar un valor deseado al contador
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

    //Override de la clase HUDManager, permite activar un game objetc
    public override void SetMenuActive(GameObject gameObject)
    {
       // SetMenuOff();
        gameObject.SetActive(true);
    }
    //Override de la clase HUDManager, permite desactivar un game objetc
    public override void SetMenuOff(GameObject gameObject)
    {
        gameObject.SetActive(false);

    }


}
