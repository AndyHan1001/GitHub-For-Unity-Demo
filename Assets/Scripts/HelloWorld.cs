using UnityEngine;

public class HelloWorld : MonoBehaviour 
{
    [SerializeField]
    private string name;

	// Use this for initialization
	private void Start () 
	{
		print(name);  // Just print the input string to the console.
	}
	
	// Update is called once per frame
	private void Update () 
	{
		
	}
}
