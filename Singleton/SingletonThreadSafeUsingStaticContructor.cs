namespace Singleton
{
    internal class SingletonThreadSafeUsingStaticContructor
    {
        private static readonly SingletonThreadSafeUsingStaticContructor instance
            = new SingletonThreadSafeUsingStaticContructor();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonThreadSafeUsingStaticContructor() { }

        private SingletonThreadSafeUsingStaticContructor() { }

        public static SingletonThreadSafeUsingStaticContructor Instance { get { return instance; } }
    }
}

// Why is it thread-safe and how lazy is it?
// Well, static constructors in C# are specified to execute only when an instance of the class is created
// or a static member is referenced, and to execute only once per AppDomain. Given that this check
// for the type being newly constructed needs to be executed whatever else happens,
// it will be faster than adding extra checking as in the previous examples. There are a couple of potential issues:

//1)
// It's not as lazy as the other implementations. In particular, if you have static members other than Instance,
// the first reference to those members will involve creating the instance. This is corrected in the next implementation.

//2)
// There are complications if one static constructor invokes another which invokes the first again.

//3)
// There is a need for a static constructor so the compiler doesn't mark the type as beforefieldinit, 