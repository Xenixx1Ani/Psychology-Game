using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public GameObject mapCanvas;
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
                TeleportToIsland(hit.transform);
            }
        }
    }

    void ToggleMap()
    {
        isMapOpen = !isMapOpen;
        mapCanvas.SetActive(isMapOpen);
    }

    void TeleportToIsland(Transform targetIsland)
    {
        

        string targetSceneName = centralIslandSceneName;

        for (int i = 0; i < otherIslandSceneNames.Length; i++)
        {
            if (targetIsland.name.Equals(otherIslandSceneNames[i], System.StringComparison.OrdinalIgnoreCase))
            {
                targetSceneName = otherIslandSceneNames[i];
                break;
            }
        }

        SceneManager.LoadScene(targetSceneName);
        ToggleMap(); // Close the map after teleporting.
    }
}
