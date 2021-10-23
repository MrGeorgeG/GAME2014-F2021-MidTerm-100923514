/*
 *  Full Name        : Xinlin Gan
 *  Student ID       : 100923514
 *  Date Modified    : 2021/10/22
 *  File             : BackgroundController.cs
 *  Description      : Background Controller Script use to Background move form right to left.
 *  Revision History : v0.1 Changed the Background direction to work the Landscape orientation. 
 *                     v0.2 Modify the reset coordinates.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    /// <summary>
    /// Change the Reset coordinates
    /// </summary>
    private void _Reset()
    {
        transform.position = new Vector3(verticalBoundary, 0.0f);
    }

    /// <summary>
    /// Change the Background direction for Vector 3
    /// </summary>
    private void _Move()
    {
        transform.position -= new Vector3(verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
