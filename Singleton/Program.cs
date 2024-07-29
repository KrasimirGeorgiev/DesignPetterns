using Singleton;

// This implementation of The Singleton patter is not thread safe
var singletonNotThreadSafe = SingletonNotThreadSafe.Instance;

// This implementation uses double lock to implement a thread safe lazy loading Singleton
var singletonThreadSafeWithLock = SingletonThreadSafeWithLock.Instance;

// Implementations without lock that use a static contructor
var singletonThreadSafeUsingStaticConstructorPartialSolution = SingletonThreadSafeUsingStaticContructor.Instance;
var singletonThreadSafeUsingStaticConstructorFullSolution = SingletonThreadSafeUsingStaticContructorBetter.Instance;

// 