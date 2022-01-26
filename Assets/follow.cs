using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 newPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        newPos = new Vector3(target.position.x, target.position.y, target.position.z);
        transform.DOMove(newPos , 0.5f);
    }
}
