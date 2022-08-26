using UnityEngine;

public class SecondClass : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        Debug.Log("Second script was started");
    }

    void Update()
    {
        //Debug.Log("Second Class is working successfully");
        if (Input.GetKey(KeyCode.E))
        {
            gameManager.NextScript(this);
        }
    }
}
