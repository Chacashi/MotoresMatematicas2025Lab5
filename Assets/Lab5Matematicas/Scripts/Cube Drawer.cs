using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDrawer : MonoBehaviour
{
    [SerializeField] private Vector3 TranslationVector;
    [SerializeField] private Vector3 ScaleVector = Vector3.one;
    [SerializeField] private PivotDrawer[] pivotDrawers;

    private Vector3 previousTranslation;
    private Vector3 previousScale = Vector3.one;
    private Vector3[] initialPositions;

    private void Start()
    {
        previousTranslation = TranslationVector;
        previousScale = ScaleVector;


        Vector3 center = CalculateCenter();
        initialPositions = new Vector3[pivotDrawers.Length];

        for (int i = 0; i < pivotDrawers.Length; i++)
        {
            initialPositions[i] = pivotDrawers[i].transform.position - center;
        }
        ApplyTransformations();
    }

    private void Update()
    {
        if (TranslationVector != previousTranslation || ScaleVector != previousScale)
        {
            ApplyTransformations();
            previousTranslation = TranslationVector;
            previousScale = ScaleVector;
        }
    }

    void ApplyTransformations()
    {
        Vector3 center = CalculateCenter();
        for (int i = 0; i < pivotDrawers.Length; i++)
        {
            Vector3 scaledOffset = Vector3.Scale(initialPositions[i], ScaleVector);
            pivotDrawers[i].transform.position = TranslationVector + scaledOffset;
        }
    }

    Vector3 CalculateCenter()
    {
        if (pivotDrawers == null || pivotDrawers.Length == 0) return Vector3.zero;

        Vector3 sum = Vector3.zero;
        for (int i = 0; i < pivotDrawers.Length; i++)
        {
            sum += pivotDrawers[i].transform.position;
        }

        return sum / pivotDrawers.Length;
    }


}
