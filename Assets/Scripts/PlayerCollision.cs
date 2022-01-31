using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

  void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // can also do this
            // GetComponent<PlayerMovement>().movement.enabled
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
