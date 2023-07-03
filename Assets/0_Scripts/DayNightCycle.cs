using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5;
    
    private void Update() => transform.Rotate(Time.deltaTime * rotationSpeed,0,0);
}
