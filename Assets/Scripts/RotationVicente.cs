using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationVicente : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RotateLeft();
        }
    }

    void RotateLeft()
    {
        transform.Rotate(Vector3.forward * 90);
    }
}
