using System;
using System.Diagnostics;
					
public class Program
{
	private static Stopwatch _sw;
	public static void Main()
	{
		_sw = new Stopwatch();
		
		int limit = 999999;
		
		Console.WriteLine("Hello World");
		Console.WriteLine(UseValidationMessageAsErrorMSG(_sw, limit));
		Console.WriteLine(UseValidationMessageAsException(_sw, limit));
		Console.WriteLine(UseValidationMessageAsObject(_sw, limit));
	}
	
	private static long	UseValidationMessageAsErrorMSG(Stopwatch sw, int limit){
		sw.Restart();
		var erroMsg = string.Empty;
		for (var ind = 0; ind < limit; ind++){
			erroMsg = "Error";
		}
		sw.Stop();
		return sw.ElapsedMilliseconds;			
	}
	private static long UseValidationMessageAsException(Stopwatch sw, int limit){
		sw.Restart();
		for (var ind = 0; ind < limit; ind++){
			try { 
				new Exception("Error");
			} catch {}
		}
		sw.Stop();
		return sw.ElapsedMilliseconds;			
	}
	public class ErroObj{
		public string ErroMsg {get;set;}
	} 
	private static long UseValidationMessageAsObject(Stopwatch sw, int limit){
		sw.Restart();
		for (var ind = 0; ind < limit; ind++){
			var error = new ErroObj();
			error.ErroMsg = "Error!";
		}
		sw.Stop();
		return sw.ElapsedMilliseconds;			
	}
}