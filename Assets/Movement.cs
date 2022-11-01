using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool triggerClicked = true;
    private Transform rightHand;

    private Quaternion initialObjectRotation;
    private Quaternion initialControllerRotation;

    private bool set = false;
    // Start is called before the first frame update
    void Start()
    {
        this.rightHand = GameObject.FindGameObjectWithTag("RightController").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerClicked) {

            if(set == false)
            {
                initialObjectRotation= transform.rotation;
                initialControllerRotation = rightHand.rotation;
                set = true;
            }

            Quaternion controllerAngularDifference = initialControllerRotation * Quaternion.Inverse(rightHand.rotation);
            transform.rotation = controllerAngularDifference * initialObjectRotation;
        }         
        else
        {
            set = false;
        }
    }
}





