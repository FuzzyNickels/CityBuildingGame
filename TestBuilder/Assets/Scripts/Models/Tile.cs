using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public Tile (){

	}

	private SpriteRenderer spriteR;
	public Sprite[] sprites;
	// 0 = Trees (Grassy)
	// 1 = Water
	// 2 = Dirt
	// 3 = Building

	// Use this for initialization
	void Start () {
		spriteR = this.GetComponent<SpriteRenderer>();
		Sprite tileSprite = randomizeSprite();
		spriteR.sprite = tileSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Sprite randomizeSprite(){
		
		int randomNum = Random.Range(0, 4);
		Sprite setSprite = sprites[randomNum];
		return setSprite;
	}
	
}
