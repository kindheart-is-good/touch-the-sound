using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTranslate : MonoBehaviour
{
    //private Vector3 direction;
    [SerializeField] private float speed = 0.1f;

    private Rigidbody _rigidbody;



    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }



    private void PlayerMove()
    {
        //float hInput = Input.GetAxis("Horizontal");
        //direction.x = hInput * speed;

        //float vInput = Input.GetAxis("Vertical");
        //direction.z = vInput * speed;

        //float uInput = Input.GetKey(KeyCode.LeftControl)
        //direction.y = 


        if (Input.GetKey(KeyCode.LeftControl))
        {
            _rigidbody.AddForce(0f, 10f, 0f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(0f, -10f, 0f);
        }

        // бкебн-бопюбн
        //if (Input.GetKey(KeyCode.A))
        if (Input.GetKey(KeyCode.Z))
        {
            _rigidbody.AddForce(0f, 0f, -10f);
        }
        //if (Input.GetKey(KeyCode.D))
        if (Input.GetKey(KeyCode.X))
        {
            _rigidbody.AddForce(0f, 0f, 10f);
        }



        //transform.Translate(direction.normalized * speed);
    }
}