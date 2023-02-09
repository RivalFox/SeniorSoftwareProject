using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    public enum StartingNode { Greenhome, Redhome, Bluehome, Yellowhome }
    public StartingNode startingNode;
    public GameObject currentNode;
    public GameObject nextNode;

    public int spaces =1;
    private bool canMove;

    private void Start()
    {
        currentNode = GameObject.Find(startingNode.ToString());
        nextNode = GameObject.Find(startingNode.ToString());
    }
    private void Update()
    {

        if(CardManager.card == null)
        {
            spaces = 0;
        }
        else if (CardManager.card.ToString() == "Card_1 (Card)")
        {
            spaces = 1;
        }
        else if(CardManager.card.ToString() == "Card_2 (Card)")
        {
            spaces = 2;
        }
        else if (CardManager.card.ToString() == "Card_3 (Card)")
        {
            spaces = 3;
        }
        else if (CardManager.card.ToString() == "Card_4 (Card)")
        {
            spaces = -4;
        }
        else if (CardManager.card.ToString() == "Card_5 (Card)")
        {
            spaces = 5;
        }
        else if (CardManager.card.ToString() == "Card_7 (Card)")
        {
            spaces = 7;
        }
        else if (CardManager.card.ToString() == "Card_8 (Card)")
        {
            spaces = 8;
        }
        else if (CardManager.card.ToString() == "Card_10 (Card)")
        {
            spaces = 10;
        }
        else if (CardManager.card.ToString() == "Card_11 (Card)")
        {
            spaces = 11;
        }
        else if (CardManager.card.ToString() == "Card_12 (Card)")
        {
            spaces = 12;
        }
        else if (CardManager.card.ToString() == "Card_S (Card)")
        {
            spaces = 0;
        }
        else
        {
            Debug.LogWarning(CardManager.card.ToString());
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.LogWarning("number of spaces - " + spaces);
            StartCoroutine(MovePieces(spaces));
            CardManager.canDraw = true;
        }
        /*
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            spaces--;
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            spaces++;
        }
        transform.position = Vector3.Lerp(transform.position, nextNode.transform.position, .0075f);
        //If piece moves into the location of another piece send it back to start
        //if(current location has current game piece)
        //lerp game piece back to starting
        */
        transform.position = Vector3.MoveTowards(transform.position, nextNode.transform.position, .0075f);
    }
    private IEnumerator MovePieces(int spaces)
    {
        if (spaces > 0)
        {
            for (int i = 0; i < spaces; i++)
            {
                nextNode = currentNode.GetComponent<Node>().frontAdjacentNode;
                currentNode = nextNode;
                yield return new WaitForSeconds(.5f);
            }
        }
        else if (spaces == 0)
        {
            nextNode = GameObject.Find(startingNode.ToString());
            currentNode = nextNode;
            yield return new WaitForSeconds(.5f);

        }
        else
        {
            for (int i = 0; i > spaces; i--)
            {
                nextNode = currentNode.GetComponent<Node>().backAdjacentNode;
                currentNode = nextNode;
                yield return new WaitForSeconds(.5f);

            }
        }
    }
}
