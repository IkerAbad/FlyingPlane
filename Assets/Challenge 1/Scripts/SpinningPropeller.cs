using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPropeller : MonoBehaviour
{
    public Vector3 rotation;
    public float spinVelocity = 2000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        rotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z + spinVelocity);
        transform.Rotate(rotation * Time.deltaTime);

    }
}
