using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunCharge : MonoBehaviour
{

    public float stunTime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        stunTime -= Time.deltaTime;
        if (stunTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
