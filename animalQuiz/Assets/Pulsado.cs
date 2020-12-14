using UnityEngine;
using System.Collections;

public class Pulsado : MonoBehaviour {
	
	void Update(){
				if (Input.touches.Length > 0) {
						for (int i=0; i < Input.touchCount; i++) {

					if (this.guiText.HitTest (Input.GetTouch (i).position)) {
						if(AnimalSeleccinado.animal == this.name)
							Application.LoadLevel ("MuyBien");
					}


				}
			}
		}

}
