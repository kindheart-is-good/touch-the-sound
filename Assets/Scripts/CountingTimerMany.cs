using UnityEngine;

public class CountingTimerMany : MonoBehaviour
{
    //[SerializeField] private float timerSpeed = 2f;
    [SerializeField] private float timerSpeed1 = 2f;
    [SerializeField] private float timerSpeed2 = 3f;
    //private float elapsedTime;
    private float elapsedTime1;
    private float elapsedTime2;

    [SerializeField] private float forceAxisY = 230.0f;
    private Rigidbody _rigidbody;
    private Renderer _renderer;



    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        /*                          “¿…Ã≈– 1 ¬¿–»¿Õ“                         */
        /*
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timerSpeed)
        {
            elapsedTime = 0f;

            // «ƒ≈—‹ ¬€œŒÀÕﬂ≈Ã€…  Œƒ ¬Õ”“–» “¿…Ã≈–¿:
            //GetComponent<Flasher>().Flash();
            if (_renderer.material.color == Color.yellow)
            {
                _rigidbody.AddForce(0f, forceAxisY1, 0f);
            }
            if (_renderer.material.color == Color.red)
            {
                _rigidbody.AddForce(0f, forceAxisY2, 0f);
            }
        }
        */

        /*                          “¿…Ã≈– 2 ¬¿–»¿Õ“                         */
        elapsedTime1 += Time.deltaTime;
        if (elapsedTime1 >= timerSpeed1)
        {
            elapsedTime1 = 0f;

            _rigidbody.AddForce(0f, forceAxisY, 0f);
        }

        elapsedTime2 += Time.deltaTime;
        if (elapsedTime2 >= timerSpeed2)
        {
            elapsedTime2 = 0f;

            _rigidbody.AddForce(0f, forceAxisY, 0f);
        }

        //Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        //if (enemy)
        //{
        //    enemy.OnHit();
        //    if (collision.collider.GetComponent<EnemyHead>())
        //    {
        //        Debug.Log("Headshot");
        //    }
        //}
    }
}