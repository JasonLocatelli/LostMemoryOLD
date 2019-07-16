#pragma strict

static var showGUI1 : boolean = false;
static var showGUI2 : boolean = true;
var canvas1 : GameObject;
var canvas2 : GameObject;

function Start ()
{
 canvas1 = GameObject.Find("canvas1");
 canvas2 = GameObject.Find("canvasInteragir");
}

function Update (){

//Canvas 1
if (showGUI1 == true) {
canvas1.SetActive(true);
} else {
canvas1.SetActive(false);
}

//canvas2
if (showGUI2 == true) {
canvas2.SetActive(true);
} else {
canvas2.SetActive(false);
}



/////////////////////////////////////////////////////////////////////////////////////escape

/*if (Input.GetKeyDown(KeyCode.Escape))
  {
  if(showGUI1 == true)
    {
    Application.Quit();
    }

    if(showGUI2 == true)
    {
    showGUI1 = true;
    showGUI2 = false;
    }
  }*/
}