using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(Target.transform.position.x, -4, 58), Mathf.Clamp(Target.transform.position.y, -38, 48), transform.position.z);
    }
}
