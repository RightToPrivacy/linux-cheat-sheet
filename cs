FINDING HELP:
-------------

apropos: search for (new) commands by keyword 
	(ex: apropos searchTerm [finds searchTerm related commands])

man: manual pages for each command 
	(ex: man df [read manual for df command])

whatis: prints short description of command
	(ex: whatis ls [prints ls command description])

whereis: prints path of tool/command you want to use
	(ex: whereis man [prints location/dir of man command binary])

--help flag 
	(ex: ls --help [show 'ls' command's common usage/options])


ACCESS CONTROL:
---------------

chmod: change write, read, execute access (w, r, x)
	(ex: chmod +rw /home/user/file.txt 
	[above adds read + write permission to /home/user/file.txt])

passwd: change password
	(ex: passwd [enter new password])

sudo: execute command as root
	(ex sudo ls /root [lists files/directories in /root directory])

su: change to root user shell


FILES/DIRECTORIES & NAVIGATION:
-------------------------------

ls: list files/directories 
	(ex: ls -a [list all files/dir including hidden])

mv: move a file to another location 
	(ex: mv file.txt file2.txt [moves file from name file.txt to file2.txt])

cp: copy file 
	(ex: cp file.txt file2.txt [create copy of file.txt as file2.txt])

cd: change directory 
	(ex: cd /root [move to working inside /root directory])

touch: create new empty file 
	(ex: touch newfile [creates empty file named newfile- helpful for scripting])

pwd: print current/working directory
	(ex: pwd [prints current location])

rm: remove file
	(ex: rm file.txt [deletes file.txt])

rmdir: remove directory
	(ex: rmdir /tmp/temp [deletes /tmp/temp directory])

mkdir: create new directory 
	(ex: mkdir abc123 [creates directory abc123 in current directory])

mvdir: move directory
	(ex: mvdir /tmp/abc123 /tmp/abc111 [move or rename /tmp/abc123 to /tmp/abc111])


OTHER USEFUL COMMANDS/TOOLS:
----------------------------

nano: simple text editor
	(ex: nano file.txt [opens file.txt inside simple nano text editor])

df: show filesystem disk space usage
        (ex: df -h [shows disk usage adding -h option/flag to show in "human readable form" (gb instead of bytes)])

cat: view file text
	(ex: cat /var/log/messages [show contents of /var/log/messages])

more: view file text with scrolling
	(ex: more /var/log/messages [show contents of /var/log/messages using spacebar to scroll page by page, or enter key for line by line])

wc: show count of file- lines, words, byte counts
	(ex: wc /var/log/messages [shows count of lines, words, bytes])

free: show free memory

top: show current running processes

cal: show calendar



INSTALLING USING PACKAGE MAANGER:
---------------------------------

Debian Based (Mint, Debian, Mobian, Parrot)


Finding Packages:

apt search PackageName


Installing Package:

sudo apt install PackageNameHere


Upgrading:

sudo apt update && sudo apt full-upgrade


Removing Packages:

sudo apt remove PackageNameHere


-------------------
END OF CHEATSHEET
-------------------

ADDING NEW COMMANDS TO YOUR CHEAT SHEET:

(edit cs file (if installed /usr/share/cs/cs) to add new commands to your cheat sheet)



(hit q to exit)

(Enter 'cheatsheet' anytime you need to see the commands again)



Originally Posted On RTP's Blog: https://www.buymeacoffee.com/politictech/linux-beginning-cheatsheet-command-picture
