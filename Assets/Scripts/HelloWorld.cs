using UnityEngine;

public class HelloWorld : MonoBehaviour 
{
    [SerializeField]
    private string text;

	// Use this for initialization
	private void Start () 
	{
		print(text);  // Just print the input string to the console.
	}
}
