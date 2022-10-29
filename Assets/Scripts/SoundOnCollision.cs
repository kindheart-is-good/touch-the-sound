using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/*
 * ���� ������ ����� ��������� �� ����� ������,
 * � ���� ������ ��� ������ �������������� � ����� ������ �������� ����� �������� ����.
 * ����� ���� ����� �������? ����������� ���� � ��������� AudioSource �� ��������� �������.
 */

public class SoundOnCollision : MonoBehaviour
{

    public static UnityEvent EventCollision 
        = new UnityEvent();     // �������������� ������� ����� �������� "������ ���������� UnityEvent()"
    public static UnityEvent EventCollExit
        = new UnityEvent();     // �������������� ������� ����� �������� "������ ���������� UnityEvent()"

    public AudioSource audioSource;



    /*
    // ������ ��������� ��� ����� ����:     ��� ������� ���� ��� ������ ����� ����.
    // ��� ������� ��� ����� ��������� ����� �������� �� ���� ����� �������?
    // ��� ����� �� ������� ������� ������������ - ������ ���� ����� � ������� � ���� ���������� ��������.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.impulse.magnitude);
        // impulse - ��� ��������� ��������.
        // ������� �� � ������� ���� ���������, �.�. �������� �������. ��� ���� ����� ������������� � �� float.

        // � ������� ���� ������� �� ����� ���������� � ������� ����� �������� � ����� �������� ����� magnitude.
        // � ����� ���������� ������ � ���� ����� ��� ��������� �������� �� 10 �� 0.
        // ������ � ������������ � ����� ���������� �� ����� ������������ ��������� ������ AudioSource.
        // ��������� ��� ��� ����������� �������� ����:
                    //audioSource.volume = collision.impulse.magnitude * 0.1f;
        // volume ����� ��������� �����. ��� ����� �������� �� 0 �� 1,
        // ������� ���� �� ������ magnitude � ������� * 0.1f �� ��� ��� ��� �������� 10 ���� ����� ������������.
    }
    */

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.impulse.magnitude);

        audioSource.Play();         // ������������� ����.

        EventCollision?.Invoke();   // �������� �������, � ��������� ��� ������� �� ������ ����� ���� "?"
        // ��� �������� ������� ����� ������������. ����� ��������� ������� � OnDisable()
    }

    private void OnCollisionExit(Collision collision)
    {
        //EventCollExit?.Invoke();
        StartCoroutine("CollisionDelay");
    }

    IEnumerator CollisionDelay()
    {
        ///*  ������  */
        //eTime += Time.deltaTime;
        //if (eTime >= tSpeed)
        //{
        //    eTime = 0f;

        //    // ����� ����������� ��� ������ �������:
        //    //GetComponent<Flasher>().Flash();
        //    SoundOnCollision.EventCollision.AddListener(ChangeScale);
        //    yield return new WaitForSeconds(0.5f);
        //    SoundOnCollision.EventCollExit.AddListener(ChangeScaleBack);
        //}

        //yield return new WaitForSeconds(1f);
        //SoundOnCollision.EventCollision.AddListener(ChangeColor);
        yield return new WaitForSeconds(1.8f);
        EventCollExit?.Invoke();
    }
}