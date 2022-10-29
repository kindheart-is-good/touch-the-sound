using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 5f;
    public float rotationSpeed = 1f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.maxAngularVelocity = 500f;
        //_rigidbody.maxAngularVelocity = Mathf.Infinity;   // скорость не будет ограничена
    }

    private void FixedUpdate()
    {
        float forwardForce = Input.GetAxis("Vertical") * speed;
        float sideForce = Input.GetAxis("Horizontal") * rotationSpeed;

        //_rigidbody.AddForce(0f, 0f, forwardForce);
        // В качестве силы по Оси_Х применяем силу которая определяется исходя из того что мы нажали на клавиатуре,
        // т.е. -1 если стрелку влево или 1 если стрелку вправо.

        _rigidbody.AddRelativeForce(0f, 0f, forwardForce);
        // В чём отличие от AddForce()?
        // AddForce() двигает объект в мировых координатах (например слегка повёрнутый объект будет двигать по прямой игнорируя его поворот).
        // AddRelativeForce() двигает объект исходя из локального пространства этого объекта (объект будет двигаться по своей собственной оси).

        _rigidbody.AddTorque(0f, sideForce, 0f);
        //_rigidbody.AddRelativeTorque(0f, sideForce, 0f);
    }
}