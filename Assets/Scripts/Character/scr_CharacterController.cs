using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static scr_Models;

public class scr_CharacterController : MonoBehaviour
{
    private Default_Input defaultInput;
    public Vector2 input_Movement;
    public Vector2 input_View;

    private Vector3 newCameraRotation;

    [Header("References")]
    public Transform cameraHolder;

    [Header("Settings")]
    public PlayerSettingsMode1 playerSettings;
    public float viewClampYMin = -70;
    public float viewClampYMax = 80;

    private void Awake()
    {
        defaultInput = new Default_Input();

        defaultInput.Character.Movement.performed += e => input_Movement = e.ReadValue<Vector2>();
        defaultInput.Character.View.performed += e => input_View = e.ReadValue<Vector2>();

        defaultInput.Enable();

        newCameraRotation = cameraHolder.localRotation.eulerAngles;
    }

    private void Update()
    {
        CalculateView();
        CalculateMovement();
    }

    private void CalculateView()
    {

        newCameraRotation.x += playerSettings.ViewYSensitivity * input_View.y * Time.deltaTime;

        newCameraRotation.x = Mathf.Clamp(newCameraRotation.x, viewClampYMin, viewClampYMax);

        cameraHolder.localRotation = Quaternion.Euler(newCameraRotation);
    }

    private void CalculateMovement()
    {

    }


}
