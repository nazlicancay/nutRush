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
    public NutManager nutManager;
    public GameObject target;
    public int levelCount;

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
        nutManager.finsih = false;
        target.transform.DOMove(new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), 0.01f);
        target.transform.parent = Player.transform;
        nutManager.stack.Clear();
        nutManager.stack.Add(target);
        dolorController.DolorEnded = false;
        Player.transform.DOMove(new Vector3(targets.transform.position.x, targets.transform.position.y, targets.transform.position.z), 0.5f);
        GameManager.Instance.GameActive = true;

       
    }
}
