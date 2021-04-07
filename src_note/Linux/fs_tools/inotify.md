<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# inotify: 

`inotifywait` `inotifywatch`

```Bash
/usr/bin/inotifywait -mq -r -e create,modify,move,moved_to,moved_from,delete /media/Others/Document /media/Others/Backup/myback /home/external/sh >> /home/external/var/log/inotify.log
```

