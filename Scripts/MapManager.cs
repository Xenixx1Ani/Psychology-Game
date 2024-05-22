using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    //make a grid...so that we can sleect what paets of the islands are in what parts of the map..
    public int gridSizeX = 3; // Number of divisions in the X direction
    public int gridSizeZ = 3; // Number of divisions in the Z direction
    public string centralIslandSceneName = "CentralIslandScene";
    public string[] otherIslandSceneNames;

    private bool isMapOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleMap();
        }

        if (isMapOpen && Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                TeleportToIsland(hit.point);
            }
        }
    }

    void ToggleMap()
    {
        isMapOpen = !isMapOpen;

        if (isMapOpen)
        {
            // Open the map scene
            SceneManager.LoadScene("MapScene");
        }
        else
        {
            // Close the map scene
            SceneManager.UnloadSceneAsync("MapScene");
        }
    }

    void TeleportToIsland(Vector3 clickedPosition)
    {
        // Determine which part of the map the player clicked on based on the grid
        int partX = Mathf.FloorToInt(clickedPosition.x / (gridSizeX * 1.0f));
        int partZ = Mathf.FloorToInt(clickedPosition.z / (gridSizeZ * 1.0f));

        // coordinates to teleport to
        float spawnX = partX * gridSizeX + gridSizeX / 2.0f;
        float spawnZ = partZ * gridSizeZ + gridSizeZ / 2.0f;

        Debug.Log($"Clicked on part ({partX}, {partZ}), teleport to coordinates ({spawnX}, 0, {spawnZ})");
        
        // Perform teleportation logic using spawnX, spawnZ
    }
}
