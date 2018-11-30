using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class textBehaviour : MonoBehaviour
{
   
    public TapMe[] button_Script;
    Animator anim;
    void Start()
    {

        this.gameObject.GetComponent<Text>().text = "";
        anim = this.gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        for (int i = 0; i <= button_Script.Length - 1; i++)
        {

            if (button_Script[i].Tapping_Button.Length >= 5)
            {

                this.gameObject.GetComponent<Text>().text = button_Script[i].textValue;
              
            }
           
            }


    }
   
    }
   

	

