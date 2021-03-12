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
    public TextMeshProUGUI 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (displayToggle && Input.ge)
        {

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
