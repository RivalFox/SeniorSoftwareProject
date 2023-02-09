using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject[] currentGamePieces;
    public GameObject frontAdjacentNode;
    public GameObject backAdjacentNode;
    public GameObject sideAdjacentNode;

    private void Start()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            frontAdjacentNode = hit.transform.gameObject;
        }
        ray = new Ray(this.transform.position, - this.transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            backAdjacentNode = hit.transform.gameObject;

        }
        else
        {
            print(this.gameObject +    "did not hit");
            ray = new Ray(this.transform.position, this.transform.right);
            if (Physics.Raycast(ray, out hit))
            {
                backAdjacentNode = hit.transform.gameObject;
            }
                
        }
        
        ray = new Ray(this.transform.position, this.transform.right);
        if (Physics.Raycast(ray, out hit))
        {
            sideAdjacentNode = hit.transform.gameObject;
        }
    }

}
    
