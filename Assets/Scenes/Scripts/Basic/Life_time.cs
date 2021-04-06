using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Srat - " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update - " + gameObject.name);
    }
}
