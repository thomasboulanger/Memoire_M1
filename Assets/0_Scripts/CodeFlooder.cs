using Unity.VisualScripting;
using UnityEngine;

public class CodeFlooder : MonoBehaviour
{
    [SerializeField] private int numberOfObjectFound = 10000;
    
    private void Update()
    {
        for (int count = 0; count < numberOfObjectFound; count++)
        {
            var array = FindObjectsOfType(typeof(GameObject));
            foreach (var element in array)
            {
                Transform to = element.GetComponent<Transform>();
            }

            count += array.Length;
            Debug.Log(count + " object found !");
        }
    }
}