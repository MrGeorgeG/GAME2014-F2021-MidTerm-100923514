/*
 *  Full Name        : Xinlin Gan
 *  Student ID       : 100923514
 *  Date Modified    : 2021/10/22
 *  File             : EnemyController.cs
 *  Description      : Enemy Controller Script use to set the enemy behavior.
 *  Revision History : v0.1 Change the Enemy movement direction to work the Landscape orientation.
 *                     v0.2 Modify CheckBounds direction to vertical.
 *                     v0.3 Change some variable name.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    /// <summary>
    /// change the variable name to vertical
    /// </summary>

    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    /// <summary>
    /// Modify the Move for Enemy movement direction
    /// </summary>
    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    /// <summary>
    /// change the checkBounds direction to vertical
    /// </summary>
    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
