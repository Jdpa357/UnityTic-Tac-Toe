using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttn : MonoBehaviour
{
	Button yourButton;
	Image myImageComponent;
	public Sprite myFirstImage; //Drag your first sprite here in inspector.
	public Sprite mySecondImage; //Drag your second sprite here in inspector.
	int state = 0;
	GameController gameController;
	public int player;
	void Start() //Lets start by getting a reference to our image component.
	{
	
	}

	 void Update()
    {
		GameObject controller = GameObject.Find("GameController");
        GameController turn = controller.GetComponent<GameController>();

		if (turn.turn == 1)
		{
			yourButton.onClick.AddListener(SetImage1);
		}
		else
		{
			yourButton.onClick.AddListener(SetImage2);
		}
		
    }

	void Awake(){
		yourButton =  GetComponent<Button>();
		myImageComponent = GetComponent<Image>(); //Our image component is the one attached to this gameObject.
	}
	
	public void SetImage1() //method to set our first image
	{
		yourButton.interactable = false;
		myImageComponent.sprite = myFirstImage;
		player = 2;
	}
	public void SetImage2() //method to set our first image
	{
		yourButton.interactable = false;
		myImageComponent.sprite = mySecondImage;
		player = 1;
	}

}
