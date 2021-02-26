# NavigateAround
This repository shows an implementation of a page which accepts a parameter and validates it. When it is valid, the page will show the content, otherwise the user will be redirected with an error message.


The current state has two major issues:
1. The AlertService is shared between all users. If two people creates an alert at the same time, only one will see both alerts and the other won't see any.
2. Because of RenderMode ServerPrerender, OnParameterSetAsync() is called twice when you open the page in a new tab or visiting the page directly via URL. Thsi results in the alerts being collected twice where the second call returns an empty list.


![](images/Process.png)
