using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public CharacterController controller;

    public float maxSpeed = 10f;
    public float gravity = 30f;
    public float jumpHeight = 3f;
    public bool isGrounded;

    public Transform groundCheck;
    public float groundRadius = 0.5f;

    public LayerMask groundMask;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        Gizmos.DrawWireSphere(groundCheck.position, groundRadius);
    }
}
