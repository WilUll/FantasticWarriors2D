using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target;

    public bool isInside;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isInside)
        {
            transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y, -10);
        }
        else
        {
            transform.position = new Vector3(Mathf.Clamp(Target.transform.position.x, -4.36f, 79.5f), Mathf.Clamp(Target.transform.position.y, -40.5f, 50.1f), transform.position.z);
        }
    }
}
