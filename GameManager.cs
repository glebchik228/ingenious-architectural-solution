using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MonoBehaviour[] classes;

    private void Start()
    {
        for (int i = 1; i < classes.Length; i++)
        {
            classes[i].enabled = false;
        }
    }

    public void ScriptDestroy(object obj)
    {
        for (int i = 0; i < classes.Length; i++)
        {
            if (classes[i].Equals(obj))
            {
                classes[i].enabled = false;
                return;
            }
        }
    }

    public void NextScript(object obj)
    {
        for (int i = 0; i < classes.Length; i++)
        {
            if (classes[i].Equals(obj))
            {
                classes[i].enabled = false;
                if (i+1 >= classes.Length) return;
                classes[i + 1].enabled = true;
                return;
            }
        }
    }


}
