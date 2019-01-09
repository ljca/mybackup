OBJECT=all
SOURCE=docbook.xml
#PARAM = param.xsl
PARAM=/usr/share/xml/docbook/xsl-stylesheets-1.79.1/html/docbook.xsl
ARG = -o html/docbook.html
COMPILER = xsltproc

$(OBJECT):$(SOURCE) 
	$(COMPILER) $(ARG) $(PARAM) $(SOURCE)

clean:
	rm -rf html/*.html

# vim:set noet noci ts=4 sts=4 st=4:
