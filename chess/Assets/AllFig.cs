using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TypeFig", order = 50)]
public class AllFig : ScriptableObject
{
    [SerializeField] private GameObject Pawn;
    [SerializeField] private GameObject Rook;
    [SerializeField] private GameObject Knigth;
    [SerializeField] private GameObject Queen;
    [SerializeField] private GameObject King;
    [SerializeField] private GameObject Dark;
    public GameObject pawn => Pawn;
    public GameObject rook => Rook;
    public GameObject knigth => Knigth;
    public GameObject queen => Queen;
    public GameObject king => King;
    public GameObject dark => Dark;

}
