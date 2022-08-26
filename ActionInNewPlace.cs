using UnityEngine;
using UnityEngine.Events;

public class  ActionInNewPlace: MonoBehaviour
{
    public GameObject[] objects;
    public UnityAction[] methods = new UnityAction[2] {DoSomething1, DoSomething2}; //Здесь по порядку указывать методы для обьектов касания
    
    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (collision.gameObject.Equals(objects[i]))
            {
                methods[i]();
                return;
            }
        }
    }

    private static void DoSomething1()
    {
        //do something
    }

    private static void DoSomething2()
    {
        //do something
    }
}
