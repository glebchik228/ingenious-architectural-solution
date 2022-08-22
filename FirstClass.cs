using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstClass : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log("First Class is working successfully");
        if (Input.GetKey(KeyCode.Q))
        {
            gameManager.ScriptDestroy(this);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameManager.NextScript(this);
        }
    }
}
