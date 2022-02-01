using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HeartFill : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Heart;
    public ScoreManager scoreManager;
    public UIManager uI;
    public int score;
    public bool heartFilled;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = scoreManager.StackScore;
       
        Heart.fillAmount += 100.0f /score * Time.deltaTime;

        if(Heart.fillAmount == 1)
        {
            heartFilled = true;
        }



    }

   
}
