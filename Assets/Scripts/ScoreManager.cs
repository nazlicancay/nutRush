using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : Singleton<ScoreManager>
{
    // Start is called before the first frame update
    public int GameScore;
    public TextMeshProUGUI Text;
    public NutManager nutManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = GameScore.ToString(); 
    }

    public void CountScore()
    {
       
    }
}
