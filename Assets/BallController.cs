using UnityEngine;

public class BallController : MonoBehaviour
{
    public float Speed = 3;
    void Start()
    {
        AddForce();
    }

    public void AddForce()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        Rigidbody2D move = gameObject.GetComponent<Rigidbody2D>();
        move.velocity = new Vector2(x * Speed, y * Speed);
    }
}
