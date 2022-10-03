using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeApartments : MonoBehaviour
{
    MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        Color colorHSV = Random.ColorHSV(Random.Range(0.0f, 1.0f), 1.0f);
        _meshRenderer.material.color = colorHSV;
    }
}
