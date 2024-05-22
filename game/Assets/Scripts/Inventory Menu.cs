using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InventoryMenu : MonoBehaviour
{
    public TextMeshProUGUI wood;
    public TextMeshProUGUI cement;
    public TextMeshProUGUI paints;
    public TextMeshProUGUI metal;
    public TextMeshProUGUI stones;
    public TextMeshProUGUI hen;

    void Update(){
        /*  0 - wood, 1 - metal, 2 - stone, 3 - paintbuckets, 4 - cement */
        wood.text = GlobalVariables.materials[0].ToString();
        metal.text = GlobalVariables.materials[1].ToString();
        stones.text = GlobalVariables.materials[2].ToString();
        paints.text = GlobalVariables.materials[3].ToString();
        cement.text = GlobalVariables.materials[4].ToString();
        hen.text = GlobalVariables.hen_caught.ToString();
    }
}
