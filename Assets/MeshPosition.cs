using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeshPosition : MonoBehaviour
{
    public Camera mainCamera;
    public TextMeshProUGUI textMesh;
    public Vector2 offset = new Vector2(20f, -20f); // offset from the top-right corner of the camera
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector3 screenPosition = mainCamera.WorldToScreenPoint(mainCamera.transform.position);
        screenPosition += new Vector3(-mainCamera.pixelWidth / 2f, mainCamera.pixelHeight / 2f, 0f); // top-right corner of the camera
        screenPosition += new Vector3(offset.x, offset.y, 0f); // apply offset
        rectTransform.anchoredPosition = screenPosition;
    }
}
