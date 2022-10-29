using UnityEngine;

public class CountingTimer : MonoBehaviour
{
    [SerializeField] private float timerSpeed = 2f;
    private float elapsedTime;
    [SerializeField] private float forceAxisY = 230.0f;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        /*  ������  */
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timerSpeed)
        {
            elapsedTime = 0f;

            // ����� ����������� ��� ������ �������:
            //GetComponent<Flasher>().Flash();
            _rigidbody.AddForce(0f, forceAxisY, 0f);
        }
    }
}