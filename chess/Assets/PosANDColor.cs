using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TypeFig", order = 50)]

public class PosANDColor : ScriptableObject
{
    [SerializeField] private Material[] Material;
    [SerializeField] private float PosZ;
    [SerializeField] private float PosX;
    public Material[] material => Material;
    public float posZ => PosZ;
    public float posX => PosX;
}
