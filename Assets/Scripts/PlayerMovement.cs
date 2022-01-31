using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
  // rb for referencing the Rigid body object
  public Rigidbody rb;

  public float forwardForce = 2000f;
  public float sidewaysForce = 500f;

  // Update is called once per frame
  // Fixed for changing physics updates
  void FixedUpdate()
  {
    // add a variable force (can be edited)
    rb.AddForce(0, 0, forwardForce * Time.deltaTime);

    if ( Input.GetKey("d") )
    {
      rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if (Input.GetKey("a"))
    {
      rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if ( rb.position.y < -1f)
    {
      FindObjectOfType<GameManager>().EndGame();
    }

    if (Input.GetKey(KeyCode.Escape))
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
  }
}
