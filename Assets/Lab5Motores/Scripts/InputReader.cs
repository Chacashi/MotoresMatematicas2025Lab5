using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    [SerializeField] private float transitionDelay;
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }



    public void TransitionToIntro()
    {
        StartCoroutine(WaitTransition(transitionDelay, () =>
        {
            playerInput.ActivateInput();
        }
        ));
    }


   


    IEnumerator WaitTransition(float delay,Action action)
    {
        yield return new WaitForSeconds(delay);
        action?.Invoke();

    }

   
}
