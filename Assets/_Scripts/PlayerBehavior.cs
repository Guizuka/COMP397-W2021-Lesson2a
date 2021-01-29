using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float movementForce = 5;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rigidbody.AddForce(Vector3.right * movementForce);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rigidbody.AddForce(Vector3.left * movementForce);
        }
    }
}
