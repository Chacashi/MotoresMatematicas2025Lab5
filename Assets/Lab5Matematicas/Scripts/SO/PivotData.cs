using UnityEngine;

[CreateAssetMenu(fileName = "PivotData", menuName = "Scriptable Objects/Drawers/Pivot")]
public class PivotData : ScriptableObject

{
    [SerializeField] private float pivotRadius = 1f;
    [SerializeField] private Color pivotColor = Color.yellow;
    [SerializeField] private Color rayColor = Color.red;
    [SerializeField] private Vector3 startPosition = Vector3.zero;
    [SerializeField] private Vector3 startScale = Vector3.one;

    public float PivotRadius => pivotRadius;
    public Color PivotColor => pivotColor;
    public Color RayColor => rayColor;
    public Vector3 StartPosition => startPosition;
    public Vector3 StartScale => startScale;


}
