using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionHUD : HUDManager
{
    public override void Loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public override void SetMenuActive(GameObject gameObject)
    {
        throw new System.NotImplementedException();
    }

    public override void SetMenuOff(GameObject gameObject)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
