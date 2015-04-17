# WebApiProjectTemplate Web-Api-Models Project

Contains the service’s REST resource types (or models). We separate these into their own class library just to make unit testing a little easier. But remember that the client/caller never gets this DLL, because resource type definitions are not shared with REST service clients.

(Based on the project structure described and implemented in [ASP.NET Web API 2: Building a REST Service from Start to Finish](http://www.amazon.com/ASP-NET-Web-API-Building-Service/dp/1484201108/ref=sr_1_1?ie=UTF8&qid=1429269153&sr=8-1&keywords=9781484201107) by Jamie Kurtz and Brian Wortman)