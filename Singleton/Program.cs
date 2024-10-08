﻿using Singleton;

// This implementation of The Singleton patter is not thread safe
var singletonNotThreadSafe = SingletonNotThreadSafe.Instance;

// This implementation uses double lock to implement a thread safe lazy loading Singleton
var singletonThreadSafeWithLock = SingletonWithLock.Instance;

// Implementations without lock that use a static contructor
var singletonThreadSafeUsingStaticConstructorPartialSolution = SingletonUsingStaticContructor.Instance;
var singletonThreadSafeUsingStaticConstructorFullSolution = SingletonUsingStaticContructorBetter.Instance;

// Implemention using Lazy<T>
var singletonThreadSafeUsingLazyT = SingletonUsingLazyT.Instance;


// Singleton is a creational design pattern.
// It ensures that there is only one instance of a class and provides a global point of access to it.