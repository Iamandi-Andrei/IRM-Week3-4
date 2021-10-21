using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    public XRIDefaultInputActions act;
    private InputAction grab;
    Animator anim;

    private void Awake(){

        act = new XRIDefaultInputActions();
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnEnable() {
        act.XRILeftHand.Activate.performed+= Grab;
         act.XRILeftHand.Activate.Enable();
         act.XRIRightHand.Activate.performed+= Grab;
         act.XRIRightHand.Activate.Enable();     
    }

    private void Grab(InputAction.CallbackContext obj){

        anim.SetTrigger("grab");
        Debug.Log("Here");
    }

}
