using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class NutManager : Singleton<NutManager>
{
    // Start is called before the first frame update
    public List<GameObject> stack = new List<GameObject>();
    public List<GameObject> packageTarget = new List<GameObject>();
    new Vector3 target;
    bool finsih = false;
    public PlayerMovement Player;

    public GameObject nutTarget;
    int j;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!finsih)
        {
            moveRightLeft();

        }
    }

    public void ReOrder()
    {
        for (int i = 0; i < stack.Count; i++)
        {
            stack[i].transform.DOMoveZ(nutTarget.transform.position.z  -0.2f * i , 0.1f);
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

    public void MoveToPackage()
    {
        //Player.Fspeed = 0.8f;
        finsih = true;
        stack.Reverse();
        for(int i = 0; i < packageTarget.Count; i++)
        {
            stack[i].transform.parent = null;
             target = new Vector3(packageTarget[i].transform.position.x, packageTarget[i].transform.position.y, packageTarget[i].transform.position.z);
            stack[i].transform.DOMove(target, 4f);
            j = i;
        }

        for (; j < stack.Count - 1; j++)
        {
            stack[j].transform.parent = null;
            stack[j].gameObject.SetActive(false);
        }
    }
}
