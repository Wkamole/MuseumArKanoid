using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerHUD : HUDManager
{
    public override void Loadlevel(string level)
    {
        throw new System.NotImplementedException();
    }
    public static MenuManagerHUD instance;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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


}
