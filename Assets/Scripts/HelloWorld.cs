using UnityEngine;

public class HelloWorld : MonoBehaviour 
{
    [SerializeField]
    private string context;

	// Use this for initialization
	private void Start () 
	{
		print(context);  // Just print the input string to the console.
	}
}
