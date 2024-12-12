using System;
using UnityEngine;

public class IsometricGrid : MonoBehaviour
{
    public GameObject tilePrefab; // AAsign a basic cube or tile prefab in the Inspector
    public int gridWidth = 10;  // Number of tiles horizontally
    public int gridHeight = 10;  // Number of tiles vertically
    public float tileWidth = 1f; // Width of each tile
    public float tileHeight = 0.5f; // Height of each tile

    void Start()
    {
        GenerateGrid();    
    }

    void GenerateGrid()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                // Calculate the isometric position
                Vector3 tilePosition = CalculateIsometricPosition(x, y);

                // Instatiate a tile
                Instantiate(tilePrefab, tilePosition, Quaternion.identity, transform);
            }
        }
    }

    Vector3 CalculateIsometricPosition(int x, int y)
    {
        float worldX = Mathf.Round((x - y) * tileWidth / 2f * 100f) /100f;
        float worldZ = Mathf.Round((x - y) * tileHeight / 2f * 100f) / 100f; // Z is vertical in isometric
        return new Vector3(worldX, 0, worldZ);
    }
}
