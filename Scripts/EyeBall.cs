using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeBall : MonoBehaviour
{
    Vector3 mousePosition;
    private void Update()
    {
        mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.LookAt(mousePosition);
    }
}
