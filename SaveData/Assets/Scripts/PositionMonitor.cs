using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PositionMonitor : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] TextMeshProUGUI posXText;
    [SerializeField] TextMeshProUGUI posYText;

    // Start is called before the first frame update
    void Start()
    {
        DetectMovement();
    }

    // Update is called once per frame
    void Update()
    {
        DetectMovement();
    }

    private void DetectMovement()
    {
        posXText.text = $"X: { playerTransform.transform.position.x }";
        posYText.text = $"Y: { playerTransform.transform.position.y }";
    }
}
