package system.threading;
import system.NotImplementedException;

class Thread
{

	public function new(fn:Dynamic->Void) 
	{
		throw new NotImplementedException();
	}
	
	public var Name:String;
	public var ManagedThreadId:Int;
	
	public function Start():Void
	{
		throw new NotImplementedException();
	}
	
	public static function Sleep(ms:Int):Void
	{
		Sys.sleep(ms / 1000);
	}
	
	public static var CurrentThread:Thread;
	
}