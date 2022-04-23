using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectObjectToPlace : MonoBehaviour
{
    [SerializeField] private GameObject objectToPlace;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(SelectObject);
    }

    private void SelectObject()
    {
        ObjectToPlace.Instance.objectToPlace = objectToPlace;
    }
}
