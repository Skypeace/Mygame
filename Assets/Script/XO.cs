using UnityEngine;
using System.Collections;

using UnityEngine.UI;


public class XO : MonoBehaviour {

	public Text button1;
	public Text button2;
	public Text button3;
	public Text button4;
	public Text button5;
	public Text button6;
	public Text button7;
	public Text button8;
	public Text button9;
	public Button but1, but2, but3, but4, but5, but6, but7, but8, but9;
	private bool play;
	public GameObject xwin;
	public GameObject owin;
	public GameObject draw;
	private int draws;
	void Start () {
		play = true;

	}
	

	void Update () {
		Xwin ();
		Owin ();
		Draw ();
	}
	public void loadlevel(){
		Application.LoadLevel ("OX minigame");
	}

	public void bu1() {
		if (play){
		
			button1.text = "X";
				play = false;
		}
		else{

			button1.text = "O";
				play = true;
		}
		but1.enabled = false;
		draws = draws + 1;
	}

	public void bu2() {
		if (play){
			
			button2.text = "X";
			play = false;
		}
		else{
			
			button2.text = "O";
			play = true;
		}
		but2.enabled = false;
		draws = draws + 1;
	}

	public void bu3() {
		if (play){
			
			button3.text = "X";
			play = false;
		}
		else{
			
			button3.text = "O";
			play = true;
		}
		but3.enabled = false;
		draws = draws + 1;
	}

	public void bu4() {
		if (play){
		
			button4.text = "X";
				play = false;
		}
		else{

			button4.text = "O";
				play = true;
		}
		but4.enabled = false;
		draws = draws + 1;
	}

	public void bu5() {
		if (play){
			
			button5.text = "X";
			play = false;
		}
		else{
			
			button5.text = "O";
			play = true;
		}
		but5.enabled = false;
		draws = draws + 1;
	}

	public void bu6() {
		if (play){
			
			button6.text = "X";
			play = false;
		}
		else{
			
			button6.text = "O";
			play = true;
		}
		but6.enabled = false;
		draws = draws + 1;
	}

	public void bu7() {
		if (play){
			
			button7.text = "X";
			play = false;
		}
		else{
			
			button7.text = "O";
			play = true;
		}
		but7.enabled = false;
		draws = draws + 1;
	}
	public void bu8() {
		if (play){
			
			button8.text = "X";
			play = false;
		}
		else{
			
			button8.text = "O";
			play = true;
		}
		but8.enabled = false;
		draws = draws + 1;
	}

	public void bu9() {
		if (play){
			
			button9.text = "X";
			play = false;
		}
		else{
			
			button9.text = "O";
			play = true;
		}
		but9.enabled = false;
		draws = draws + 1;
	}

	public void Xwin(){
		if (button1.text == "X" && button2.text == "X" && button3.text == "X") {
		
			xwin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button4.text == "X" && button5.text == "X" && button6.text == "X") {
			
			xwin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button7.text == "X" && button8.text == "X" && button9.text == "X") {
			
			xwin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button1.text == "X" && button4.text == "X" && button7.text == "X") {
			
			xwin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button2.text == "X" && button5.text == "X" && button8.text == "X") {
			
			xwin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button3.text == "X" && button6.text == "X" && button9.text == "X") {
			
			xwin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button1.text == "X" && button5.text == "X" && button9.text == "X") {
			
			xwin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button3.text == "X" && button5.text == "X" && button7.text == "X") {
			
			xwin.SetActive (true);
			Invoke ("loadlevel", 3);
		}
	}
	public void Owin(){
		if (button1.text == "O" && button2.text == "O" && button3.text == "O") {
			
			owin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button4.text == "O" && button5.text == "O" && button6.text == "O") {
			
			owin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button7.text == "O" && button8.text == "O" && button9.text == "O") {
			
			owin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button1.text == "O" && button4.text == "O" && button7.text == "O") {
			
			owin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button2.text == "O" && button5.text == "O" && button8.text == "O") {
			
			owin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button3.text == "O" && button6.text == "O" && button9.text == "O") {
			
			owin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button1.text == "O" && button5.text == "O" && button9.text == "O") {
			
			owin.SetActive (true);
			Invoke ("loadlevel", 3);
		} else if (button3.text == "O" && button5.text == "O" && button7.text == "O") {
			
			owin.SetActive (true);
			Invoke ("loadlevel", 3);
		}
	}
	public void Draw(){
		if (draws == 9) {
			draw.SetActive (true);
			Invoke ("loadlevel", 3);
		}
	}
}