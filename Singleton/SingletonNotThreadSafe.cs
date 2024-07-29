namespace Singleton
{
    internal class SingletonNotThreadSafe
    {
        private static SingletonNotThreadSafe? instance = null;

        private SingletonNotThreadSafe() { }

        public static SingletonNotThreadSafe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonNotThreadSafe();
                }

                return instance;
            }
        }
    }
}
