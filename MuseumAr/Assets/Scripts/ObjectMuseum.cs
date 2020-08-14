using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMuseum : MonoBehaviour
{
    public bool unlock;
    public Text info;
    public GameObject button;
    public string infoString;

    // Start is called before the first frame update
    void Start()
    {
        unlock = true;
    }

    // Update is called once per frame
    void Update()
    {
        //se encarga de transformar el texto asignado, a un texto definido por el string del objeto
        if(unlock == true)
        {
            info.GetComponent<UnityEngine.UI.Text>().text = infoString;
        }

        //info.GetComponent<UnityEngine.UI.Text>().text = infoString;

    }
    // esta funcion quedo obsoleta, ya que el objeto no deberia desbloquear su boton
    public void unlockButton(int objectId)
    {

    }
}
