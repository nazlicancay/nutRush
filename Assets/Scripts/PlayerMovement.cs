using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float rotateMultiplier;
    public float swipeSpeed;
    public float maxLeftX;
    public float maxRightX;

    public float speed;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gameManager.StartGame();
        }

        if (GameManager.Instance.GameActive)
        {
            if (transform.rotation != Quaternion.identity)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime * speed);
            }

            if (GameManager.Instance.GameActive)
            {
                transform.position -= transform.forward * Time.deltaTime;
            }
        }




    }

    public void RotateCharacter(Vector2 position)
    {
        position = position.normalized;
        Quaternion rotation = Quaternion.AngleAxis(position.x * rotateMultiplier, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 2);
    }


    public void InputUpdate(Vector2 delta)
    {
        if (GameManager.Instance.GameActive)
        {
            Vector3 newPos = transform.position - new Vector3(delta.x * swipeSpeed * Time.deltaTime, 0, 0);
            newPos.x = Mathf.Clamp(newPos.x, maxRightX, maxLeftX);
            transform.position = newPos;

        }




    }
}
