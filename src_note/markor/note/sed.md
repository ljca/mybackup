<link href="../css/style.css" rel="stylesheet" type="text/css" />

# sed 笔记

<!--

<details markdown='1'>
<summary>展开/收起
</summary>

```bash

sed -i 's|&nbsp；|\&nbsp;|g' 1.md
sed -i-bk "s|,|，|g;s|?|？|g;s|:|：|g;s|;|；|g;s|\!|！|g;s|x|、|g" 9.md 
sed -i "41,165{s|$|<br \/>|;}" "周末选读 │ 周兴嗣：千字文.md" 
sed -i -e "50s| $|\n|" songs.md   
for d in $(for i in *.md;do wc -l "$i"|grep 2|cut -d" " -f2-|xargs;done);do sed -i-bk 2i'\n<link href="../../../style.css" rel="stylesheet" type="text/css" />\n' "$d";done
for d in $(for i in *.md;do wc -l "$i"|grep "^4 "|cut -d" " -f2-|xargs;done);do sed -i 3i'<link href="../../../style.css" rel="stylesheet" type="text/css" />\n' "$d";done
for i in *;do [ -d "$i" ] && { pushd "$i";for d in *.txt;do cp -v "$d" "${d%%.*}.md";done;popd; };done
for i in *;do [ -d "$i" ] && { pushd "$i";for d in *.md;do sed -i -e "1s|^|## |" -e 3i'<link href="../../style.css" rel="stylesheet" type="text/css" />\n' "$d";done;popd; };done
for i in *;do [ -d "$i" ] && { pushd "$i";for d in *.md;do sed -i -e "s|^    ||" "$d";done;popd; };done
for i in *.md;do sed -i -e "1s|^|## |" -e "s|^    ||" -e 3i'<link href="../../style.css" rel="stylesheet" type="text/css" />\n' "$i";done
for i in *.md;do  sed -i "/^#/{s|</br>$||;x;p;x;G;}" "$i";done
for i in 超译尼采 ——尼采;do pushd "$i";for i in *.md;do sed -i "s|../||";done;popd;done
for i in 超译尼采 ——尼采;do pushd "$i";for d in *.md;do sed -i "s|../||" "$d";done;popd;done
for i in *.md;do sed -i-bk -e "/^###/i------------------" -e "/^###/{x;p;x;}" "$i";done
for i in *.md;do sed -i -e "/^###/i------------------" -e "/^###/{x;p;x;}" "$i";done
for i in *.md;do sed -i -e "/^$/d;G" "$i";done
for i in {1..10}.md;do sed -i -e "4,5d;" "$i";done
for i in {1..14}.md;do touch "$i";sleep 2;done
for i in 诗经 九歌;do pushd "$i";for d in *.md;do sed -i "s|\.\./\.\./style\.css|../../../style.css|" "$d";done;popd;done
for i in {1..14}.md;do touch "$i";sleep 2;done
for i in 诗经 九歌;do pushd "$i";for d in *.md;do sed -i "s|\.\./\.\./style\.css|../../../style.css|" "$d";done;popd;done
for i in {1..114}.md;do sed -i-bk -e "1s|^|### |" -e '1i<link href="../../../style.css" rel="stylesheet" type="text/css" />' -e '3i<audio src=".mp3/$i.mp3" controls></audio>' -e "/^$/d;G" "$i";done
for i in {1..114}.md;do sed -i-bk -e "4d" -e "3i<audio src=\".mp3/$(echo $i|sed 's|\.md|.mp3|')\" controls></audio>\n" -e "/^$/d;G" "$i";done
for d in *.md;do sed -i "s|\.\./\.\./\.\./style\.css|../style.css|" "$d";done
sed -i '155,166{s/\[//g;s/\]//g;s|(| <li><a href="|g;s|)|"></a></li>|g;}' 叔本华心灵咒语/1.md 
sed -i '155,166{s/\[//g;s/\]//g;s|(| <li><a href="../|g;s|)|"></a></li>|g;}' 叔本华心灵咒语/1.md 
sed -i "7,122{s|^|+ [|;s|$|](http://www.yslxx.com/gljzw/003.htm)|;}" "index.md"
for i in {1..9}.md;do sed -i -e "5i<audio src=\"http://106.54.60.203/13.hanyuban/00$(echo $i|sed 's|\.md|.mp3\n|')\" controls></audio>\n" "$i";done
for i in {10..99}.md;do sed -i -e "5i<audio src=\"http://106.54.60.203/13.hanyuban/0$(echo $i|sed 's|\.md|.mp3\n|')\" controls></audio>" "$i";done
for i in {100..114}.md;do sed -i -e "5i<audio src=\"http://106.54.60.203/13.hanyuban/$(echo $i|sed 's|\.md|.mp3|')\" controls></audio>" "$i";done
for i in {1..114}.md;do sed -i "s| ,|，|g;s|,|，|g" "$i";done
sed "152,166s|^\*\*|第一|" 0.md 
sed -i "152,166s|^\*\*|第一|" 0.md 
sed -i "50,151s|^\*|第|" 0.md 
sed -i "3,166{s|^|+ [|;s|$|](1.md)|;}" "0.md"
for i in {1..114}.md;do sed -i "/^$/d;s|$|<br />|" "$i";done
for i in {1..114}.md;do sed -i -e "1s|<br />$||;2s|<br />$||;3s|<br />$||;" -e "2,3{x;p;x;G;}" "$i";done
for i in {1..114}.md;do sed -i -e '1i<style>\nbody{background-color: #ffffcb;}\n</style>\n' $i";done
for i in {1..114}.md;do sed -i -e '1i<style>\nbody{background-color: #ffffcb;}\n</style>\n' "$i";done
for i in {1..114}.md;do sed -i -e "2d;5,6d" -e "s| ;|；|g;s| ?|？|g" -e '2ibody{\nline-height: 2em;\nbackground-color: #ffffcb;\n}' "$i";done
for i in {1..114}.md;do sed -i '2ibody{\nh1,h2,h3,h4,h5,h6: center;\nline-height: 2em;\nbackground-color: #ffffcb;\n}' "$i";done
for i in {1..114}.md;do sed -i "3d" "$i";sed -i "2ih1,h2,h3,h4,h5,h6{\ntext-align: center;\n}" "$i";done
for i in $(find . -type f -name "*.md"|sed "s/^\.\///"|xargs);do echo "+ [$(basename -s .md $i)]($i)\n";done|less
for i in $(find . -type f -name "*.md"|sed "s/^\.\///"|xargs);do echo -e "+ [$(basename -s .md $i)]($i)";done|less
for i in $(find . -type f -name "*.md"|xargs);do echo -e "+ [${i##*/})]($i)";done|less
for i in *;do pushd "$i";rename -v " · " "·" *.md;rename -v " _ " "" *.md;popd;done
for i in *;do [ -d "$i" ] && { pushd "$i";rename -v " · " "·" *.md;rename -v " _ " "" *.md;popd;};done
for i in $(find 古文观止 -name "*.md"|xargs);do echo -e "+ [$(basename -s .md $i)]($i)";done|tee -a 古文观止.md 
find . -type f -name "*.md" -exec sed -i "s|font-awesome\.min\.css|css/font-awesome.min.css|;s|style\.css|css/style.css|" '{}' ";"
grep "周末选读" -r . |cut -d: -f1|xargs -I{} mv {} tmp
for i in $(find 节选/文摘与小说 -name "*.md"|xargs);do echo -e "+ [$(basename -s .md $i)]($i)";done|tee -a 节选.md 
sed -e "/^$/d;" -e "/^/i<div class=\"pontry\">" -e '/^【大义】/{s/<div class="pontry">//;}' -e 's|^【大义】|<span class="comment">&|' -e "/^【大义】/a</span>" 增广贤文.md|sed '$!N;/<span/!P;D'|less
sed -e "/^$/d;" -e "/^/i<div class=\"pontry\">" -e '/^【大义】/{s/<div class="pontry">//;}' -e 's|^【大义】|<span class="comment">&|' -e "/^【大义】/a</span>" 增广贤文.md|less
sed -i -e "20,672s/^/<div class=\"pontry\">/" -e '/【大义】/ {s/<div class="pontry">/<span class="comment">\n/;s|$|\n</span>\n|;}'  增广贤文.md
sed -e "25,679s/^/<div class=\"pontry\">/" -e '/【大义】/ {s/<div class="pontry">/\n\n<div class="translation">\n/;s|$|\n\n</div>\n|;}'  增广贤文.md
sed -i -e "25,679s/^/<div class=\"pontry\">/" -e '/【大义】/ {s/<div class="pontry">/\n<div class="translation">\n\n/;s|$|\n\n</div>\n|;}'  增广贤文.md
sed -i '/<div class="translation">/ i\</div>\n' 增广贤文.md 
sed -i -E 's/(<div class="pontry">)/\1\n\n/' 增广贤文.md
sed -i 's/^$/\n<\/div>\n/' "朱子家训·全文.md"
sed -i 's/<div class="translation">/\n\n&\n\n/' "朱子家训·全文.md"
for i in *.md;do sed -i 's|。|&\n<span class="comment">\n|' "$i";done
for i in *.md;do sed -i 's|：|&\n<span class="comment">\n|' "$i";done
for i in *.md;do sed -i '2s|\n<span class="comment">\n||' "$i";done
for i in *.md;do sed -i '4i\\n<div class="poetry">\n\n' "$i";done
for i in *.md;do sed -i 's|$|  |' "$i";done
for i in *.md;do sed -i 's|  $|<br />|' "$i";done
sed -i -Ee "s/^(导读)/\f\n\n第0章 \1\n\n/" 瓦尔登湖.txt
sed -i -Ee "s/^(生计)(3)/\f\n\n第3章 \1(\2)\n\n/" 瓦尔登湖.txt
sed -i 's/\.\.\.\.\.\./……/g;s/,/，/g;s/\./。/g;s/?/？/g;s/:/：/g' 水问.md 
sed -i 's/\!/！/g;s/;/；/g;s/,/，/g;s/?/？/g;s/:/：/g' 庾信：哀江南赋序.md
wc (< history |tail -n1)
for i in 古风 The_1990s Pop;do pushd "$i"; file *.lrc|grep -iE "iso"|cut -d: -f-1|xargs -I{} mv -v '{}' ../tmplrc;popd;done
for i in tmp/*.lrc;do iconv -f cp936 -t utf-8 --verbose "$i" -o "$(basename -s .lrc $i).lrc";done
for i in 古风 The_1990s Pop Musiclrc/tmp;do pushd "$i";sed -s -i '/^\[language/d' *.lrc;popd;done
for d in Pop 古风 The_1990s;do pushd "$d" && { md tmp;mv *.lrc tmp;} && { for i in *.mp3;do  if [ -f "tmp/${i%*.}.lrc" ];then mv -bv "tmp/${i%*.}.lrc .";fi;done;};popd;done
for d in Pop 古风 The_1990s;do pushd "$d" && for i in *.mp3;do  if [ -f "tmp/${i%*.}.lrc" ];then mv -bv "tmp/${i%*.}.lrc .";fi;done;popd;done
for d in Pop 古风 The_1990s;do pushd "$d" && for i in *.mp3;do  if [ -f "tmp/${i%*.}.lrc" ];then mv -bv "tmp/${i%*.}.lrc" .;fi;done;popd;done
for d in Pop 古风 The_1990s;do pushd "$d" && for i in *.mp3;do [ -f "tmp/${i%.*}.lrc" ] && mv -bv "tmp/${i%.*}.lrc" .;done;popd;done
for d in Pop The_1990s 古风;do pushd "$d/tmp";for i in *.lrc;do mv -bv "$i" "${i##*-}";done;rename -v " " "" *.lrc;popd;done
for d in Pop 古风 The_1990s;do pushd "$d" && for i in *.mp3;do [ -f "tmp/${i%.*}.lrc" ] && echo n|mv -iv "tmp/${i%.*}.lrc" .;done;popd;done
for d in Pop 古风 The_1990s;do pushd "$d/tmp";sed -s -i '/\[id:/d' *.lrc done;popd;done
for d in Pop 古风 The_1990s;do pushd "$d/tmp";sed -s -i '/\[id:/d' *.lrc;done;popd;done
for d in Pop 古风 The_1990s;do pushd "$d" && for i in *.mp3;do [ -f "tmp/${i%.*}.lrc" ] && mv -bv "tmp/${i%.*}.lrc" . ; mv -v "${i%.*}.lrc~" "${i%.*}.lrc" ;done;popd;done
for d in 19 20;do pushd "$d"; for i in *.md;do sed -i -Ee 's/^    //' -e '1i\<link href="../../css/style.css" rel="stylesheet" type="text/css" />' -e '^$/d;G' "$i";done;popd;done
for d in 19 20;do pushd "$d"; for i in *.md;do sed -i -Ee 's/^    //' -e '1i\<link href="../../css/style.css" rel="stylesheet" type="text/css" />' -e '/^$/d;G' "$i";done;popd;done
for d in 19 20;do pushd "$d"; for i in *.md;do sed '/^$/d;G' "$i";done;popd;done
for d in 19 20;do pushd "$d"; for i in *.md;do sed -i '/^$/d;G' "$i";done;popd;done
for i in *.md;do sed -i '3s/，/日，/' "$i";done
for i in *.md;do sed -i '3s/日日，/日，/' "$i";done
sed -i '/^## /{s/^## /<h2>/;s/$/<\/h2>/;}' -e '/^#/ s/^### /## /;s/^#### /### /' *.md
sed -i -e '/^## /{s/^## /<h2>/;s/$/<\/h2>/;}' -e '/^#/ s/^### /## /;s/^#### /### /' *.md
sed -i -Ee '23,28s/(\+ )\[(.*)／(.*)\]/\1[\3：\2]/' -e '23,28s/(\(.*\/.*\/)(.*)／(.*)(\.md\))/\1\3：\2\4/' 文选.md 
for i in *.md;do mv "$i" "$(echo $i|sed -Ee 's/(.*)／(.*)(\.md)/\2：\1\3/')";done
for i in *.md;do sed -i -Ee '1s/(### )(.*)／(.*)/\1\3：\2/' "$i";done
for i in *.md;do sed -i -Ee '1s/(#* )(.*)／(.*)/\1\3：\2/' "$i";done
history |grep sed|sed 's/^ *[0-9]* *//'|sort|uniq|tee -a sed.md 
history |grep sed|sed -Ee '/^ *[0-9]* */{s//+ \`/;s/$/\`\n/;}'|sort|uniq|tee -a note/note/sed.md 
history |grep sed|sed 's/^ *[0-9]* *//'|sort|uniq|tee -a note/note/sed.md 
pip install https://github.com/joh/when-changed/archive/master.zip
file *.lrc|grep -iE utf-16|cut -d: -f-1 |xargs -I{} iconv -c -futf-16 -tutf-8 '{}' -o '{}'
file *.lrc|grep -iE bom|cut -d: -f-1 |xargs -I{} sed -i 's/^\xef\xbb\xbf//' '{}'
file *.lrc|grep -iE bom|cut -d: -f-1 |xargs -I{} dos2unix '{}'
file *.lrc|grep -iE crlf|cut -d: -f-1 |xargs -I{} sed -iE -e 's/\r\n$/\n/' '{}'
file *.lrc|grep -iE crlf|cut -d: -f-1 |xargs -I{} sed -E -e 's/.$//' '{}'
file *.lrc|grep -iE crlf|cut -d: -f-1 |xargs -I{} sed -iE -e 's/.$//' '{}'
sed -i -Ee '24,$/[a-zA-Z]+/ s// & /g' 简历.md
sed -i -Ee '24,$s/[a-zA-Z]+/ & /g' 简历.md
sed -i -Ee 's/^##.*/\n<\/div>\n\n&\n\n<div class="p">/' 老天有眼，也会看脸.md
sed -i -Ee 's/^##.*/\n<\/div>\n\n&\n\n<div class="p">/' 学会珍惜一个人的孤独.md 你所有的努⼒，只为遇见更美好的⾃⼰.md 效率极低人群之七大习惯.md 为什么思考人生会像一句笑话.md 自由撰稿人是如何炼成的.md 资深自由撰稿人的经验.md 巴金：狗.md ../世间纷扰，安得静好.md 我与地坛.md “忘了”与“别忘了”.md 
sed -i -Ee '/^—— / s///' *.md
s -i 's/<a.*(http.*\.htm).*>(.*)<\/a>/+ [\2](\1)/' tmp
s -i 's:<td>|<tr>|<strong>|</tr>|</td>|</strong>::g' tmp
s -i 's/<\/li>/\n\n/g;s/<i>|<\/i>//g' tmp
s -i 's/<li.*_01">//;s/<a href="(.*\.html)".*title.*">(.*)<.a>/+ [\2](https:\/\/m.fox2008.cn\1)/' tmp
s -i 's/<dd>/\n\n/g;s/<\/dd>//g' tmp
s -i 's/<a.*"(.*\.html)">(.*)<.*a>/+ [\2](http:\/\/m.99csw.com\1)/' tmp
s -i '/^$/d' tmp 
s -i 's/<li><a.*(https:.*)"> (.*)<.*a.*li>/+ [\2](\1)/' t
s '156,${s/https.*/#)/;}' 我与地坛.md 
sed -i -Ee 's/^###.*/\n<\/div>\n\n&\n\n<div class="p">/' {2..12}.md
sed -i -Ee 's/^###.*/\n<\/div>\n\n&\n\n<div class="p">/' {1..10}.md
s -i '/<div class="p">/d' {1..14}.md
s -i 's/<\/br>/<br \/>/' {1..14}.md
sed -i -Ee '45,${s/^###.*/\n<\/div>\n\n&\n\n<div class="p">/;}' ——尼采.md 
for i in *.ape;do mv "$i" "$(echo $i|sed -Ee 's/[()]//g')";done 
for i in *;do swap_a_n "$i";done 
for i in *.lrc *.mp3;do swap_a_n "$i";done 
mv $(c ../短篇小说.md|sed -Ee '1d;/^--/d;/^>/d' -e 's/^\+ //;s/\[.*\]//;' -e 's/\(.*\/(.*\.md)\)/\1/;'|xargs) 短篇小说/
mv $(c ../周末选读.md|sed -Ee '1d;/^--/d;/^>/d' -e 's/^\+ //;s/\[.*\]//;' -e 's/\(.*\/(.*\.md)\)/\1/;'|xargs) 周末选读/
s -i 's/^(<link href.*)(\.\.\/)/\1..\/\2/' *.md
for d in *;do [ -d "$d" ] && { pushd "$d";s -i -e 's/^(<link href.*)\.\.\/\.\.\/\.\.\/\.\.\//\1..\/..\/..\//' *.md;popd; };done
s -i '/^\+ / s/文摘与小说\///' *.md
s -i '/^\+ / s/\((.*\.md)\)/(周末选读\/\1)/' 周末选读.md 
s -i '/^\+ / s/\((.*\.md)\)/(短篇小说\/\1)/' 短篇小说.md 
for d in 我与地坛 简媜散文 梁实秋散文集;do [ -d "$d" ] && { pushd "$d";s -i -e 's/^(<link href.*)\.\.\/\.\.\/\.\.\/\.\.\//\1..\/..\/..\//' *.md;popd; };done
s -i 's/<li><a.*href="(http.*html)">(.*)<\/a>/+ [\2](\1)/' tmp 
s -i -e '/<link>/ s/poetry\.css/style.css/;' -e 's/<center>//' *.md
s -i '/<tr.*>/d;/<\/tr>/d;s/<td>|<td.*"25%">|<\/td>//' tmp 
s -i 's/<a.*="(.*\.html)">(.*)<\/a>/+ [\2](https:\/\/www.kanunu8.com\/book\/4109\/\1)/' tmp|tee -a 我的不完美.md
s -i '/<tr.*>/d;/<\/tr>/d;s/<td>|<td.*".*%">|<\/td>//' tmp 
s -i 's/<a.*="(.*\.html)">(.*)<\/a>/+ [\2](https:\/\/www.kanunu8.com\/book\/4109\/\1)/' tmp
s -i '/2019年.*。$/ s/。$//' *.md
s -i '/2019年.*$/ s/$/。/' *.md
sed -i -Ee 's/^##.*/\n<\/div>\n\n&\n\n<div class="poetry">/' {1..4}.md {11.16}.md
sed -i -Ee 's/^##.*/\n<\/div>\n\n&\n\n<div class="poetry">/' {11.16}.md
sed -i -Ee 's/^##.*/\n<\/div>\n\n&\n\n<div class="poetry">/' {11..16}.md
s -i '/^[1-9]\./ s/^[1-9]\./### &/' *.md
s -i '114s/［[1-9]*］/\n\n&/g' 原道.md
s -i '/ --  -- / s// —— /g' 为什么思考人生会像一句笑话.md
s -i 's/\{/&\n/g;s/\}/\n&\n/g' *.css
s -i '/\}/G' *.css
s -i -e '/^#/{x;p;x;G;}' -e '/<\/div>/{x;p;x;G;}' -e '/<div .*>/{x;p;x;G;}' 1.md 
s -i '/<bk \/>$/ s/bk/br/' 1.md 
s -i '/^--*/{x;p;x;G;}' 1.md 
sed -i '/^$/{N;/^\n*$/D}' 1.md 
for d in Pop 古风 The_1990s;do pushd "$d/tmp";sed -s -i '/\[id:/d' *.lrc;done;popd;done
sed -i '/^$/{N;/^\n*$/D}' *.md
s -i -f s $(search "<bk />"|cut -d: -f-1|uniq|xargs)
s -i -e '/^<\/div>|<div.*>|^#/ s/<br \/>//' -e '/^<br \/>$/ s///' 5.md 
s -i -e '/^\+ /{n;/^$/d;}' -e '/^##*.*/ s//\n<\/div>\n\n&\n\n<div class="p">\n/' 31.md 34.md 35.md 
s -i '/<br \/>$/ s//<bk \/>\n/' 8.md 
s -i '/^#* [0-9]*\./ s/### //;/^#* $/d' 40.md 
s -i '/^[1-9]*\./{n;/^$/d;} 40.md 
s -i '/^[1-9]*\./{n;/^$/d;}' 40.md 
s -i '/^[0-9]*\..*<br \/>$/ s/<br \/>//' 40.md 
s -i '/^[0-9]*\..*/G' 40.md 
s -i '3s/^<span class="fzzy">//' {19..21}/*.md
s -i '3s/^/<span class="fzzy">/' {19..21}/*.md
s -i '/^#* |^> /{x;p;x;G}' 人生轨迹.md 
s -s '3s/(2019年.*[0-9]*日，)(周.*，)(.*)，([0-9]*.*℃)。/\1\2\4，\3。/' *.md
s -i '3s/(2019年.*[0-9]*日，)(周.*，)(.*)，([0-9]*.*℃)。/\1\2\4，\3。/' *.md
s -i '3s/([1-9]*\.[1-9]*，)(周.*，)(.*)，([0-9]*.*℃)。/\1\2\4，\3。/' *.md
s -i '3s/([1-9]*月.*[0-9]*日，)星期(.*，)(.*)，([0-9]*.*℃)。/\1周\2\4，\3。/' *.md
s -i '3s/(1)(月)([1-9]*)(日)/\1 \2 \3 \4/' 1.*.md
s -i '3s/(2019)(年)([0-9]*)(月)([0-9]*)(日)/\1 \2 \3 \4 \5 \6/' *.md
s -i 's/0/零/g;s/1/一/g;s/2/二/g;s/3/三/g;s/4/四/;s/5/五/g;s/6/六/g;s/7/七/g;s/8/八/g;s/9/九/g;' 之人生.md 
for i in *.md;do mv "$i" "$(echo $i|sed 's/月/./;s/日//;')";done
s -i '3s/ 月 /./;s/ 日//' *.md
s -i '/^## / s//# /' *.md
for d in *;do [ -d "$d" ] && pushd "$d";s -i '/^## / s//# /;/^### / s//## /;/^#### / s//### /' *.md;popd;done
s -i '/^## |^<h2>/ s//# /;/^### / s//## /;/^#### / s//### /' {2..52}.md
for i in *.md; do mv "$i" "$(echo $i|s 's/^.*：//')"
for i in *.md; do mv "$i" "$(echo $i|s 's/^.*：//')";done
s '/^# (.*：)/{G;h;s///;G;}' 余光中：乡愁.md 
s -i '/(^# )(.*)：(.*)/ s//\1\3\n\n<span class="r">\2/' *.md
for d in *;do [ -d "$d" ] && pushd "$d";s -i '/(^# )(.*)：(.*)/ s//\1\3\n\n<span class="r">\2/' *.md;popd;done
for d in *;do [ -d "$d" ] && pushd "$d";for i in *.md; do mv "$i" "$(echo $i|s 's/^.*：//')";done;popd;done
s -i '/(^# )(.*)：(.*)/ s//\1\3\n\n<span class="r">\2/' *.md
for d in *;do mv "$i" "$(echo $i|s 's/^.*：//')";done
for i in *;do mv "$i" "$(echo $i|s 's/^.*：//')";done
s -i '/^\+ / s/\((.*\/)(.*\/).*：(.*\.md)\)/(\1\2\3)/' pontries.md 
s -i '/^\+ / s/\((.*\/).*：(.*\/)(.*\.md)\)/(\1\2\3)/' pontries.md 
s -i '/^\+ / s/\[.*：(.*)\]/[\1]/' pontries.md 
for d in *;do [ -d "$d" ] && pushd "$d";for i in *.md; do mv "$i" "$(echo $i|s 's/^.*：//')";done;popd;done
s -i '/^\+ / s/\((.*\/)(.*\/).*：(.*\.md)\)/(\1\2\3)/' 古文观止.md 
s -i 's/<td.*><a.*href=.*"([0-9]*.*\.html)">(.*)<\/a.*>/+ [\2](https:\/\/www.kanunu8.com\/book3\/7601\/\1)/' tmp 
s -i  '/[0-9]{4}\.[0-9]{1}/ s//\n\n<span class="r">&/' 1.md
s -i '/^## $/ s//<\/div>\n\n<div class="poetry">/' 3.md 
s -i '/<div class="poetry">|<\/div>/d' 3.md 
s -i '/<div class="poetry">/d;s/<\/div>/## /' 3.md 
s -i '/^##*/ s//<\/div>\n\n# \n&<div class="poetry">/' 3.md 
s -i '/^##*/ s//<\/div>\n\n# \n\n&<div class="poetry">/' 3.md 
s -i '/^##*.*/ s//<\/div>\n\n# \n\n&<div class="poetry">/' 3.md 
s -i '/^##*.*/ s//<\/div>\n\n# \n\n&\n\n<div class="poetry">/' 3.md 
s -i '/^## $/ s//&<\/br>' 3.md 
s -i '/^## $/ s//&<\/br>/' 3.md 
s -i '/^[1-9]{4}$/ s//\n\n<span class="r">&/' 3.md 
s -i '/^[1-9]{4}<br \/>$/ s//\n\n<span class="r">&/' 3.md 
s -i '/^[1-9]{4}<br \/>$/ s//\n<span class="r">&/' 3.md 
s -i '/^#* [0-9]*\.$/ s/\.//' 3.md 
s '/^##*.*/ s//<\/div>\n\n# \n\n&\n\n<div class="poetry">/' 
s '/^##*.*/ s//<\/div>\n\n&\n\n<div class="poetry">/' 4.md |less
s -i -e '/<div class="poetry">|<\/div>/d' -e '/^----/ s//## <br \/>/;' -e '/^##*.*/ s//<\/div>\n\n&\n\n<div class="poetry">/' -e '/^[1-9]{4}<br \/>$/ s//\n<span class="r">&/' -e '/^#* [0-9]*\.$/ s/\.//' 4.md {11..16}.md
s -i '/^<span class="r">.*/ s//&\n\n<\/div>\n\n<div class="poetry">\n\n/' 4.md {11..16}.md
s -i '/^<span class="r">.*/ s//&\n\n<\/div>\n\n## <br \/>\n\n<div class="poetry">\n\n/' 4.md {11..16}.md
s -i -e !212:2 -e '/^##*.*/ s//<\/div>\n\n&\n\n<div class="poetry">/' 4.md {11..16}.md
s -i -e '/<div class="poetry">|<\/div>/d' -e '/^##*.*/ s//<\/div>\n\n&\n\n<div class="poetry">/' 4.md {11..16}.md
s  '/^<div class="poetry">$/{N;N;/^<\/div>$/D}' 13.md |less
s -i '/^<span class="r">.*<br \/>/ s/<br \/>/<\/span>/' {1..4}.md {11..16}.md
s -i 's/<li.*><a.*(https.*\.html).*><span.*>(.*)<\/span.*/+ [\2](\1)/' t
s -i '/^<li / s/<li.*>(.*)<\/li>/> \1\n/' t
s -i 's/\{/&\n\n/;s/\}/\n\n&/' style-65f8b8f0dd.css catalog-63e904dc10.css 
s -i 's/\{/&\n\n/g;s/\}/\n\n&/g' style-65f8b8f0dd.css catalog-63e904dc10.css 
s -i 's/\;/&\n\n/g;s/\}/\n\n&/g' style-65f8b8f0dd.css catalog-63e904dc10.css 
s -i 's/\;/&\n\n/g;s/\}/\n\n&\n\n/g' style-65f8b8f0dd.css catalog-63e904dc10.css 
s -i -e '/\{/{x;p;x;}' -e '/\}/G' *.css
s -i -e '/^$/d' -e '/\{/{x;p;x;}' -e '/\}/G' *.css
s -i  '/(^<span class="fzzy">)([0-9]*\.[0-9]*，)/ s//\12019.\2/' *.md
s -i  '/(^<span class="fzzy">)2019\.([0-9]*\.[0-9]*，)/ s//\119.\2/' *.md|less
s -i '/^\+ / s/\(https.*\)/(http\:\/\/m.99csw.com\/book\/2343\/705.html)/' 京华烟云.md
s -i -e '/^>/i\<\/div>\n' -e '/^>/a\\n<div class="p">\n' 一只狗的生活意见.md 
s -i '/^### .*#$/ s/^###/>/' 叔本华心灵咒语.md 
s -i '/^### .*#$/ s/^### /> <span class="hwxk">/' ——尼采.md 
s -i -e '/<div class="p">/a\<div class="wavy">\n' -e '/^> <span class="hwxk">/i\<\/div>\n' 叔本华心灵咒语.md 
s -i -e '/<div class="p">/a\<div class="wavy">\n' -e '/<\/div>/a\<\/div>\n' {1..12}.md
s -i '/^# / s/^# (.*)/# 《\1》/' */*.md
s -i '/<div class="poetry">/,/<\/div>/{/^$/d;s/$/<br \/>/;}' 名贤集·*.md
s -i -e '/<div class="poetry">/{s/<br \/>//;G;}' -e '/<\/div>/{s/<br \/>//;x;p;x;}' 名贤集·*.md
s -i '/ *$/ s/  $/<br \/>/' 增广贤文.md
s -i '/<.*>/{N;s/\n//;}' tmp2
s -i -e '/<.*>/ s/<.*"(\/.*)">(\+ .*)/\2(http:\/\/m.tadu.com\1)/' -e '/^$/d' tmp2
s -i -e '/^- (.*)/ s//- [\1](论生命之短暂\/\1.md)/' 论生命之短暂.md 
s -i '/^- (.*)/ s//- [\1](论生命之短暂\/\1.md)/' 论生命之短暂.md 
s -i '/^\+ (.*)/ s//\+ [\1](论生命之短暂\/\1.md)/' 论生命之短暂.md 

```

</details>

#-->

> 参考：
- [Sed 命令完全指南](https://linux.cn/article-10232-1.html)
- [sed 行处理](https://www.cnblogs.com/jjzd/p/6892891.html)
- [sed简单使用(一)加空行](https://www.cnblogs.com/zhanglong71/p/5424633.html)
- [sed简单使用(五)选择性删除](https://www.cnblogs.com/zhanglong71/p/5548742.html)