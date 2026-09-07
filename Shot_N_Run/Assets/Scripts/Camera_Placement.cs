using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Placement : MonoBehaviour
{
    public Transform cam_pos;

    private void Update()
    {
        transform.position = cam_pos.position;
    }
}
