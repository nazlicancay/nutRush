using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> levels = new List<GameObject>();
    public Transform targets;
    public GameObject Player;

    private void Awake()
    {
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLevel()
    {
        int index = PlayerPrefs.GetInt("LevelNum");

        for(int i =0; i < levels.Count; i++)
        {
            if (i != index)
            {
                levels[i].SetActive(false);
            }
            else
            {
                levels[index].SetActive(true);
                
                //sPlayer.transform.DOMove()
            }
        }
       
    }
}
