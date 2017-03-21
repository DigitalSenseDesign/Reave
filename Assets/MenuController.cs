using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuController : MonoBehaviour {

    void Awake()
    {
        Debug.Log("Menu Controller - Getting buttons");
        var singlePlayer = GameObject.Find("SinglePlayer").GetComponent<Button>();
        var COOP = GameObject.Find("COOP").GetComponent<Button>();
        var KeyboardMouse = GameObject.Find("KeyboardMouse").GetComponent<Button>();
        var Controller = GameObject.Find("Controller").GetComponent<Button>();
        var Level_One = GameObject.Find("Level_One").GetComponent<Button>();
        var Level_Two = GameObject.Find("Level_Two").GetComponent<Button>();
        var Level_Three = GameObject.Find("Level_Three").GetComponent<Button>();

        Debug.Log("Menu Controller - Adding Button Listeners");
        singlePlayer.onClick.AddListener(() => SinglePlayer_Click());
        COOP.onClick.AddListener(() => COOP_Click());
        KeyboardMouse.onClick.AddListener(() => KeyboardMouse_Click());
        Controller.onClick.AddListener(() => Controller_Click());
        Level_One.onClick.AddListener(() => Level_One_Click());
        Level_Two.onClick.AddListener(() => Level_Two_Click());
        Level_Three.onClick.AddListener(() => Level_Three_Click());
        Debug.Log("MenuController - Finished waking");
    }

	void Start () {
	
	}
	
	void Update () {
	
	}

    public void SinglePlayer_Click ()
    {
        Debug.Log("SinglePlayer_Click");
    }
    public void COOP_Click()
    {
        Debug.Log("COOP_Click");
    }
    public void KeyboardMouse_Click()
    {
        Debug.Log("KeyboardMouse_Click");
    }
    public void Controller_Click()
    {
        Debug.Log("Controller_Click");
    }
    public void Level_One_Click()
    {
        Debug.Log("Level_One_Click");
    }
    public void Level_Two_Click()
    {
        Debug.Log("Level_Two_Click");
    }
    public void Level_Three_Click()
    {
        Debug.Log("Level_Three_Click");
    }
}
