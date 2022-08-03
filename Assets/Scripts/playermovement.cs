using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed= 2f;
    public float Runspeed= 4f;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        //run movement
         if (Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.LeftShift))
         {
        
            transform.Translate(Vector3.left*Runspeed*Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.W)& Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward*Runspeed*Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.back*Runspeed*Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.D)& Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.right*Runspeed*Time.deltaTime);
        }
    }
}
