using UnityEngine;
using System.Collections;

public class scaletoScreenSize : MonoBehaviour {

    public float height;
    public float width;
	// Use this for initialization
	void Start () {
        height = Camera.main.orthographicSize * 2.0f;
        width = (height * Screen.width) / Screen.height;
        transform.localScale = new Vector3(width/10,0.1f , height/10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
