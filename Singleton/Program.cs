using Singleton;

Console.Title = "Singleton pattern";

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same.");
}

instance1.Log($"Message from {nameof(instance1)}");
instance1.Log($"Message from {nameof(instance2)}");
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

var instance3 = Logger2.Instance;
var instance4 = Logger2.Instance;
if (instance3 == instance4 && instance4 == Logger2.Instance)
{
    Console.WriteLine("Instances are the same.");
}

instance3.Log($"Message from {nameof(instance3)}");
instance4.Log($"Message from {nameof(instance4)}");
Logger2.Instance.Log($"Message from {nameof(Logger2.Instance)}");

Console.ReadLine();