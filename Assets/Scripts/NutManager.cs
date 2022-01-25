using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class NutManager : Singleton<NutManager>
{
    // Start is called before the first frame update
    public List<GameObject> stack = new List<GameObject>();
   // public List<GameObject> MoveList = new List<GameObject>();

    public GameObject nutTarget;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveRightLeft();
    }

    public void ReOrder()
    {
        for (int i = 0; i < stack.Count; i++)
        {
            stack[i].transform.DOMoveZ(nutTarget.transform.position.z  -0.5f*i , 0.5f);
        }

    }

    public void moveRightLeft()
    {
        //MoveList = stack;

        for (int i = 0; i < stack.Count - 1; i++)
        {

            stack[i + 1].transform.DOMoveX(stack[i].transform.position.x, 0.1f).SetEase(Ease.InOutBounce);

        }
    }
}
