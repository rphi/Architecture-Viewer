# Architecture Viewer
Just a very small peice of software for my tiny IT support sideline which reads various bits of system information useful for support, then writes the data to a .txt file to be sent to the support team.

## Features:
* OS version, Arch and Service Pack (if applicable)
* RAM usage/total installed RAM (this seems to be a little off for some unknown reason)
* Export the information to a .txt file

## Todo:
* Freshdesk API integration - automatically add report to ticket if given a valid email address

## Issues:
A rather major issue I hadn't thought of when making this was the fact that it uses .NET, which makes the application somewhat less portable. Also, the API key in the source isn't live (before you even try!)