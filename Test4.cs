/*

Instructions
------------
Use generics to improve this program.
Feel free to refactor the code as needed, however, the output should remain unchanged.

*/

using System;

class Response<T>{

	public bool Success { get; set; }
	public int StatusCode { get; set; }
	public T Data { get; set; }

}

public class Program
{
	public void Main()
	{
		/*ResponseString responseString = new ResponseString { Success = true, StatusCode = 200, Data = "{ foo: \"bar\" }" };
		ResponseDecimal responseDecimal = new ResponseDecimal { Success = true, StatusCode = 200, Data = 19.99M };
		ResponseDateTime responseDateTime = new ResponseDateTime { Success = true, StatusCode = 200, Data = DateTime.Parse("4/13/2015 4:00PM") };

		Console.WriteLine("String Response: {0}", responseString.Data);
		Console.WriteLine("Decimal Response: {0}", responseDecimal.Data);
		Console.WriteLine("DateTime Response: {0}", responseDateTime.Data);*/

		Response<String> responseString = new Response<String> { Success = true, StatusCode = 200, Data = "{ foo: \"bar\" }" };
		Response<Decimal> responseDecimal = new Response<Decimal> { Success = true, StatusCode = 200, Data = 19.99M };
		Response<DateTime> responseDateTime = new Response<DateTime> { Success = true, StatusCode = 200, Data = DateTime.Parse("4/13/2015 4:00PM") };

		Console.WriteLine("String Response: {0}", responseString.Data);
		Console.WriteLine("Decimal Response: {0}", responseDecimal.Data);
		Console.WriteLine("DateTime Response: {0}", responseDateTime.Data);

	}
}

/*
public class ResponseString
{
	public bool Success { get; set; }
	public int StatusCode { get; set; }
	public string Data { get; set; }
}

public class ResponseDecimal
{
	public bool Success { get; set; }
	public int StatusCode { get; set; }
	public decimal? Data { get; set; }
}

public class ResponseDateTime
{
	public bool Success { get; set; }
	public int StatusCode { get; set; }
	public DateTime Data { get; set; }
}*/
