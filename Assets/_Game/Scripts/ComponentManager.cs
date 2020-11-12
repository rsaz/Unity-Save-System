using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var components = gameObject.GetComponents<Component>();
        foreach (var component in components)
        {
            print(component.GetType());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
