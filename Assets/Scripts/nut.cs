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
        if(newState == NutState.shattered)
        {
            sheld.SetActive(false);
            shattered.SetActive(true);
            sheldless_nut.SetActive(true);
        }

        if (newState == NutState.chocolate)
        {
            sheld.SetActive(false);
            chocolate.SetActive(true);
        }

        if (newState == NutState.nutChocolate)
        {
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
            Debug.Log("lşfklsf");
        }
    }
}
