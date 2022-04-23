using UnityEngine;

public class ObjectToPlace : MonoBehaviour
{
    public GameObject objectToPlace;

    private static ObjectToPlace instance;
    public static ObjectToPlace Instance
    {
        get
        {
            if (instance == null) instance = FindObjectOfType<ObjectToPlace>();
            return instance;
        }
    }
}
