using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class ScoreCubeCreator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scoreCube;
    public List<GameObject> scoreCubes = new List<GameObject>();
    public TextMeshPro Text;
    int Score = 100;
    public int MaxScore;
    float posy = 5.6f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         CreateScoreCubes();
    }

    public void CreateScoreCubes()
    {

        if (Score < MaxScore)
        {
            GameObject clone = Instantiate(scoreCube);
            scoreCubes.Add(clone);
            scoreCubes[scoreCubes.Count -1 ].transform.DOMove(new Vector3(0, posy+=1f, -38.4f), 0.1f);
            GameObject child = scoreCubes[scoreCubes.Count - 1].transform.GetChild(0).gameObject;
            Score += 50;
            TextMeshPro text = child.GetComponentInChildren<TextMeshPro>();
            text.text = Score.ToString();
         
            
        }
        
       
       

    }
}
