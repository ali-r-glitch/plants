using UnityEngine;

public class gridmove : MonoBehaviour
{
    public float cellSize = 1.0f;
    public int gridWidth = 20;
    public int gridHeight = 20;
    public Material lineMaterial;

    private LineRenderer[] lineRenderers;

    void Start()
    {
        CreateGrid();
    }

    // Convert a world position to a grid position and clamp it within the grid boundaries
    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        int xCount = Mathf.RoundToInt(position.x / cellSize);
        int zCount = Mathf.RoundToInt(position.z / cellSize);

        xCount = Mathf.Clamp(xCount, 0, gridWidth - 1);
        zCount = Mathf.Clamp(zCount, 0, gridHeight - 1);

        Vector3 result = new Vector3(
            xCount * cellSize,
            position.y, // Maintain the original Y position
            zCount * cellSize);

        result += transform.position;

        return result;
    }

    // Create the grid using LineRenderers
    void CreateGrid()
    {
        int totalLines = (gridWidth + 1) + (gridHeight + 1);
        lineRenderers = new LineRenderer[totalLines];

        for (int i = 0; i < totalLines; i++)
        {
            GameObject lineObj = new GameObject("GridLine" + i);
            lineObj.transform.SetParent(transform);
            LineRenderer lr = lineObj.AddComponent<LineRenderer>();
            lr.material = lineMaterial;
            lr.startWidth = 0.1f;
            lr.endWidth = 0.1f;
            lr.positionCount = 2;
            lineRenderers[i] = lr;
        }

        int index = 0;

        // Draw vertical lines
        for (int x = 0; x <= gridWidth; x++)
        {
            lineRenderers[index].SetPosition(0, new Vector3(x * cellSize, 0, 0));
            lineRenderers[index].SetPosition(1, new Vector3(x * cellSize, 0, gridHeight * cellSize));
            index++;
        }

        // Draw horizontal lines
        for (int z = 0; z <= gridHeight; z++)
        {
            lineRenderers[index].SetPosition(0, new Vector3(0, 0, z * cellSize));
            lineRenderers[index].SetPosition(1, new Vector3(gridWidth * cellSize, 0, z * cellSize));
            index++;
        }
    }

    // Draw the grid in the scene view for visualization
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        for (int x = 0; x <= gridWidth; x++)
        {
            for (int z = 0; z <= gridHeight; z++)
            {
                Vector3 start = new Vector3(x * cellSize, 0, 0);
                Vector3 end = new Vector3(x * cellSize, 0, gridHeight * cellSize);
                Gizmos.DrawLine(transform.position + start, transform.position + end);
            }
        }

        for (int z = 0; z <= gridHeight; z++)
        {
            for (int x = 0; x <= gridWidth; x++)
            {
                Vector3 start = new Vector3(0, 0, z * cellSize);
                Vector3 end = new Vector3(gridWidth * cellSize, 0, z * cellSize);
                Gizmos.DrawLine(transform.position + start, transform.position + end);
            }
        }
    }
}