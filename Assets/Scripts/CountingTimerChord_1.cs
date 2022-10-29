using UnityEngine;

public class CountingTimerChord_1 : MonoBehaviour
{
    [SerializeField] private float timerSpeed = 1f;
    private float elapsedTime;
    [SerializeField] private float forceAxisY = 100.0f;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        elapsedTime = 0.5f;
    }

    private void Update()
    {

        /*  ТАЙМЕР  */
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timerSpeed)
        {
            elapsedTime = 0f;

            // ЗДЕСЬ ВЫПОЛНЯЕМЫЙ КОД ВНУТРИ ТАЙМЕРА:
            //GetComponent<Flasher>().Flash();
            _rigidbody.AddForce(0f, forceAxisY, 0f);
        }
    }
}