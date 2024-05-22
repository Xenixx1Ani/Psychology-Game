using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Reference to the player GameObject
    public GameObject player;

    // Teleport the player to the specified coordinates
    public void TeleportTo(float x, float z)
    {
        float y = player.transform.position.y;

        // Set the player's position to the specified coordinates
        player.transform.position = new Vector3(x, y, z);
    }
}
/*
for teleportation: 
// Assuming a reference to the Teleport
public Teleport teleport;

// Call the Teleport method with desired coordinates
teleport.TeleportTo(10f, 20f);

*/
