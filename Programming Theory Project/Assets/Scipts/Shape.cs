using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public string shapeName{get; set;}// ENCAPSULATION
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void OnMouseDown()// ABSTRACTION
    {
        shapeName = gameObject.name;
        Debug.Log($"This is a {shapeName}");
    }
}
