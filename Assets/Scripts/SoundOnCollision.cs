using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/*
 * Этот скрипт можно назначить на любой объект,
 * И этот объект при каждом взаимодействии с любым другим объектом будет издавать звук.
 * Какой звук будет браться? Загруженный нами в компонент AudioSource на указанном объекте.
 */

public class SoundOnCollision : MonoBehaviour
{

    public static UnityEvent EventCollision 
        = new UnityEvent();     // Инициализируем Событие через создание "нового экземпляра UnityEvent()"
    public static UnityEvent EventCollExit
        = new UnityEvent();     // Инициализируем Событие через создание "нового экземпляра UnityEvent()"

    public AudioSource audioSource;



    /*
    // Теперь реализуем вот такую идею:     Чем сильнее удар тем громче будет звук.
    // Как сделать так чтобы грмокость звука зависила от силы удара объекта?
    // Для этого мы сначала проведём исследование - Какова сила удара у объекта в этой конкретной ситуации.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.impulse.magnitude);
        // impulse - это векторная величина.
        // Поэтому мы у вектора берём магнитуду, т.е. величину вектора. Для того чтобы преобразовать её во float.

        // С помощью этой строчки мы можем посмотреть в консоли какие значения в нашей ситуации имеет magnitude.
        // В нашем конкретном случае в ходе теста это оказались значения от 10 до 0.
        // Теперь в соответствии с этими значениями мы можем регулировать громкость нашего AudioSource.
        // Реализуем это для наглядности отдельно ниже:
                    //audioSource.volume = collision.impulse.magnitude * 0.1f;
        // volume задаёт громкость звука. Она может меняться от 0 до 1,
        // Поэтому если мы возьмём magnitude и умножим * 0.1f то как раз при импульсе 10 звук будет максимальный.
    }
    */

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.impulse.magnitude);

        audioSource.Play();         // Воспроизводит звук.

        EventCollision?.Invoke();   // Вызываем Событие, с проверкой что Событие не пустое через знак "?"
        // При удалении объекта нужно отписываться. Лучше выполнять отписку в OnDisable()
    }

    private void OnCollisionExit(Collision collision)
    {
        //EventCollExit?.Invoke();
        StartCoroutine("CollisionDelay");
    }

    IEnumerator CollisionDelay()
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
        //SoundOnCollision.EventCollision.AddListener(ChangeColor);
        yield return new WaitForSeconds(1.8f);
        EventCollExit?.Invoke();
    }
}