using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotDrawer : MonoBehaviour
{

    [SerializeField] private PivotDrawer pivotDrawer1;
    [SerializeField] private PivotDrawer pivotDrawer2;
    [SerializeField] private PivotDrawer pivotDrawer3;
    [SerializeField] private PivotData pivotData;
    private float pivotRadious;
     private Color pivotColor;
     private Color rayColor;
     private Vector3 startPosition;
     private Vector3 startScale;


    private Vector3 _translateVector;
    private Vector3 _scaleVector;
    public Vector3 PivotPosition => transform.position;

    private void Awake()
    {

        startPosition = transform.position;
        startScale = transform.localScale;
        pivotRadious = pivotData.PivotRadius;
        pivotColor = pivotData.PivotColor;
        rayColor = pivotData.RayColor;
        startPosition = pivotData.StartPosition;
        startScale = pivotData.StartScale;
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = pivotColor;
        Gizmos.DrawWireSphere(PivotPosition, pivotRadious);

        Gizmos.color = rayColor;
        Gizmos.DrawLine(PivotPosition, pivotDrawer1.PivotPosition);
        Gizmos.DrawLine(PivotPosition, pivotDrawer2.PivotPosition);
        Gizmos.DrawLine(PivotPosition, pivotDrawer3.PivotPosition);
    }


    public void TranslatePivot(Vector3 translation)
    {
        _translateVector = translation;

        transform.position = startPosition + _translateVector;
    }

    public void ScalePivot(Vector3 scale)
    {
  
        _scaleVector = scale;
        transform.position = Vector3.Scale(startPosition, _scaleVector) + _translateVector;
    }



    private void OnEnable()
    {

        CubeDrawer.OnTranslateCube += TranslatePivot;
        CubeDrawer.OnScaleCube += ScalePivot;
    }


    private void OnDisable()
    {
        CubeDrawer.OnTranslateCube -= TranslatePivot;
        CubeDrawer.OnScaleCube -= ScalePivot;
    }


}
