namespace Singleton
{
    internal class SingletonWithLock
    {
        // Because of the outer if optimisation there is a chancee a thread will receive a partially contructed object,
        // we can solve this by making instance valatile
        private static volatile SingletonWithLock? instance = null; 
        private static readonly object padlock = new object();

        private SingletonWithLock() { }

        public static SingletonWithLock Instance
        {
            get
            {
                var singleton = instance; // We cash instance here because we made it volatile
                if (singleton == null) // This if is so the threads don't wait for the lock when the singleton is already initialized.
                {
                    lock (padlock) 
                    {
                        singleton = instance; // We cash instance here
                        if (singleton == null)
                        {
                            instance = singleton = new SingletonWithLock();
                        }
                    }
                }

                return singleton;
            }
        }
    }
}
