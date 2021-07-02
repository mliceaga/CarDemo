# CarDemo

1- It was a bad design because Engine was class instead of an interface, so V8 inherited from engine instead of implementing the interface, which made V8 class pointless, as Car instantiated internally Engine directly. 
I improved it by turning Engine to an IEngine interface, then passing V8 as a parameter to to ctor of Car so now engine is a dependency that is injected using the IEngine interface, so car could have other kinds of engines.
In the client code from the services V8 is instantiated and passed to the Car ctor. 

For the simple code that was provided it was pretty bad designed. This is a very broad question and could be answered in several ways. We could discuss forward what you mean by "my opinion", but if I have to make a single
statement, I would say that it didn't have Dependency Injection into consideration, nor extension, and didn't follow SOLID patterns.
