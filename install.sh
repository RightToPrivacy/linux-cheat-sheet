#!/bin/bash
#
# run this file as root to install systemwide
#
sudo mkdir /usr/share/cs
cp cs /usr/share/cs

cp cheatsheet /usr/bin/cheatsheet
chmod +x /usr/bin/cheatsheet

sleep 1

echo "Now displaying.."

cheatsheet
