using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingTimerSnare : MonoBehaviour
{
    //[SerializeField] private float timerSpeed = 1f;
    //private float elapsedTime;
    [SerializeField] private float forceAxisY = 100.0f;
    
    private Rigidbody _rigidbody;
    private MeshRenderer _meshrenderer;     // ��� ���� ����� ����� ������ � ��������� ����� �������.

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _meshrenderer = GetComponent<MeshRenderer>();

        //SoundOnCollision.EventCollision.AddListener(ChangeColor);     // ����������� ����� ChangeColor() �� ������� EventCollision
        SoundOnCollision.EventCollision.AddListener(ChangeScale);
    }

    private void Start()
    {
        StartCoroutine("TimerSnare");
    }

    IEnumerator TimerSnare()
    {
        while (true)
        {
            _rigidbody.AddForce(0f, forceAxisY, 0f);
            yield return new WaitForSeconds(1f);    // ���� ��������� �� �������� ��������� ��������
        }
    }

    private void ChangeScale()
    {
        transform.localScale *= 1.01f;
        //transform.localScale = new Vector3(2, 2, 2);
    }
}