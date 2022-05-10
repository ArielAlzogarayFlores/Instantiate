using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObjects : MonoBehaviour
{
    public GameObject prefab;
    public GameObject clon;
    public int cantCubos;
    public int gradosRotacion;

    public void InstantiateObject()
    {

        for (int i = 0; i<cantCubos; i++)
        {
            clon = Instantiate(prefab);
            clon.transform.Rotate(0, gradosRotacion * i, 0);
            clon.transform.Translate(i, i, 0);

            //Destroy(clon, .5f);
        }
    }
}
