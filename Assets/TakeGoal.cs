
using UnityEngine;

public class TakeGoal : MonoBehaviour
{
    public GameManager AddGoal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            AddGoal.ChangeGoal();
        }
    }
}
