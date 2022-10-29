using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingTimerKick : MonoBehaviour
{
    [SerializeField] private float timerSpeed = 0.5f;
    //private float elapsedTime;
    [SerializeField] private float forceAxisY = 100.0f;
    private float eTime;
    private float tSpeed = 0.75f;
   
    private Rigidbody _rigidbody;
    private MeshRenderer _meshrenderer;     // Для того чтобы иметь доступ к изменению цвета объекта.



    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _meshrenderer = GetComponent<MeshRenderer>();

        //SoundOnCollision.EventCollision.AddListener(ChangeColor);     // Подписываем Метод ChangeColor() на Событие EventCollision
        //SoundOnCollision.EventCollision.AddListener(ChangeScale);
    }

    private void Start()
    {
        StartCoroutine("TimerKick");

        StartCoroutine("KickScaleChange");
    }

    private void Update()
    {
        /*  ТАЙМЕР  */
        //elapsedTime += Time.deltaTime;
        //if (elapsedTime >= timerSpeed)
        //{
        //    elapsedTime = 0f;

        //    // ЗДЕСЬ ВЫПОЛНЯЕМЫЙ КОД ВНУТРИ ТАЙМЕРА:
        //    //GetComponent<Flasher>().Flash();
        //    _rigidbody.AddForce(0f, forceAxisY, 0f);
        //}
    }

    private void FixedUpdate()
    {
        //StartCoroutine("KickScaleChange");
    }


    IEnumerator TimerKick()
    {
        while (true)
        {
            _rigidbody.AddForce(0f, forceAxisY, 0f);
            yield return new WaitForSeconds(timerSpeed);    // этим действием мы Создадим временнОй интервал
        }
    }
    IEnumerator KickScaleChange()
    {
        ///*  ТАЙМЕР  */
        //eTime += Time.deltaTime;
        //if (eTime >= tSpeed)
        //{
        //    eTime = 0f;

        //    // ЗДЕСЬ ВЫПОЛНЯЕМЫЙ КОД ВНУТРИ ТАЙМЕРА:
        //    //GetComponent<Flasher>().Flash();
        //    SoundOnCollision.EventCollision.AddListener(ChangeScale);
        //    yield return new WaitForSeconds(0.5f);
        //    SoundOnCollision.EventCollExit.AddListener(ChangeScaleBack);
        //}

        //yield return new WaitForSeconds(1f);
        SoundOnCollision.EventCollision.AddListener(ChangeColor);
        yield return new WaitForSeconds(0.01f);
        SoundOnCollision.EventCollExit.AddListener(ChangeColorBack);

    }

    private void ChangeColor()
    {
        _meshrenderer.material.color = Color.blue;
    }
    private void ChangeColorBack()
    {
        _meshrenderer.material.color = Color.red;
    }

    private void ChangeScale()
    {
        //transform.localScale *= 0.01f;
        transform.localScale = new Vector3(1, 1, 1);
    }
    private void ChangeScaleBack()
    {
        //transform.localScale *= 0.01f;
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }
}