#!/bin/bash

JobStartSebServer () {
    cd seb
    dotnet run --project seb.csproj
}