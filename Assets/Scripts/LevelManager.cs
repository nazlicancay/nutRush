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
    public DolorController dolorController;

    private void Awake()
    {
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dolorController.DolorEnded)
        {
            UpdateLevel();
            GameManager.Instance.StartLevel();
        }
    }

    public void UpdateLevel()
    {
        int index = PlayerPrefs.GetInt("LevelNumber");

        levels[index-1].SetActive(true);
        Player.transform.DOMove(new Vector3(targets.transform.position.x, targets.transform.position.y, targets.transform.position.z), 0.5f);
        GameManager.Instance.GameActive = true;
       
    }
}
