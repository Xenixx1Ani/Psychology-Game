using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
public class ImageLoader : MonoBehaviour
{
    public Image imageElement;
    public string folderPath;

    public void LoadImage()
    {
        // Open file dialog to select an image file
        // string imagePath = UnityEditor.EditorUtility.OpenFilePanel("Select PNG Image", folderPath, "png");//just add the image path here…should be the same as the executable 

        // if (!string.IsNullOrEmpty(imagePath))
        // {
        //     // Load the image from file
        //     byte[] imageData = File.ReadAllBytes(imagePath);
        //     Texture2D texture = new Texture2D(2, 2);
        //     texture.LoadImage(imageData);

        //     // Assign the loaded texture to the UI Image element
        //     imageElement.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        // }
    }
}
