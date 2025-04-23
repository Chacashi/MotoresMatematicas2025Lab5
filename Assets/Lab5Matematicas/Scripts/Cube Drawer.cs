using System;
using UnityEngine;


public class CubeDrawer : MonoBehaviour
{
    [SerializeField] private Vector3 TranslationVector;
    [SerializeField] private Vector3 ScaleVector;
    [SerializeField] private PivotDrawer[] pivotDrawers;
    public static event Action<Vector3> OnTranslateCube;
    public static event Action<Vector3> OnScaleCube;




    private void Update()
    {

        OnTranslateCube?.Invoke(TranslationVector);
        OnScaleCube?.Invoke(ScaleVector);
     
    }

  

}
