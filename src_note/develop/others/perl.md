
`sudo perl -MCPAN -e shell`

cpan[1]> install Acme::Cow 

```log
....................
Running install for module 'Acme::Cow'

Trying with
    /usr/bin/wget -O "/root/.cpan/sources/authors/id/H/HA/HADFL/Acme-Cow-0.2.tar.gz.tmp29522"
to get
    https://cpan.org/authors/id/H/HA/HADFL/Acme-Cow-0.2.tar.gz
--2022-11-22 16:09:36--  https://cpan.org/authors/id/H/HA/HADFL/Acme-Cow-0.2.tar.gz
已载入 CA 证书“/etc/ssl/certs/ca-certificates.crt”
正在解析主机 cpan.org (cpan.org)... 151.101.65.55, 151.101.1.55, 151.101.193.55, ...
正在连接 cpan.org (cpan.org)|151.101.65.55|:443... 已连接。
已发出 HTTP 请求，正在等待回应... 200 OK
长度：22060 (22K) [application/x-gzip]
正在保存至: “/root/.cpan/sources/authors/id/H/HA/HADFL/Acme-Cow-0.2.tar.gz.tmp29522”

/root/.cpan/sources/authors/id/H/HA/HADFL/Acme- 100%[======================================================================================================>]  21.54K  --.-KB/s  用时 0.04s   

2022-11-22 16:09:38 (539 KB/s) - 已保存 “/root/.cpan/sources/authors/id/H/HA/HADFL/Acme-Cow-0.2.tar.gz.tmp29522” [22060/22060])
..............................................
  /usr/bin/make install  -- OK
  HADFL/Acme-Cow-0.2.tar.gz
  Has already been unwrapped into directory /root/.cpan/build/Acme-Cow-0.2-0
  HADFL/Acme-Cow-0.2.tar.gz
  Has already been prepared
Running make for H/HA/HADFL/Acme-Cow-0.2.tar.gz
cp Cow/Example.pm blib/lib/Acme/Cow/Example.pm
cp Cow/Frogs.pm blib/lib/Acme/Cow/Frogs.pm
cp Cow/TuxStab.pm blib/lib/Acme/Cow/TuxStab.pm
cp Cow/Stegosaurus.pm blib/lib/Acme/Cow/Stegosaurus.pm
cp Cow/TextBalloon.pm blib/lib/Acme/Cow/TextBalloon.pm
cp Cow/DragonAndCow.pm blib/lib/Acme/Cow/DragonAndCow.pm
cp Cow/MechAndCow.pm blib/lib/Acme/Cow/MechAndCow.pm
cp Cow.pm blib/lib/Acme/Cow.pm
cp cowpm blib/script/cowpm
"/usr/bin/perl" -MExtUtils::MY -e 'MY->fixin(shift)' -- blib/script/cowpm
cp cowsay blib/script/cowsay
"/usr/bin/perl" -MExtUtils::MY -e 'MY->fixin(shift)' -- blib/script/cowsay
cp cowthink blib/script/cowthink
"/usr/bin/perl" -MExtUtils::MY -e 'MY->fixin(shift)' -- blib/script/cowthink
Manifying 3 pod documents
Manifying 3 pod documents
  HADFL/Acme-Cow-0.2.tar.gz
  /usr/bin/make -- OK
The current configuration of allow_installing_outdated_dists is 'ask/no', but for this option we would need 'CPAN::DistnameInfo' installed. Please install 'CPAN::DistnameInfo' as soon as possible. As long as we are not equipped with 'CPAN::DistnameInfo' this option does not take effect
Running make test for HADFL/Acme-Cow-0.2.tar.gz
PERL_DL_NONLAZY=1 "/usr/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
t/balloon.t .. ok     
t/cow.t ...... ok     
t/file.t ..... ok     
t/pm.t ....... ok     
All tests successful.
Files=4, Tests=73,  0 wallclock secs ( 0.04 usr  0.01 sys +  0.12 cusr  0.03 csys =  0.20 CPU)
Result: PASS
  HADFL/Acme-Cow-0.2.tar.gz
  /usr/bin/make test -- OK
Running make install for HADFL/Acme-Cow-0.2.tar.gz
Manifying 3 pod documents
Manifying 3 pod documents
Installing /usr/share/perl5/site_perl/Acme/Cow.pm
Installing /usr/share/perl5/site_perl/Acme/Cow/Stegosaurus.pm
Installing /usr/share/perl5/site_perl/Acme/Cow/Frogs.pm
Installing /usr/share/perl5/site_perl/Acme/Cow/MechAndCow.pm
Installing /usr/share/perl5/site_perl/Acme/Cow/TextBalloon.pm
Installing /usr/share/perl5/site_perl/Acme/Cow/TuxStab.pm
Installing /usr/share/perl5/site_perl/Acme/Cow/DragonAndCow.pm
Installing /usr/share/perl5/site_perl/Acme/Cow/Example.pm
Installing /usr/share/man/man1/cowthink.1p
Installing /usr/share/man/man1/cowsay.1p
Installing /usr/share/man/man1/cowpm.1p
Installing /usr/share/man/man3/Acme::Cow::Example.3pm
Installing /usr/share/man/man3/Acme::Cow.3pm
Installing /usr/share/man/man3/Acme::Cow::TextBalloon.3pm
Installing /usr/bin/site_perl/cowsay
Installing /usr/bin/site_perl/cowthink
Installing /usr/bin/site_perl/cowpm
Appending installation info to /usr/lib/perl5/5.36/core_perl/perllocal.pod
  HADFL/Acme-Cow-0.2.tar.gz
  /usr/bin/make install  -- OK
```

> 参考：

- [Perl模块管理](https://blog.csdn.net/weixin_30950887/article/details/98601713)
- [Perl 常用MODULE的使用](https://www.cnblogs.com/xiaowant/archive/2011/09/08/2171679.html)

