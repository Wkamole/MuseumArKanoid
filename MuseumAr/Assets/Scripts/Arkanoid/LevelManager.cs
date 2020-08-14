using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int ID;
    public GameObject levelPrefab;
    public int tileAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateLevel()
    {
        Instantiate(levelPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
