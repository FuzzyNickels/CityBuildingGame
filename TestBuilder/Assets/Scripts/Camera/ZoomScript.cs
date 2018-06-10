using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScript : MonoBehaviour {
    public float zoomSpeed = 1;
    public float targetOrtho;
    public float smoothSpeed = 2.0f;
    public float minOrtho = 1.0f;
    public float maxOrtho = 20.0f;

	// Use this for initialization
	void Start () {
        targetOrtho = Camera.main.orthographicSize;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)){
            selectTile();
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0.0f)
        {
            targetOrtho -= scroll * zoomSpeed;
            targetOrtho = Mathf.Clamp(targetOrtho, minOrtho, maxOrtho);
        }

        Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
    }

    void selectTile(){
        Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //RaycastHit2D hit = Physics2D.Raycast(Camera.main.transform.position, mousePoint);
        RaycastHit2D hit = Physics2D.Raycast(mousePoint, Vector2.down);

        if (hit.collider != null){
            if(hit.collider.tag == "Tile"){
                GameObject hitObject = hit.collider.gameObject;
                Debug.Log(hitObject.name);
                SpriteRenderer hit_sr = hitObject.GetComponent<SpriteRenderer>();
                hit_sr.color = Color.red;
            }
        }
    }
}