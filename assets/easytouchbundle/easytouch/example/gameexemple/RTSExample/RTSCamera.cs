using UnityEngine;
using System.Collections;

public class RTSCamera : MonoBehaviour {

	private Vector3 delta;
    public float sensivity_rotating;
    public GameObject points;
	void OnEnable()
    {
		EasyTouch.On_Swipe += On_Swipe;
		EasyTouch.On_Drag += On_Drag;
		EasyTouch.On_Twist += On_Twist;
		EasyTouch.On_Pinch += On_Pinch;
	}
 void Update()
    {
        if(EasyTouch.GetTouchCount()==0)
        {
            points.SetActive(true);
        }

    }

	
	void On_Twist (Gesture gesture){

		transform.Rotate( Vector3.up * gesture.twistAngle);
	}

	void OnDestroy(){
		EasyTouch.On_Swipe -= On_Swipe;
		EasyTouch.On_Drag -= On_Drag;
		EasyTouch.On_Twist -= On_Twist;
	}
   

	void On_Drag (Gesture gesture)
    {
		On_Swipe( gesture);
        points.SetActive(false);
    }

	void On_Swipe (Gesture gesture)
    {
		transform.Rotate(Vector3.down * gesture.deltaPosition.x / Screen.width*sensivity_rotating);
		transform.Rotate( Vector3.left * gesture.deltaPosition.y / Screen.height*sensivity_rotating*1/5);
	}

	void On_Pinch (Gesture gesture){	
		Camera.main.fieldOfView += gesture.deltaPinch * Time.deltaTime;
	}

}
