using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneLoader : MonoBehaviour {


	public void SceneChanger(int SceneIndex){

		SceneManager.LoadScene (SceneIndex);
	}
}
