using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Vector3 FirstPoint;
    Vector3 SecondPoint;
    float rotationX = 0;
    float rotationY = 0;
    float xRotTemp;
    float yRotTemp;
    Camera cam;

    public float ZoomSpeed = 0.5f;

    void Start()
    {
        this.transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                FirstPoint = Input.GetTouch(0).position;
                xRotTemp = rotationX;
                yRotTemp = rotationY;
            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                SecondPoint = Input.GetTouch(0).position;
                rotationX = xRotTemp + (SecondPoint.x - FirstPoint.x) * 180 / Screen.width;
                rotationY = yRotTemp + (SecondPoint.y - FirstPoint.y) * 90 / Screen.height;
                this.transform.rotation = Quaternion.Euler(rotationY, rotationX, 0.0f);
            }

            if (Input.touchCount == 2)
            {
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

                float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

                cam.fieldOfView += deltaMagnitudeDiff * ZoomSpeed;

                cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, 0.1f, 179.9f);

            }

        }
    }
}