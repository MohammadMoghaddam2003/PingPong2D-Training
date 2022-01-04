using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    public float Speed = 3;

    public PlayerState _playerState = PlayerState.Blue;

    void Start()
    {

    }

    void Update()
    {
        if (_playerState == PlayerState.Blue)
            PlayerRedMovement();
        else
            PlayerBlueMovement();

    }

    void PlayerRedMovement()
    {
        float move = Input.GetAxis("Vertical");
        Rigidbody2D playerRigidbody = gameObject.GetComponent<Rigidbody2D>();
        playerRigidbody.velocity = new Vector2(0, move * Speed);
    }

    void PlayerBlueMovement()
    {
        float move = Input.GetAxis("Vertical2");
        Rigidbody2D playerRigidbody = gameObject.GetComponent<Rigidbody2D>();
        playerRigidbody.velocity = new Vector2(0, move * Speed);
    }
}

public enum PlayerState
{
    Red, Blue
}
