#Concurrency in C# #

First Chapter

* Use Task.Run is for CPU tasks and TaskFactory.StartNew if you want run in a particular scheduler.
* Use `ConfigureAwait` if it does not need to capture the Context. For non desktop and asp.net calls this will be useful.
* Avoid using `Task.Wait` or `Task<T>.Result` rather use await. This could cause dead locks.
* If you use `async` it is best to use `async` all the way.
* In data parallel code chunks of work should be independent from each other for maximizing parallelism.	
* `AggregateException` can be falttened using `Flaten` method.