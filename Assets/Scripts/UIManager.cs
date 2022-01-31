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
    public Image Heart;
    public float waitTime = 30.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (levelManager.NextLevel)
        {
            dolarCount.text = (PlayerPrefs.GetInt("GameScore").ToString());
            Heart.fillAmount  -= 1.0f / waitTime * Time.deltaTime;

        }
    }
}
