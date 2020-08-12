using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class Scan : MonoBehaviour
{
    GameObject activate;
    

    void Start()
    {
        activate = GameObject.Find("Load1");


        if (activate.active)
        {
            Debug.Log("Activado");
            MenuManager.instace.unlock = true;
            SceneManager.LoadScene("SampleScene");
        }
    }

}
