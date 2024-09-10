using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed, zoomSpeed;
    public SpecialButton upButton, downButton, leftButton, rightButton, zoomInButton, zoomOutButton;
    public Transform joint1, joint2, cam;

    private float xRotation;

    private void Update()
    {
        var s = speed * Time.deltaTime;
        var zs = zoomSpeed * Time.deltaTime;

        if (upButton.Pressed || Input.GetKey(KeyCode.UpArrow))
        {
            xRotation = Mathf.Clamp(xRotation + s, -90, 90);
            joint2.localRotation = Quaternion.Euler(xRotation, 0, 0);
        }

        if (downButton.Pressed || Input.GetKey(KeyCode.DownArrow))
        {
            xRotation = Mathf.Clamp(xRotation - s, -90, 90);
            joint2.localRotation = Quaternion.Euler(xRotation, 0, 0);
        }

        if (leftButton.Pressed || Input.GetKey(KeyCode.LeftArrow))
            joint1.localEulerAngles -= new Vector3(0, s, 0);

        if (rightButton.Pressed || Input.GetKey(KeyCode.RightArrow))
            joint1.localEulerAngles += new Vector3(0, s, 0);

        if (zoomInButton.Pressed)
        {
            var zPos = Mathf.Clamp(cam.localPosition.z + zs, -10, 0);
            cam.localPosition = new Vector3(0, 0, zPos);
        }

        if (zoomOutButton.Pressed)
        {
            var zPos = Mathf.Clamp(cam.localPosition.z - zs, -10, 0);
            cam.localPosition = new Vector3(0, 0, zPos);
        }
    }
}