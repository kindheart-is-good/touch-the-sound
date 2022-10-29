using UnityEngine;

public class CountingTimerHihat : MonoBehaviour
{
    [SerializeField] private float timerSpeed = 0.2f;
    private float elapsedTime;
    [SerializeField] private float forceAxisY = 50.0f;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        /*  рюилеп  */
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timerSpeed)
        {
            elapsedTime = 0f;

            // гдеяэ бшонкмъелши йнд бмсрпх рюилепю:
            //GetComponent<Flasher>().Flash();
            _rigidbody.AddForce(0f, forceAxisY, 0f);
        }
    }
}