using UnityEngine;

public class GridManager : MonoBehaviour
{
    public float cellSize = 1.0f;

    // Convert a world position to a grid position
    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        int xCount = Mathf.RoundToInt(position.x / cellSize);
        int yCount = Mathf.RoundToInt(position.y / cellSize);
        int zCount = Mathf.RoundToInt(position.z / cellSize);

        Vector3 result = new Vector3(
            (float)xCount * cellSize,
            (float)yCount * cellSize,
            (float)zCount * cellSize);

        result += transform.position;

        return result;
    }

    // Draw the grid in the scene view for visualization
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        for (float x = -10; x < 10; x += cellSize)
        {
            for (float z = -10; z < 10; z += cellSize)
            {
                var point = GetNearestPointOnGrid(new Vector3(x, 0, z));
                Gizmos.DrawSphere(point, 0.1f);
            }
        }
    }
}
