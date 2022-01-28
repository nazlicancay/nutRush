using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class DolorController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Dolar;
    public ScoreManager score;
    public GameObject Player;
    public List<GameObject> dolors = new List<GameObject>();
    private float incy;
    public Transform target;
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dolor()
    {

        for (int i = 10; i< score.StackScore; i += 10)
        {
            GameObject newDolor = Instantiate(Dolar);
            dolors.Add(newDolor);
            newDolor.transform.DOMoveY(target.position.y + 0.2f*i/10, 2f);
            Player.transform.DOMoveY(target.position.y + 0.21f * i / 10, 2f);

        }



    }
    public Vector3 HandTarget()
    {
        Transform gm = Dolar.transform.GetChild(0);
        return new Vector3( gm.position.x, gm.position.y, gm.position.z) ;
    }
}
