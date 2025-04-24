using UnityEngine;


[CreateAssetMenu(fileName = "PivotData", menuName = "Scriptable Objects/Drawers/Pivot")]
public class PivotData : ScriptableObject
{
    [SerializeField] private float pivotRadius;
    [SerializeField] private Color pivotColor;
    [SerializeField] private Color rayColor;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 startScale;

    public float PivotRadius => pivotRadius;
    public Color PivotColor => pivotColor;
    public Color RayColor => rayColor;
    public Vector3 StartPosition => startPosition;
    public Vector3 StartScale => startScale;
}
