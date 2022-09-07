using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Rigidbody2D rb;

    Vector2 mousePos;

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    public void getMousePos(InputAction.CallbackContext context)
    {
        mousePos = cam.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }
}
