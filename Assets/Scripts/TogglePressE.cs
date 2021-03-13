using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TogglePressE : MonoBehaviour
{
    public Canvas pressCanvas;
    private bool displayToggle = false;

    public float range = 0.1f;

    public Camera mainCam;


    public GameObject uiText;


    Animator animator;

    public ButtonRayCast[] button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (displayToggle && Input.GetKeyDown(KeyCode.E))
        {
            if (button.Length > 0)
            {
                for(int i = 0; i < button.Length; i++)
                {
                    Debug.Log("PRESSED E");

                    ButtonRayCast el = button[i];
                    el.playAnimation();
                }
               // button.playAnimation();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerInteractTool"))
        {
            showTextE();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerInteractTool"))
        {
            showTextE();
        }
    }
    void showTextE()
    {
            displayToggle = !displayToggle;
            uiText.SetActive(displayToggle);
    }
}
