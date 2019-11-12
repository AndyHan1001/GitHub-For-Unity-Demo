using UnityEngine;

public class HelloWorld : MonoBehaviour 
{
    [SerializeField]
    private string content;

	// Use this for initialization
	private void Start () 
	{
		print(content);  // Just print the input string to the console.
	}
}
