using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassController : MonoBehaviour
{
    public Transform player;
    Vector3 vector;
    void LateUpdate()
    {
        vector.z = player.eulerAngles.y;
        transform.localEulerAngles = vector;
    }
}
