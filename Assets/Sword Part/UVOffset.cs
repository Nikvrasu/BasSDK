using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVOffset : MonoBehaviour
{
    private Material myMaterial;
    public Vector2 OffsetRate;
    private Vector2 Offset;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Offset += OffsetRate;
        myMaterial.SetTextureOffset("_MainTex", new Vector2(Offset.x, Offset.y));
    }
}
