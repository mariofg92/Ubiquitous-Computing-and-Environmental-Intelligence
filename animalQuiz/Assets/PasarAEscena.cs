using UnityEngine;
using System.Collections;

public class PasarAEscena : MonoBehaviour {

	public string EscenaAPasar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 || Input.GetButtonDown ("Fire1")) {
			Application.LoadLevel(EscenaAPasar);
		}
	}
}
