using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject[] Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F1))
        {
            Camera[0].SetActive(true);
            Camera[1].SetActive(false);
        }
        if (Input.GetKey(KeyCode.F2))
        {Camera[1].SetActive(true);
            Camera[0].SetActive(false);}
    }
}
