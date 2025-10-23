#!/bin/bash

JobStartSebServer () {
    cd seb
    dotnet run --project seb.csproj
}

JobStartRiverServer () {
    cd river
    dotnet run --project river.csproj
}

JobStartSebServer &
JobStartRiverServer &


