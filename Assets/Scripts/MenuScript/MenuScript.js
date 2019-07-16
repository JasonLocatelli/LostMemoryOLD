#pragma strict

	var canvas1 : GameObject;
	var canvas2 : GameObject;
	var PlayerBag : GameObject;

	function Start () {

	}


//menu principal
function LANCER_LE_JEU () {
 Application.LoadLevel("level1");
}

function OPTION (){
   MenuScriptbis.showGUI1 = false;
   MenuScriptbis.showGUI2 = true;
}

function QUITTERPNG (){

	canvas1.SetActive(true);
	canvas2.SetActive(false);

	
}

function INTERAGIR (){
  	canvas1.SetActive(false);
  	canvas2.SetActive(true);
}

function CHOISIR_LVL1 (){
Application.LoadLevel("level1");
}

function QUITTER_LE_JEU () {
 Application.Quit();
}
