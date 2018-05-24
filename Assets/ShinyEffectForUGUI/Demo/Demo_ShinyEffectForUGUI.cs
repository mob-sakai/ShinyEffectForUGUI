using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	public class Demo_ShinyEffectForUGUI : MonoBehaviour
	{
		[SerializeField] RectMask2D mask;

		void Start()
		{
			mask.enabled = true;
		}
	}
}