using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRaycast : MonoBehaviour
{
    [SerializeField] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right*-1);

        if (hit.collider.gameObject.tag == "No")
        {
            _speed = 0;
        }
        else if( hit.collider.gameObject.tag == "Yes")
        {
            _speed = 1;
        }
        else
        {
            _speed = 1;
        }

        transform.Translate(new Vector3(_speed * Time.deltaTime, 0, 0));

    }
}
