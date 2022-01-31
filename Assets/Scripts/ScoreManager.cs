using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : Singleton<ScoreManager>
{
    // Start is called before the first frame update
    public static int GameScore;
    public TextMeshProUGUI Text;
    public TextMeshProUGUI StackText;

    public NutManager nutManager;
    public nut nut;
    public int StackScore = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = GameScore.ToString();
        StackText.text = StackScore.ToString();
        PlayerPrefs.SetInt("GameScore", StackScore);


    }

    public void CalculateScore()
    {
        
        StackScore += 10;
        StackText.text = StackScore.ToString();
        
        
    }

    public void AddScore(int i )
    {
        
        StackScore += i;
        StackText.text = StackScore.ToString();


    }


    
    
}
