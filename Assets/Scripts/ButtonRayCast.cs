using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRayCast : MonoBehaviour
{
    public float range = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, new Vector3(0,0,-range));
        Debug.DrawRay(transform.position, new Vector3(0, 0, -range), Color.green);
    }
}
