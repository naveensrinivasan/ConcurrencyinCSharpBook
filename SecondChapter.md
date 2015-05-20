#Concurrency in C# #

##Second Chapter##

* `Task.Delay` could be used for Retries and for unit testing and as well as for
 `Task.Delay` could be used for Timeout of async requests.
* Don't block `async` methods. It could cause dead locks.
* Use `IProgress<T>` and `Progress<T>` to report progress of async methods.
* Use `Task.WhenAll` when waiting for multiple async methods to complete and `Task.WhenAny` for any of the tasks to complete.
* Processing `Task` as they complete can be achieved by having a higher level function that is awaiting the task and processing the result. If not use AsyncEx library and use extension method `OrderByCompletion`
