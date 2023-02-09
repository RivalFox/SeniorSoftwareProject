using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    private Renderer renderer;
    public Material normalMaterial;
    public Material selectedMaterial;
    public bool isSelected;
    public bool canSelect;
    private static int numSelected;
    private static int maxSelected = 1;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        canSelect = true;
    }
    public void SelectedPiece()
    {
        renderer.material = selectedMaterial;
    }

    public void DeselectPiece()
    {
        renderer.material = normalMaterial;
    }

    private void OnMouseDown()
    {
        if(canSelect == true && numSelected == 0)
        {
            isSelected = true;
            SelectedPiece();
            numSelected += 1;
            Debug.Log(numSelected);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(isSelected == true && numSelected == maxSelected)
        {
             if (Input.GetKeyDown(KeyCode.Space)) 
             {
                isSelected = false;
                DeselectPiece();
                numSelected -= 1;
             }
        }
    }
    

}
