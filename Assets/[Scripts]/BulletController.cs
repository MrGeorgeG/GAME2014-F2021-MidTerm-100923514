/*
 *  Full Name        : Xinlin Gan
 *  Student ID       : 100923514
 *  Date Modified    : 2021/10/22
 *  File             : BulletController.cs
 *  Description      : Bullet Behavior Script use to bullet movement.
 *  Revision History : v0.1 Change the Bullet direction to work the Landscape orientation.
 *                     v0.2 Modify CheckBounds direction to horizontal
 *                     v0.3 Change some variable name.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    /// <summary>
    /// change the variable name to vertical
    /// </summary>
    public float horizontalSpeed;
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    /// <summary>
    /// Change Move for the Bullet direction
    /// </summary>
    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    /// <summary>
    /// Change CheckBounds direction to horizontal
    /// </summary>
    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
