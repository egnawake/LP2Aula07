using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    private EventMaster em;

    private void Awake()
    {
        em = GetComponent<EventMaster>();
    }

    private void OnEnable()
    {
        em.KeyPress += PrintKey;
    }

    private void OnDisable()
    {
        em.KeyPress -= PrintKey;
    }

    private void PrintKey(char key)
    {
        Debug.Log(key);
    }
}
