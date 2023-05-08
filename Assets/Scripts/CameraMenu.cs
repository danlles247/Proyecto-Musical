using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraMenu : MonoBehaviour
{
    CinemachineFreeLook cameraSettings;
    public float rotationSpeed = 5.0f;
    private void Awake()
    {
        cameraSettings = GetComponent<CinemachineFreeLook>();
        ChangeAxis("", "");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameStarted){
            enabled = false;
            ChangeAxis("Mouse X", "Mouse Y");
            return;
        }

        Rotate();
    }

    private void Rotate()
    {
        cameraSettings.m_XAxis.Value += rotationSpeed * Time.deltaTime;
    }

    private void ChangeAxis(string xAxis, string yAxis)
    {
        cameraSettings.m_XAxis.m_InputAxisName = xAxis;
        cameraSettings.m_YAxis.m_InputAxisName = yAxis;
    }
}
