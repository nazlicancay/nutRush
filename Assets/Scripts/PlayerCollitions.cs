using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class PlayerCollitions : MonoBehaviour
{
    // Start is called before the first frame update
    public NutManager nutManager;
    public Collactor collactor;
    public ScoreManager scoreManager;
    public DolorController dolorController;
    public LevelManager levelManager;

    public Vector3 handTarget = new Vector3();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("nut"))
        {

            //nutManager.ReOrder();
            collactor.Collact(other.gameObject);
            scoreManager.CalculateScore();
        }

        if (other.gameObject.CompareTag("AddDolor"))
        {
            GameManager.Instance.GameActive = false;

            transform.DORotate(new Vector3(0, 0, 180f), 1f);
            transform.DOMoveZ(-38,1f);
            dolorController.Dolor();








        }
    }
}
