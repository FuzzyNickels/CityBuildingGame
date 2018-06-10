using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour {

	public Sprite testSprite;
	public int worldWidth = 3;
    public int worldHeight = 3;
	public GameObject tileObject;

	// Use this for initialization
	void Start () {
		buildWorld();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void buildWorld(){
		for (int x = 0; x < worldWidth; x++)
        {
            for (int y = 0; y < worldHeight; y++)
            {
				GameObject tempTile;
                tempTile = Instantiate(tileObject, new Vector3(0,0,0), Quaternion.identity);
                tempTile.name = "Tile_" + x + "," + y;
                tempTile.transform.SetParent(this.transform);

				SpriteRenderer tile_sr = tempTile.GetComponent<SpriteRenderer>();

				float tileWidth = tile_sr.bounds.size.x;
                float tileHeight = tile_sr.bounds.size.y;

				float isox = (x - y) * tileWidth / 2;
                float isoy = (x + y) * tileWidth / 4;

				tempTile.transform.position = new Vector2(x, y);

            }

        }
	}
}
