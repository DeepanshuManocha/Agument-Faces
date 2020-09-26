using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFilter : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    
    public void ChooseFiler (Material material)
    {
        meshRenderer.material = material;
    }
}
