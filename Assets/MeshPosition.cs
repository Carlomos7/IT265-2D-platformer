using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeshPosition : MonoBehaviour
{
    public Camera mainCamera;
    public TextMeshProUGUI textMesh;
    public float offset = 20f;
    private RectTransform rectTransform;
    private Vector2 screenBounds;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        screenBounds = new Vector2(Screen.width, Screen.height);
    }

    void Update()
    {
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(screenBounds.x - offset, screenBounds.y - offset, mainCamera.nearClipPlane));
        Vector3 screenPosition = mainCamera.WorldToScreenPoint(worldPosition);
        rectTransform.anchoredPosition = new Vector2(screenPosition.x, screenPosition.y);
    }
}
