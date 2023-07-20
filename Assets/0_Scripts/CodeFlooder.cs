using UnityEngine;

public class CodeFlooder : MonoBehaviour
{
    [SerializeField] private int numberOfCalls = 1000;
    private void Update()
    {
        for (int i = 0; i < numberOfCalls; i++)
        {
            var array = FindObjectsOfType(typeof(GameObject));
            Debug.Log(array.Length + " object found !");
        }
    }
}
