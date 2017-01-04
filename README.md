# TempoRestClient

| approved versions |
| :---------- |
| Tempo REST API 8.0.0       |


## Installing
The TempoRestClient is is available on NuGet soon

## Using the client
### Basic usage
Creating the TempoRestClient

```c#
var tempoRestClient = TempoRest.Configure("https://jira.url", "username", "password");
```

alternative

```c#
ITempoAccount account = new TempoAccount
{
    ServerUrl = "https://jira.url",
    User = "username",
    Password = "password"
};

var tempoRestClient = TempoRest.Configure(account);
```

Get all Worklogs for a specific user
```c#
IEnumerable<IWorklog> worklogs = TempoRest.Configure(account)
    .FilterUsername("foo.bar")
    .ExecuteWorklogRequest();
```
