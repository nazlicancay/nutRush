using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public bool GameActive;
    public bool GameEnded;
    public GameObject StartImange;
    public GameObject levelObj;
   
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void StartGame()
    {
        StartImange.SetActive(false);
        GameActive = true;
    }
}
