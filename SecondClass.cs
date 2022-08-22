using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondClass : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log("Second Class is working successfully");
        if (Input.GetKey(KeyCode.E))
        {
            gameManager.NextScript(this);
        }
    }
}
