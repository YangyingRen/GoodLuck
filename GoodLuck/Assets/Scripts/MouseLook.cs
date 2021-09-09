// original by asteins
// adapted by @torahhorse
// http://wiki.unity3d.com/index.php/SmoothMouseLook

// Instructions:
// There should be one MouseLook script on the Player itself, and another on the camera
// player's MouseLook should use MouseX, camera's MouseLook should use MouseY

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseLook : MonoBehaviour
{
 public float mouseSensitivityX = 100f;
 public float mouseSensitivityY = 50f;

 public Transform playerBody;
 float xRotation =0f;
 void Start(){

	 Cursor.lockState = CursorLockMode.Locked;
 }

 void Update(){

	 float mouseX= Input.GetAxis("Mouse X")*mouseSensitivityX;
	 float mouseY= Input.GetAxis("Mouse Y")*mouseSensitivityY;

	 xRotation-=mouseY;
	 xRotation= Mathf.Clamp(xRotation,-90f,90f);

	 transform.localRotation=Quaternion.Euler(xRotation, 0f,0f);
	 playerBody.Rotate(Vector3.up*mouseX);
 }
}