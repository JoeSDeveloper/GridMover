using UnityEngine;

public class TileHighlighter : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;
    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    void OnMouseEnter()
    {
        rend.material.color = Color.yellow;
    }

    void OnMouseExit()
    {
        rend.material.color = originalColor;
    }
}
