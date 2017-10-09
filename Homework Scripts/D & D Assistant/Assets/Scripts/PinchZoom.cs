using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PinchZoom : MonoBehaviour
{

    private static float PanSpeed = 20f;
    private static float ZoomSpeedTouch = 0.1f;
    private static float ZoomSpeedMouse = 10f;

    private static float[] BoundsX = new float[] { -10f, 10f };
    private static float[] BoundsY = new float[] { -10f, 10f };
    private static float[] ZoomBounds = new float[] { 10f, 85f };

    public Camera cam;
    public Canvas can;
    private bool menuHover = false;

    private Vector3 lastPanPosition;
    
    // **TOUCH MODE ONLY**
    private int panFingerId;

    private bool wasZoomingLastFrame;
    private Vector2[] lastZoomPositions;

    void Awake()
    {
        // Find the Camera
        GameObject findcam = GameObject.Find("Main Camera");
        if (cam != null) // Camera found
        {
            cam = findcam.GetComponent<Camera>();
            Debug.Log("Found Camera.");
        }
        else // Camera not found
        {
            Debug.Log("Didn't Find Camera.");
        }
        //Find the Canvas
        GameObject findcan = GameObject.Find("Canvas");
        if (can != null) // Canvas found
        {
            can = findcan.GetComponent<Canvas>();
            Debug.Log("Found Canvas.");
        }
        else // Canvas not found
        {
            Debug.Log("Didn't Find Canvas.");
        }
    }

    void Update()
    {
        if (menuHover == false)
        {
            Debug.Log("Hovering Over Playspace");
            // Checks to see if touch is supported. Uses touch if available, if not, uses mouse.
            if (Input.touchSupported && Application.platform != RuntimePlatform.WebGLPlayer)
            {
                UsingTouch();
            }
            else
            {
                UsingMouse();
            }
        }
        else
        {
            Debug.Log("Hovering Over Menu");
        }
    }

    void UsingTouch() {
        switch (Input.touchCount) {

            case 1: // Panning
                wasZoomingLastFrame = false;

                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    lastPanPosition = touch.position;
                    panFingerId = touch.fingerId;
                }
                else if (touch.fingerId == panFingerId && touch.phase == TouchPhase.Moved) {
                    PanCamera(touch.position);
                }
                break;

            case 2: // Zooming
                Vector2[] newPositions = new Vector2[] { Input.GetTouch(0).position, Input.GetTouch(1).position };
                if (!wasZoomingLastFrame)
                {
                    lastZoomPositions = newPositions;
                    wasZoomingLastFrame = true;
                }
                else {
                    // Calculates offset, figuring out zoom distance.
                    float newDistance = Vector2.Distance(newPositions[0], newPositions[1]);
                    float oldDistance = Vector2.Distance(lastZoomPositions[0], lastZoomPositions[1]);
                    float offset = newDistance - oldDistance;

                    // Zooms the Camera
                    ZoomCamera(offset, ZoomSpeedTouch);

                    lastZoomPositions = newPositions;
                }
                break;

            default:
                wasZoomingLastFrame = false;
                break;
        }
    }

    void UsingMouse() {
        // Checks wether or not the mouse is being clicked. If it is, pans camera.
        if (Input.GetMouseButtonDown(0))
        {
            lastPanPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0)) {
            PanCamera(Input.mousePosition);
        }

        // Checks is mouse scrollwheel is being used and zooms/unzooms accordingly.
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        ZoomCamera(scroll, ZoomSpeedMouse);
    }

    void PanCamera(Vector3 newPanPosition) {
        // Figures out how far the camera needs to be moved.
        Vector3 offset = cam.ScreenToViewportPoint(lastPanPosition - newPanPosition);
        Vector3 move = new Vector3(offset.x * PanSpeed, offset.y * PanSpeed, 0);

        // Moves the Camera
        transform.Translate(move, Space.World);

        // Makes sure the camera stays in bounds. [Bounds are set above]
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, BoundsX[0], BoundsX[1]);
        pos.y = Mathf.Clamp(transform.position.y, BoundsX[0], BoundsY[1]);
        transform.position = pos;

        // Store the position
        lastPanPosition = newPanPosition;
    }

    void ZoomCamera(float offset, float speed) {
        if (offset == 0) {
            return;
        }

        // Simply changes the camera's field of view, but keeping it in predefined bounds. [Set above]
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView - (offset * speed), ZoomBounds[0], ZoomBounds[1]);
    }

    // Reports if the mouse is hovering over the UI.
    public void MenuHoverTrue() {
        menuHover = true;
    }

    // Reports if the mouse is hovering over the gamespace.
    public void MenuHoverFalse() {
        menuHover = false;
    }
}
