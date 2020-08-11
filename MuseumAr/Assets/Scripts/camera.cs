using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float rotation = Mathf.Rad2Deg;

    private void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            rotation = 2.0f;
            
        }
    }
    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotation;
        float rotY = Input.GetAxis("Mouse Y") * rotation;
        transform.Rotate(Camera.main.transform.up, -rotX, Space.World);
        transform.Rotate(Camera.main.transform.right, rotY, Space.World);
    }

    /*void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Raton Eje X") * rotation * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Raton Eje Y") * rotation * Mathf.Deg2Rad;

        transform.Rotate(Camera. , -rotX,);
        transform.Rotate(Vector3.right , rotY);
    }*/
}
