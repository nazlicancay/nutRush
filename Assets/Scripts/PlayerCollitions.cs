using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollitions : MonoBehaviour
{
    // Start is called before the first frame update
    public NutManager nutManager;
    public Collactor collactor;
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

            Debug.Log("add nut");
            //nutManager.ReOrder();
            collactor.Collact(other.gameObject);
        }
    }
}