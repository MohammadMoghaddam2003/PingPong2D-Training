using System.Collections;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerState State = PlayerState.Red;

    public Text RedGoal, BlueGoal;
    public GameObject Ball;

    private static float _redPlayerGoal = 0, _bluePlayerGoal = 0;

    void Update()
    {
    }

    public void ChangeGoal()
    {
        if (State == PlayerState.Blue)
            _bluePlayerGoal += 1;
        else
            _redPlayerGoal += 1;
        StartCoroutine(ResetBallPosition());

        RedGoal.text = _redPlayerGoal.ToString();
        BlueGoal.text = _bluePlayerGoal.ToString();
    }

    void PrintScore()
    {

    }

    IEnumerator ResetBallPosition()
    {
        Ball.transform.position = Vector2.zero;
        Ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        yield return new WaitForSeconds(3);
        Ball.GetComponent<BallController>().AddForce();
    }
}
