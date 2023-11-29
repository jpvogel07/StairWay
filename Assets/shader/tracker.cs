using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class tracker : MonoBehaviour
{
    void Update()
    {
        Shader.SetGlobalVector("_override", transform.position);
    }
}
