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
        //_rigidbody.maxAngularVelocity = Mathf.Infinity;   // �������� �� ����� ����������
    }

    private void FixedUpdate()
    {
        float forwardForce = Input.GetAxis("Vertical") * speed;
        float sideForce = Input.GetAxis("Horizontal") * rotationSpeed;

        //_rigidbody.AddForce(0f, 0f, forwardForce);
        // � �������� ���� �� ���_� ��������� ���� ������� ������������ ������ �� ���� ��� �� ������ �� ����������,
        // �.�. -1 ���� ������� ����� ��� 1 ���� ������� ������.

        _rigidbody.AddRelativeForce(0f, 0f, forwardForce);
        // � ��� ������� �� AddForce()?
        // AddForce() ������� ������ � ������� ����������� (�������� ������ ��������� ������ ����� ������� �� ������ ��������� ��� �������).
        // AddRelativeForce() ������� ������ ������ �� ���������� ������������ ����� ������� (������ ����� ��������� �� ����� ����������� ���).

        _rigidbody.AddTorque(0f, sideForce, 0f);
        //_rigidbody.AddRelativeTorque(0f, sideForce, 0f);
    }
}