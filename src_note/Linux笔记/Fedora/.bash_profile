# .bash_profile

# Get the aliases and functions
if [ -f ~/.bashrc ]; then
	. ~/.bashrc
fi

# User specific environment and startup programs

#PATH=$PATH:$HOME/.local/bin:$HOME/bin

tmp="/media/App/Lin/Develop/Java_Web"

if [ -d ${tmp} ] ; then
JAVA_HOME="${tmp}/jdk7u80"
JRE_HOME="${JAVA_HOME}/jre"
CLASSPATH=".:${JAVA_HOME}/lib/{tools.jar,dt.jar}:${JAVA_HOME}/lib/*:${JRE_HOME}/lib/*"
ANT_HOME="${tmp}/Web/apache-ant-1.9.7"
CATA_HOME="${tmp}/Web/apache-tomcat-7.0.69"
MySQL="${tmp}/Web/Server/MySQL5.6"
HTTPD="${tmp}/Web/Server/httpd-2.4.0"
PATH="${JAVA_HOME}/bin:${JRE_HOME}/bin:${ANT_HOME}/bin:${CATA_HOME}/bin:${HTTPD}/bin:${MySQL}/bin:${PATH}"
fi
export JAVA_HOME JRE_HOME CLASSPATH ANT_HOME CATA_HOME MySQL PATH
unset tmp
