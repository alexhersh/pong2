﻿using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	private Animator _animator;
	private CanvasGroup _canvas_group;

	public bool IsOpen {
		get { return _animator.GetBool("IsOpen"); }
		set { _animator.SetBool("IsOpen", value); }
	}

	public void Awake(){
		_animator = GetComponent<Animator> ();
		_canvas_group = GetComponent<CanvasGroup> ();

		var rect = GetComponent<RectTransform> ();
		rect.offsetMax = rect.offsetMin = new Vector2 (0, 0);
	}
	
	public void Update() {
		if (!_animator.GetCurrentAnimatorStateInfo(0).IsName ("Open")) {
			_canvas_group.blocksRaycasts = _canvas_group.interactable = false;
		} else {
			_canvas_group.blocksRaycasts = _canvas_group.interactable = true;
		}
	}
}
