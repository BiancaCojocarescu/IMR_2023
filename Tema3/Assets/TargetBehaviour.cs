using UnityEngine;

public class MoveOnCollision : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust the speed as needed
    private bool canMove = true;

    // This function is called when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a specific tag or layer if needed
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Disable further movement upon collision
            canMove = false;
        }
    }

    private void Update()
    {
        if (canMove)
        {
            // Move the object forward along its local Z-axis
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
