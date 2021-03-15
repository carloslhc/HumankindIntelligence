using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRayCast : MonoBehaviour
{
    public float range = 15f;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        // Physics.Raycast(transform.position, new Vector3(0,0,-range));
        // Debug.DrawRay(transform.position, new Vector3(0, 0, -range), Color.green);
    }

    public void playAnimation()
    {
        animator.SetTrigger("Press");
    }
}
