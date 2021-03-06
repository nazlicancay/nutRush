using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collactor : MonoBehaviour
{
    // Start is called before the first frame update
    public NutManager nutManager;
    public GameObject lastItem;
    public GameObject _stackObj;




    void Start()
    {
        nutManager = FindObjectOfType<NutManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collact(GameObject other)
    {
        other.gameObject.tag = "Untagged";
        if(nutManager.stack.Count != 0)
        {
            
            lastItem = NutManager.Instance.stack[nutManager.stack.Count - 1];
        }

        nutManager.stack.Add(other.gameObject);
     


        _stackObj = other.gameObject;

        _stackObj.transform.position = new Vector3(NutManager.Instance.nutTarget.transform.position.x, _stackObj.transform.position.y, lastItem.transform.position.z -0.2f);
        _stackObj.transform.parent = nutManager.nutTarget.transform;

        _stackObj.AddComponent<Collactor>();
        other.gameObject.tag = "stacked";
   
    }


}
