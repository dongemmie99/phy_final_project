using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesSpeech : MonoBehaviour {
	[SerializeField]
	Canvas messageCanvas;

	// Use this for initialization
	void Start () {
		messageCanvas.enabled = false;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player")
		{
			TurnOnMessage ();
		}
	}
	private void TurnOnMessage()
	{
		messageCanvas.enabled = true;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.name == "Player")
		{
			TurnOffMessage ();
		}
	}
	private void TurnOffMessage()
	{
		messageCanvas.enabled = false;
	}


}



