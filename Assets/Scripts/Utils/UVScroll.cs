using UnityEngine;
using System.Collections;

public class UVScroll : MonoBehaviour
{
	[SerializeField]
	private Vector2 speed;
	[SerializeField]
	private Renderer bgRendered;

	void LateUpdate()
	{
		bgRendered.material.mainTextureOffset += speed * Time.deltaTime;
	}
}
