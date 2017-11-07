using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;

    public float smoothSpeed = 0.125f;      // The speed the camera moves to new location.
    public Vector3 offset;                  // Three vectors that offset the camera to a desired position.

    void FixedUpdate()
    {
        Vector3 tunedPosition = player.position + offset;   // Creates a new position between characters position and predefined offset position.
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, tunedPosition, smoothSpeed);    // Creates a new position between the players transform and the tunned position, than moves the camera.
        // ---Lerp--- : Using point A, and point B, a Vector3.Lerp finds a point between the two.
        transform.position = smoothedPosition;              // Stoes newly created position as smoothedPosition.
    }
}
