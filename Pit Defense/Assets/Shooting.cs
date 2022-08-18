using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    [SerializeField] Transform shotPos;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletForce = 20f;

    void Update()
    {

    }

    public void OnShoot(InputAction.CallbackContext context) 
    {
        Shoot();
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shotPos.position, shotPos.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shotPos.up * bulletForce, ForceMode2D.Impulse);

    }
}
