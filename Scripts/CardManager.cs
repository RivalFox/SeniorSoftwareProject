using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
	public List<Card> deck = new List<Card>();
	
	public static Card card;

	public static bool canDraw = true;



	public void DrawCard()
	{
		if (canDraw)
		{
			for (int i = 0; i < deck.Count; i++)
			{
				Card card = deck[i];
				if (card.gameObject.activeInHierarchy == true)
				{
					card.gameObject.SetActive(false);
				}
			}

			card = deck[Random.Range(0, deck.Count)];

			if (card != null)
			{
				card.gameObject.SetActive(true);
				print(deck.IndexOf(card));
			}
			canDraw = false ;
		}
		
	}
}
