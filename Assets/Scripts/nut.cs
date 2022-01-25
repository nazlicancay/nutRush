using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nut : MonoBehaviour
{
    // Start is called before the first frame
    public GameObject sheld;
    public GameObject shattered;
    public GameObject sheldless_nut;
    public GameObject chocolate;
    public GameObject nutChocolate;
    public GameObject package;
    public NutState currentState;
    public List<GameObject> shelds = new List<GameObject>();






    public enum NutState
    {
        sheld,
        shattered,
        nut,
        chocolate,
        nutChocolate,
        package

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeState( NutState newState)
    {
        if(newState == NutState.shattered && currentState == NutState.sheld)
        {
            currentState = NutState.nut;
            sheld.SetActive(false);
            shattered.SetActive(true);
            Smash();
            sheldless_nut.SetActive(true);
        }

        if (newState == NutState.chocolate && currentState == NutState.nut)
        {
            currentState = NutState.chocolate;
            sheldless_nut.SetActive(false);
            sheld.SetActive(false);
            chocolate.SetActive(true);
        }

        if (newState == NutState.nutChocolate && currentState == NutState.chocolate)
        {
            currentState = NutState.nutChocolate;
            chocolate.SetActive(false);
            nutChocolate.SetActive(true);
        }

        if (newState == NutState.package)
        {
            nutChocolate.SetActive(false);
            package.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NutBreaker"))
        {
            ChangeState(NutState.shattered);
        }

        if (other.gameObject.CompareTag("Chocolate_Door"))
        {
            ChangeState(NutState.chocolate);
        }

        if (other.gameObject.CompareTag("NutCellMac"))
        {
            ChangeState(NutState.nutChocolate);
        }
    }

    public void Smash()
    {
        Debug.Log("smah");
        float range = 10.0f;
        float force = 100.0f;

        foreach (GameObject Gm in shelds)
        {
           Rigidbody rb = Gm.GetComponent<Rigidbody>();
         
           rb.AddExplosionForce(force , new Vector3( transform.position.x , transform.position.y, transform.position.z) ,range);
            
        }
       
    }
}