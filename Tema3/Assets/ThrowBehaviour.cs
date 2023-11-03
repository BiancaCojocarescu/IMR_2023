using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowBehaviour : MonoBehaviour
{
    void MoveObject()
    {
        transform.position = new Vector3(1.0f, 1.0f, 1.0f);  
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Target"))
        {
            MoveObject();
        }
    }
}

