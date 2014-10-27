 #!/bin/bash          
echo Hello World

tar -cZf /var/my-backup.tgz /home/me/
ls -l > ls-l.txt
rm -f $(find / -name core) &> /dev/null 

######################################################

function quit {
  exit
}  
function e {
  echo $1 
}  
e Hello
e World
quit
echo foo 

######################################################

DBS=`mysql -uroot  -e"show databases"`
for b in $DBS ;
do
        mysql -uroot -e"show tables from $b"
done

######################################################

S1='string'
S2='String'
if [ $S1=$S2 ];
then
        echo "S1('$S1') is not equal to S2('$S2')"
fi
if [ $S1=$S1 ];
then
        echo "S1('$S1') is equal to S1('$S1')"
fi

######################################################