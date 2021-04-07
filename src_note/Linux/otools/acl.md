<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# ACL：更精细的权限控制授予。 核心工具是: `setfacl` `getfacl`

`setfacl -m u:$USER:rwx dir/file`

`getfacl -b dir/file`
