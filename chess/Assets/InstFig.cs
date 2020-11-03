using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstFig : MonoBehaviour
{
    [SerializeField] private PosANDColor[] FigPawn, FigRook, FigKnigth, FigDark, FigQueen, FigKing;
   [SerializeField] private AllFig AllFig;
   private int K = 0;
   private int Color = 0;
    private int J = 0;
    private void Awake()
    {
        //PAWN
        for(int i =0; i<16; i++)
        {
            GameObject PAWN =  Instantiate(AllFig.pawn);
            PAWN.GetComponent<MeshRenderer>().material = FigPawn[K].material[Color];
            PAWN.transform.position = new Vector3(FigPawn[K].posX+(i-J),0, FigPawn[K].posZ);
            Color = i >= 7 ?  1 : 0;
            K = i >= 7 ? 1 : 0;
            J = i >= 7 ? 8 : 0;
        }
        K = 0; Color = 0; J = 0;
        //ROOC
        for (int i = 0; i < 4; i++)
        {
            GameObject ROOK = Instantiate(AllFig.rook);
            ROOK.GetComponent<MeshRenderer>().material = FigRook[K].material[Color];
            ROOK.transform.position = new Vector3(FigRook[K].posX+(7-J), 0, FigRook[K].posZ);
            Color = i == 0 || i==2 ? 0 : 1;
            K = i == 0 || i==2 ? 0 : 1;
            J = i == 0 || i==2  ? 7 : 0;
        }
        K = 0; Color = 0; J = 0;
        //Knigth
        for (int i = 0; i < 4; i++)
        {
            GameObject KINGTH = Instantiate(AllFig.knigth);
            KINGTH.GetComponent<MeshRenderer>().material = FigKnigth[K].material[Color];
            KINGTH.transform.position = new Vector3(FigKnigth[K].posX + (6 - J), 0, FigKnigth[K].posZ);
            Color = i == 0 || i == 2 ? 0 : 1;
            K = i == 0 || i == 2 ? 0 : 1;
            J = i == 0 || i == 2 ? 6 : 0;
        }
        K = 0; Color = 0; J = 0;
        // -//-
    }

    
    
}
