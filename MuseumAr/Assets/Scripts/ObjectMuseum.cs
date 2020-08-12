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
        if(unlock == true)
        {
            info.GetComponent<UnityEngine.UI.Text>().text = infoString;
        }

        //info.GetComponent<UnityEngine.UI.Text>().text = infoString;

    }

    public void unlocButton(int objectId)
    {

    }
}
