using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI dolarCount;
    public LevelManager levelManager;
    public ScoreManager scoreManager;
    public GameObject AllHeart;
    public DolorController dolorController;
    public HeartFill heartFill;
    public Button nextlevelbutton;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dolorController.DolorEnded)
        {
            AllHeart.SetActive(true);
            scoreManager.addGameScore();
            dolarCount.text = scoreManager.addGameScore().ToString();
            dolorController.DolorEnded = false;

          
        }
        if (heartFill.heartFilled)
        {
            nextlevelbutton.gameObject.SetActive(true);
        }
    }
}
