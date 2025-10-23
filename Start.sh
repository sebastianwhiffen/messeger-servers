#!/bin/bash

. ./src/seb.sh
. ./src/river.sh

JobStartSebServer &
JobStartRiverServer &


