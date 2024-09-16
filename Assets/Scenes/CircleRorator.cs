using UnityEngine;

public class CircleRotator : MonoBehaviour
{
    public float spinSpeed = 100f; // Speed of the circle's own rotation
    public float revolutionSpeed = 50f; // Speed of the circle's revolution around the pivot
    private bool rotateClockwise = true; // Determines the direction of rotation

    void Update()
    {
        // Handle spinning of the circle around its own center
        float spinDirection = rotateClockwise ? 1f : -1f;
        transform.Rotate(0f, 0f, spinDirection * spinSpeed * Time.deltaTime);

        // Handle revolution of the circle around the pivot
        float revolutionDirection = rotateClockwise ? -1f : 1f;
        transform.parent.Rotate(0f, 0f, revolutionDirection * revolutionSpeed * Time.deltaTime);

        // Check for user input to change rotation direction
        if (Input.GetMouseButtonDown(0)) // Left mouse button or tap
        {
            rotateClockwise = !rotateClockwise;
        }
    }
}
