using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeWayCheker : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidbody2d;
    [SerializeField] ContactFilter2D _filter;
    [SerializeField] float _speed;

    private readonly RaycastHit2D[] _result = new RaycastHit2D[1];

    private void FixedUpdate()
    {
        var collisionCount = _rigidbody2d.Cast(transform.right, _filter, _result, 10);

        if (collisionCount == 0)
            _rigidbody2d.velocity = transform.right * _speed;
        else
            _rigidbody2d.velocity = Vector2.zero;
    }
}
