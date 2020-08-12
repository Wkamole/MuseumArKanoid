using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Library : MonoBehaviour
{

    public List<ObjectMuseum> objects;
    // Start is called before the first frame update
    void Start()
    {
        //se activa el objeto correspondiente al count de menuManagerHud
        for(int i = 0; i < objects.Count;i++)
        {
            if (MenuManagerHUD.instance.count == i)
            {
                objects[i].gameObject.SetActive(true);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}
