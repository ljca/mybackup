# ACL：更精细的权限控制授予
`setfacl` `getfacl`

`setfacl -R -m u:$USER:rwx dir/file`

`getfacl -b dir/file`
