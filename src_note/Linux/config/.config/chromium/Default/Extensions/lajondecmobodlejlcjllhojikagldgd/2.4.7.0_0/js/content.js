//================================================
/*

Zoom
Zoom in or out on web content using the zoom button for more comfortable reading.
Copyright (C) 2018 Stefan vd
www.stefanvd.net

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.


To view a copy of this license, visit http://creativecommons.org/licenses/GPL/2.0/

*/
//================================================

function $(id) { return document.getElementById(id); }

var currentscreen = screen.width+"x"+screen.height;
chrome.runtime.sendMessage({action: "getallRatio", website: window.location.href, screen: currentscreen });

// Listen for messages
chrome.runtime.onMessage.addListener(function (msg, sender, sendResponse) {
    // If the received message has the expected format...
    if (msg.text === 'getwebzoom') {
        // Call the specified callback, passing
        // the web-page's DOM content as argument
        sendResponse(document.body.style.zoom);
    }
    else if (msg.text === 'getfontsize') {
        // Call the specified callback, passing
        // the web-page's DOM content as argument
        if($('stefanvdzoomextension')){
            var currentfontsizezoom = $('stefanvdzoomextension').getAttribute('data-current-zoom');
            sendResponse(currentfontsizezoom/100);
        }
    }
    else if (msg.text === 'refreshscreen') {
        var currentscreen = screen.width+"x"+screen.height;
        chrome.runtime.sendMessage({action: "getallRatio", website: window.location.href, screen: currentscreen });
    }
    else if (msg.text === 'setfontsize') {
        setdefaultfontsize();
    }else if (msg.text === 'changefontsize') {
        var newfontsize = msg.value;
        if($('stefanvdzoomextension')){
            $('stefanvdzoomextension').setAttribute('data-current-zoom',newfontsize);
        }else{
            var div = document.createElement("div");
            div.setAttribute('id','stefanvdzoomextension');
            div.setAttribute('data-current-zoom',newfontsize);
            div.style.display = "none";
            document.body.appendChild(div);
        }
        var q = document.getElementsByTagName('*');
        for(var i = 0; i < q.length; i++ ) {
            if(q[i].hasAttribute("data-default-fontsize")){
                var tempcurrent = q[i].getAttribute("data-default-fontsize")
                tempcurrent = tempcurrent.replace('px','');
                finalfontsize = tempcurrent * (newfontsize/100);
                finalfontsize = finalfontsize + "px";
            q[i].style.setProperty("font-size", finalfontsize, "important");
            }
        }
    }
});

function setdefaultfontsize(){
    var q = document.getElementsByTagName('*');
    for(var i = 0; i < q.length; i++ ) {
        if(q[i].currentStyle){
            var y = q[i].currentStyle["font-size"];
        }
        else if(window.getComputedStyle){
            var st = document.defaultView.getComputedStyle(q[i], null);
            var y = st.getPropertyValue("font-size");
        }

		if(q[i].hasAttribute("data-default-fontsize")){
            // already got the default font size
		}else{
			q[i].setAttribute("data-default-fontsize",y);
        }
    }
}

var zoommousescroll; var zoommousebuttonleft; var zoommousescrollup; var zoommousescrolldown;
var rightmousehold = false;
chrome.storage.sync.get(['zoommousescroll','zoommousebuttonleft','zoommousebuttonright','zoommousescrollup','zoommousescrolldown'], function(response){
zoommousescroll = response.zoommousescroll;if(zoommousescroll == null)zoommousescroll = false; // default zoommousescroll false
zoommousebuttonleft = response.zoommousebuttonleft;if(zoommousebuttonleft == null)zoommousebuttonleft = true; // default zoommousebuttonleft false
zoommousebuttonright = response.zoommousebuttonright;if(zoommousebuttonright == null)zoommousebuttonright = false; // default zoommousebuttonright false
zoommousescrollup = response.zoommousescrollup;if(zoommousescrollup == null)zoommousescrollup = true; // default zoommousescrollup false
zoommousescrolldown = response.zoommousescrolldown;if(zoommousescrolldown == null)zoommousescrolldown = false; // default zoommousescrolldown false

if(zoommousescroll == true){
    document.body.addEventListener("mousedown", function(e) {
        e = e || window.event;
        if(zoommousebuttonleft == true){
            if(e.which == 1){
            rightmousehold = true;
            }
        }else{
            if(e.which == 3){
            rightmousehold = true;
            }
        }
    });
    document.body.addEventListener("mouseup", function(e) {
        rightmousehold = false;
    });

    window.addEventListener('wheel', function(e) {
        if(zoommousescrollup == true){
            if (e.deltaY < 0 && rightmousehold == true) {
                //console.log('scrolling up');
                chrome.runtime.sendMessage({name: "contentzoomout"});
            }
            if (e.deltaY > 0 && rightmousehold == true) {
                //console.log('scrolling down');
                chrome.runtime.sendMessage({name: "contentzoomin"});
            }
        } else{
            if (e.deltaY < 0 && rightmousehold == true) {
                //console.log('scrolling up');
                chrome.runtime.sendMessage({name: "contentzoomin"});
            }
            if (e.deltaY > 0 && rightmousehold == true) {
                //console.log('scrolling down');
                chrome.runtime.sendMessage({name: "contentzoomout"});
            }
        }
    });
}
});