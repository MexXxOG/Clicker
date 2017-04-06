using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text MoneyLicz;
	public UnityEngine.UI.Text gpc;
	public float gold = 0.00f;
	public int goldperclick = 1;

	void Update(){
		MoneyLicz.text = "Kasa: " + gold;
		gpc.text = "Atak: " + goldperclick;
	}

	public void Clicked(){
		gold += goldperclick;
	}

}
