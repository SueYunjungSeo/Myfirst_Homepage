/*

Instructions
------------
Create an implementation of the Robot class with the following traits:

- Name the derived class Sonny
- Sonny's version should be 2.0.0.0
- Sonny's greeting should be "Hello, my name is Sonny" (bonus points for using reflection)
- Add a fourth law: "A robot may not harm humanity, or, by inaction, allow humanity to come to harm"

*/

using System;
using System.Collections.Generic;

public class Program
{
	public void Main()
	{

		Robot robot = new Sonny(new Version("2.0.0.0"));

		Console.WriteLine("Greeting: {0}", robot.Greeting());
		Console.WriteLine("Robot Version: {0}", robot.Version);

		List<string> laws = robot.GetLaws();
		foreach(string law in laws)
		{
			Console.WriteLine("Law #{0}: {1}", laws.IndexOf(law) + 1, law);
		}
	}
}

// Do you work here...
public class Sonny : Robot{

	private List<string> _laws = new List<string>();
	public Sonny(Version sonnyversion) : base(sonnyversion) {}
	public override string Greeting()
	{
		return "Hello, my name is Sonny";
	}

	public override List<string> GetLaws()
	{
		this._laws = base.GetLaws();
		this._laws.Add("A robot may not harm humanity, or, by inaction, allow humanity to come to harm");
		return this._laws;
	}
}

public abstract class Robot
{
    private readonly List<string> _laws = new List<string>
	{
		"A robot may not injure a human being or, through inaction, allow a human being to come to harm.",
		"A robot must obey the orders given it by human beings, except where such orders would conflict with the First Law.",
		"A robot must protect its own existence as long as such protection does not conflict with the First or Second Law."
	};

    protected Robot(Version version)
    {
        Version = version;
    }

    public abstract string Greeting();

    public Version Version { get; set; }

    public virtual List<string> GetLaws()
    {
    	return _laws;
    }
}
