using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextSceneLoader : MonoBehaviour
{
	public Button yourButton;
	public int SceneIdex;

	void Start()
	{ 
	
		Button PlayButton = yourButton.GetComponent<Button>();
		PlayButton.onClick.AddListener(TaskOnClick);

		//PlayButton.onClick.Invoke();
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(SceneIdex);
	}

	public void doExitGame()
	{
		Application.Quit();
	}
}
