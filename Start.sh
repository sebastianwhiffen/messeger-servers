#!/bin/bash
set -m

dotnet run --project ./seb/seb.csproj &
dotnet run --project ./river/river.csproj &

trap "kill 0" SIGINT SIGTERM

wait
