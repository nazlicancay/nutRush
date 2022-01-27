using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
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
    public NutManager nutManager;
    public GameObject HandTarget;
    public ScoreManager scoreManager;






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
            scoreManager.AddScore(10);
        }

        if(newState == NutState.nut)
        {
            currentState = NutState.nut;
            chocolate.SetActive(false);
            nutChocolate.SetActive(false);
            sheldless_nut.SetActive(true);


        }

        if (newState == NutState.chocolate && currentState == NutState.nut)
        {
            currentState = NutState.chocolate;
            sheldless_nut.SetActive(false);
            sheld.SetActive(false);
            chocolate.SetActive(true);
            scoreManager.AddScore(20);
        }

        if (newState == NutState.nutChocolate && currentState == NutState.chocolate)
        {
            currentState = NutState.nutChocolate;
            chocolate.SetActive(false);
            nutChocolate.SetActive(true);
            scoreManager.AddScore(30);
        }

        if (newState == NutState.package)
        {
            sheld.gameObject.SetActive(false);
            sheldless_nut.gameObject.SetActive(false);
            chocolate.gameObject.SetActive(false);
            nutChocolate.SetActive(false);
            package.SetActive(true);
            
        }

        if (newState == NutState.package && currentState == NutState.nutChocolate)
        {
            scoreManager.AddScore(40);
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

        if (other.gameObject.CompareTag("Packer"))
        {
            ChangeState(NutState.package);

        }

        if (other.gameObject.CompareTag("FireMachine"))
        {
        
            gameObject.transform.parent = null;
            nutManager.stack.Remove(gameObject);
            Destroy(gameObject);
           


        }

        if (other.gameObject.CompareTag("Punch"))
        {
           
            for(int i =nutManager.stack.IndexOf(gameObject);i < nutManager.stack.Count-1; i++)
            {
                if(nutManager.stack.Count <= 0 || i == 0) {
                    return;
                }
                nutManager.stack[i].transform.parent = null;
                nutManager.stack[i].transform.DOMoveX(-2, 3f);

                nutManager.stack.Remove(nutManager.stack[i].gameObject);

            }
           nutManager.ReOrder();


            other.gameObject.tag = "Untagged";

        }

        if (other.gameObject.CompareTag("Hand"))
        {
            nutManager.stack.Remove(gameObject);

            gameObject.transform.parent = HandTarget.transform;
            nutManager.ReOrder();
            transform.DOMoveZ(-13.312f, 0.5f);
            other.gameObject.tag = "Untagged";

            if (currentState == NutState.sheld) scoreManager.StackScore -= 10;
            if (currentState == NutState.nut) scoreManager.StackScore -= 20;
            if (currentState == NutState.chocolate) scoreManager.StackScore -= 40;
            if (currentState == NutState.nutChocolate) scoreManager.StackScore -= 70;




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
            shattered.transform.parent = null;
          
        }

    }

   


}
