using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float preferredDistance = 1.0f;
    public float yOffset = 1.0f;

    void Update()
    {
        Vector3 distanceVector = player.transform.position - transform.position;
        Vector3 targetPosition = player.transform.position - (player.transform.forward * preferredDistance);
        targetPosition.y = player.transform.position.y + yOffset;

        transform.position = targetPosition;

        // Rotation controls
        if (Input.GetKey(KeyCode.Q))
        {
            player.transform.Rotate(Vector3.up * Time.deltaTime * 100);
        }

        if (Input.GetKey(KeyCode.E))
        {
            player.transform.Rotate(Vector3.up * -Time.deltaTime * 100);
        }
    }
}
