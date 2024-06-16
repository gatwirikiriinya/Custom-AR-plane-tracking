using UnityEngine;
using UnityEngine.UI;

public class ColorSelector : MonoBehaviour
{
    public GameObject objectToColor;
    public Button redButton;
    public Button blueButton;
    public Button greenButton;

    void Start()
    {
        redButton.onClick.AddListener(() => ChangeColor(Color.red));
        blueButton.onClick.AddListener(() => ChangeColor(Color.blue));
        greenButton.onClick.AddListener(() => ChangeColor(Color.green));
    }

    void ChangeColor(Color color)
    {
        if (objectToColor != null)
        {
            Renderer renderer = objectToColor.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = color;
            }
        }
    }
}
