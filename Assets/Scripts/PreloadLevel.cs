﻿using UnityEngine;
using System.Collections;

public class PreloadLevel : MonoBehaviour {

	//public Animator menuAnim;

	AsyncOperation async;
	bool puedeCargar;

	int indice = 0;


	public void Idioma(int index)
	{
		SeleccionarIdioma.instance.ElejirIdioma(index);
	}

	public void CargarEscena()
	{

		puedeCargar = true;
		async.allowSceneActivation = true;
	}

	public void Escena(int index)
	{
		SceneManager.instance.escena = index;
	}


	public void CargarPagina(int index)
	{
		indice = index;
	}


	public void LoadEscena()
	{
		Application.LoadLevel(1);
	}


	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();

//		if(puedeCargar)
//		{
//			if(async != null && async.isDone)
//			{
//				print ("peo");
//			}
//		}
	}

}
