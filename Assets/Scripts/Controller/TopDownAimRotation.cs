using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    TopDownCharacterController controller;
    [SerializeField]SpriteRenderer characterRenderer;

    private void Awake() 
    {
        controller = GetComponent<TopDownCharacterController>();
        controller.OnLookEvent += onAim;
    }

    void onAim(Vector2 aimDirection)
    {
        float rotz = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotz) > 90;
    }

}
