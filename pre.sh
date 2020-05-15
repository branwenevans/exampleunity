#!/bin/bash

#cat ~/.upmconfig.toml
#echo "Hello World" >> ~/.upmconfig.toml
#cat ~/.upmconfig.toml

echo "[npmAuth.'https://nexus3.domain.com/repository/repo/']" >> ~/.upmconfig.toml
echo "token = '$TEST'" >> ~/.upmconfig.toml
echo "email = 'email@domain.com'" >> ~/.upmconfig.toml
echo "alwaysAuth = true" >> ~/.upmconfig.toml