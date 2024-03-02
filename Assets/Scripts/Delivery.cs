using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool bHasPackage = false; 

    [SerializeField]Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField]Color32 hasNoPackageColor = new Color32(1,1,1,1);
    [SerializeField]float destroyDelay = 0.5f;
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();   
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Don't Hit Me !!");
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !bHasPackage)
        {
            Debug.Log("Package Picked Up !! ");
            bHasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if(other.tag == "Customer" && bHasPackage)
        {
            Debug.Log("Package Delivered !! ");
            bHasPackage = false;
            spriteRenderer.color = hasNoPackageColor;
        }
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        
    }
}
