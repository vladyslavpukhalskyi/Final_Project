using UnityEngine;
using DG.Tweening; 

public class RotateCube : MonoBehaviour
{
    [SerializeField] private float rotationAngle = 360f; 
    [SerializeField] private float rotationDuration = 2f; 
    [SerializeField] private Ease rotationEase = Ease.InOutQuad; 

    [SerializeField] private Vector3 punchScale = new Vector3(0.1f, 0.1f, 0.1f); 
    [SerializeField] private float punchDuration = 0.5f; 
    [SerializeField] private int punchVibrato = 6; 
    [SerializeField] private float punchElasticity = 0.5f; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log($"<color=cyan>①</color> [{System.DateTime.Now:HH:mm:ss}] Pressed button <color=yellow>'1'</color>: <color=green>Rotating the object</color>");
            RotateWithEase();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log($"<color=cyan>②</color> [{System.DateTime.Now:HH:mm:ss}] Pressed button <color=yellow>'2'</color>: <color=green>Applying Punch Scale animation</color>");
            ApplyPunchScale();
        }
    }

    private void RotateWithEase()
    {
        transform.DORotate(new Vector3(0, rotationAngle, 0), rotationDuration, RotateMode.FastBeyond360)
            .SetEase(rotationEase); 
    }

    private void ApplyPunchScale()
    {
        transform.DOPunchScale(punchScale, punchDuration, punchVibrato, punchElasticity);
    }
}