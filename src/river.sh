#!/bin/bash

JobStartRiverServer () {
    cd river
    dotnet run --project river.csproj
}