using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IslandManagaer : MonoBehaviour
{
    public void IslandChooser( int indexIsland){
        SceneManager.LoadScene(indexIsland);
    }
}
