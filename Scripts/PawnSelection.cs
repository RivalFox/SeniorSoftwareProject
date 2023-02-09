using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class PawnSelection : MonoBehaviour
{
    List<GameObject> pawns;
    //List<GameObject> pawnSelected;
    private Pawn pawn;
    private static int numSelected;
    private static int maxSelected =1;
    

    // Start is called before the first frame update
    void Start()
    {
        //pawns = GameObject.FindGameObjectsWithTag("Pawn");
        pawns = new List<GameObject>(GameObject.FindGameObjectsWithTag("Pawn"));
        //pawnSelected = new List<GameObject>();
        
        numSelected = 0;
    }


    // Update is called once per frame
    void Update()
    {
        foreach (GameObject pawnObject in pawns)
        {
            pawn = pawnObject.GetComponent<Pawn>();

            if(pawn.isSelected == true && numSelected == 0)
            {
                numSelected += 1;
                Debug.Log(numSelected);
                if (numSelected == maxSelected)
                {
                    Debug.Log("Max Number Selected");
                    
                }
            }
        }
            
            //if(pawn.isSelected == true)
            //{
            //    pawns.Remove(pawnObject);
            //    pawnSelected.Add(pawnObject);
                
            //    //Debug.Log(pawns.Count);
            //    Debug.Log(pawnSelected.Count);

            //    if(pawnSelected.Count == 1)
            //    {
                    
            //        //pawn.enabled = false;
            //        //pawn.enabled = true;
            //        Debug.Log("Max Selected");
            //    }
            //}
        //}
    }
}

