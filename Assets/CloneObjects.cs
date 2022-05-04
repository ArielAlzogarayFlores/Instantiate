using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObjects : MonoBehaviour
{
    int i = 1;
    public GameObject objectToClone;

    public void InstantiateObject()
    {
        while (i < 4)
        {
            Instantiate(objectToClone);
            i++;
        }

        i = 1;
    }
}
