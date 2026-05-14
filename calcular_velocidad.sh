#!/bin/bash
# Tomando x2=11, x1=5, t2=2, t1=0
v=$(echo "scale=2; (11 - 5) / (2 - 0)" | bc)
echo "$v" > velocidad.txt
echo "Velocidad calculada: $v m/s"
