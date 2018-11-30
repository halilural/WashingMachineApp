using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
public class TapMe : MonoBehaviour {
    public Texture texture_On;
    public Texture texture_Off;
    public string Tapping_Button;
    public string textValue;
    public float wait;
    public Text text;
    public Image image;
	// Subscribe to events
	void OnEnable()
    {
		EasyTouch.On_SimpleTap += On_SimpleTap;
	}
  

	void OnDisable(){
		UnsubscribeEvent();
	}
	
	void OnDestroy(){
		UnsubscribeEvent();
	}
	
	void UnsubscribeEvent(){
		EasyTouch.On_SimpleTap -= On_SimpleTap;
        
    }
	
	// Simple tap
	private void On_SimpleTap( Gesture gesture)
    {
		
		// Verification that the action on the object
		if (gesture.pickedObject == gameObject)
        {
            image.gameObject.SetActive(true);
            gameObject.GetComponent<Renderer>().material.mainTexture = texture_On;
            Tapping_Button = this.gameObject.name;
           image.GetComponent<Animator>().Play("animdf", -1, 0);
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.mainTexture = texture_Off;
            Tapping_Button = "";
        }
	}
}
