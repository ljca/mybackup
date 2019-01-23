/************************************************************************/
/*                                                                      */
/*      Zoom Page WE - Generic WebExtension - Popup Page                */
/*                                                                      */
/*      Javascript for Popup Page                                       */
/*                                                                      */
/*      Last Edit - 08 Dec 2018                                         */
/*                                                                      */
/*      Copyright (C) 2016-2018 DW-dev                                  */
/*                                                                      */
/*      Distributed under the GNU General Public License version 2      */
/*      See LICENCE.txt file and http://www.gnu.org/licenses/           */
/*                                                                      */
/************************************************************************/

/************************************************************************/
/*                                                                      */
/* Refer to Google Chrome developer documentation:                      */
/*                                                                      */
/*  https://developer.chrome.com/extensions/messaging                   */
/*                                                                      */
/*  https://developer.chrome.com/extensions/runtime                     */
/*  https://developer.chrome.com/extensions/storage                     */
/*  https://developer.chrome.com/extensions/tabs                        */
/*                                                                      */
/************************************************************************/

"use strict";

/************************************************************************/

/* Global variables */

var isFirefox;

var zoomMode,cssFullZoom,allowSubsites;
var zoomLevels;
var defaultFullLevel,defaultTextLevel;
var defaultSize;

var zoomType = 0;
var zoomLevel = 100;
var fontSize = 0;
var subsiteType = 0;

/************************************************************************/

/* Listener for popup page load */

document.addEventListener("DOMContentLoaded",onLoadPage,false);

/************************************************************************/

/* Initialize on page load */

function onLoadPage()
{
    chrome.storage.local.get(null,
    function(object)
    {
        var i,select,option;
        
        /* Load environment */
        
        isFirefox = object["environment-isfirefox"];
        
        if (isFirefox) document.body.setAttribute("isfirefox","");
        
        /* Load options */
        
        zoomMode = object["options-zoommode"];
        cssFullZoom = object["options-cssfullzoom"];
        allowSubsites = object["options-allowsubsites"];
        
        zoomLevels = object["options-zoomlevels"];
        
        defaultFullLevel = object["options-defaultfulllevel"];
        defaultTextLevel = object["options-defaulttextlevel"];
        
        defaultSize = object["options-defaultsize"];
        
        /* Initialize popup */
        
        select = document.getElementById("popup-zoomlevel-select");
        
        for (i = 0; i < zoomLevels.length; i++)
        {
            option = document.createElement("option");
            option.textContent = zoomLevels[i];
            
            if (option.textContent == defaultFullLevel)
            {
                if (isFirefox) option.style.setProperty("text-shadow","-1px 0px","");
                else option.style.setProperty("font-weight","bold","");
            }
            
            select.appendChild(option);
        }
        
        select.selectedIndex = -1;
        
        select = document.getElementById("popup-fontsize-select");
        
        for (i = 0; i < select.children.length; i++)
        {
            option = select.children[i];
            
            if (option.textContent == defaultSize)
            {
                if (isFirefox) option.style.setProperty("text-shadow","-1px 0px","");
                else option.style.setProperty("font-weight","bold","");
            }
        }
        
        select.selectedIndex = -1;
        
        select = document.getElementById("popup-subsitetype-select");
        
        select.selectedIndex = -1;
        
        chrome.tabs.query({ lastFocusedWindow: true, active: true },
        function(tabs)
        {
            if (!zoomablePage(tabs[0].url))
            {
                document.getElementById("popup-subsiteclear").disabled = true;
                document.getElementById("popup-subsitetype").disabled = true;
                document.getElementById("popup-subsitetype-select").disabled = true;
                document.getElementById("popup-fontreset").disabled = true;
                document.getElementById("popup-fontsize").disabled = true;
                document.getElementById("popup-fontsize-select").disabled = true;
                document.getElementById("popup-zoomreset").disabled = true;
                document.getElementById("popup-zoomautofit").disabled = true;
                document.getElementById("popup-zoomtype").disabled = true;
                document.getElementById("popup-zoomin").disabled = true;
                document.getElementById("popup-zoomout").disabled = true;
                document.getElementById("popup-zoomlevel").disabled = true;
                document.getElementById("popup-zoomlevel-select").disabled = true;
            }
            
            if (!scriptablePage(tabs[0].url))
            {
                document.getElementById("popup-fontreset").disabled = true;
                document.getElementById("popup-fontsize").disabled = true;
                document.getElementById("popup-fontsize-select").disabled = true;
                document.getElementById("popup-zoomautofit").disabled = true;
                document.getElementById("popup-zoomtype").disabled = true;
            }
            
            if (tabs[0].url.substr(0,5) != "http:" && tabs[0].url.substr(0,6) != "https:")
            {
                document.getElementById("popup-subsiteclear").disabled = true;
                document.getElementById("popup-subsitetype").disabled = true;
                document.getElementById("popup-subsitetype-select").disabled = true;
            }
            
            chrome.runtime.sendMessage({ type: "popupopened" });
        });
        
        /* Add event listeners */
        
        document.body.addEventListener("click",onDebug,false);
        
        document.getElementById("popup-expand").addEventListener("click",onExpand,false);
        
        document.getElementById("popup-subsiteclear").addEventListener("click",onSubsiteClear,false);
        document.getElementById("popup-subsitetype-select").addEventListener("change",onSubsiteTypeSelect,false);
        document.getElementById("popup-fontreset").addEventListener("click",onFontReset,false);
        document.getElementById("popup-fontsize-select").addEventListener("change",onFontSizeSelect,false);
        document.getElementById("popup-zoomreset").addEventListener("click",onZoomReset,false);
        document.getElementById("popup-zoomautofit").addEventListener("click",onZoomAutoFit,false);
        document.getElementById("popup-zoomtype").addEventListener("click",onZoomType,false);
        document.getElementById("popup-zoomin").addEventListener("click",onZoomIn,false);
        document.getElementById("popup-zoomout").addEventListener("click",onZoomOut,false);
        document.getElementById("popup-zoomlevel-select").addEventListener("change",onZoomLevelSelect,false);
        
        document.getElementById("popup-font").addEventListener("wheel",onWheelFont,true);
        document.getElementById("popup-zoom").addEventListener("wheel",onWheelZoom,true);
        
        /* Add message received listener */
        
        chrome.runtime.onMessage.addListener(
        function(message,sender,sendResponse)
        {
            var i,select,option;
            
            switch (message.type)
            {
                /* Messages from background page */
                
                case "contenttype":
                    
                    if (message.contenttype == "image/svg+xml")
                    {
                        document.getElementById("popup-subsiteclear").disabled = true;
                        document.getElementById("popup-subsitetype").disabled = true;
                        document.getElementById("popup-subsitetype-select").disabled = true;
                        document.getElementById("popup-fontreset").disabled = true;
                        document.getElementById("popup-fontsize").disabled = true;
                        document.getElementById("popup-fontsize-select").disabled = true;
                        document.getElementById("popup-zoomautofit").disabled = true;
                        document.getElementById("popup-zoomtype").disabled = true;
                    }
                    
                    break;
                    
                case "newzoomtypelevel":
                    
                    zoomType = (typeof message.zoomtype == "undefined") ? 0 : message.zoomtype;
                    zoomLevel = (typeof message.zoomlevel == "undefined") ? 100 : message.zoomlevel;
                    
                    document.getElementById("popup-zoomlevel").value = zoomLevel + "%";
                    
                    if (zoomType == 0)
                    {
                        document.getElementById("popup-zoomtype").textContent = "Full";
                        document.getElementById("popup-zoomtype").style.setProperty("color","#4040C0","");
                        document.getElementById("popup-zoomtype").style.setProperty("background-color","#F0F0FF","");
                        
                        document.getElementById("popup-zoomlevel").style.setProperty("color","#4040C0","");
                        document.getElementById("popup-zoomlevel").style.setProperty("background-color","#F0F0FF","");
                    }
                    else
                    {
                        document.getElementById("popup-zoomtype").textContent = "Text";
                        document.getElementById("popup-zoomtype").style.setProperty("color","#C02020","");
                        document.getElementById("popup-zoomtype").style.setProperty("background-color","#FFF0F0","");
                        
                        document.getElementById("popup-zoomlevel").style.setProperty("color","#C02020","");
                        document.getElementById("popup-zoomlevel").style.setProperty("background-color","#FFF0F0","");
                    }
                    
                    select = document.getElementById("popup-zoomlevel-select");
                    
                    for (i = 0; i < select.children.length; i++)
                    {
                        option = select.children[i];
                        
                        if ((zoomType == 0 && option.textContent == defaultFullLevel) || (zoomType == 1 && option.textContent == defaultTextLevel))
                        {
                            if (isFirefox) option.style.setProperty("text-shadow","-1px 0px","");
                            else option.style.setProperty("font-weight","bold","");
                        }
                        else
                        {
                            if (isFirefox) option.style.removeProperty("text-shadow");
                            else option.style.removeProperty("font-weight");
                        }
                    }
                    
                    break;
                    
                case "newfontsize":
                    
                    fontSize = (typeof message.fontsize == "undefined") ? 0 : message.fontsize;
                    
                    document.getElementById("popup-fontsize").value = fontSize + "px";
                    
                    document.getElementById("popup-fontsize").style.setProperty("color","#00A000","");
                    document.getElementById("popup-fontsize").style.setProperty("background-color","#F0FFF0","");
                    
                    select = document.getElementById("popup-fontsize-select");
                    
                    for (i = 0; i < select.children.length; i++)
                    {
                        option = select.children[i];
                        
                        if (option.textContent == defaultSize)
                        {
                            if (isFirefox) option.style.setProperty("text-shadow","-1px 0px","");
                            else option.style.setProperty("font-weight","bold","");
                        }
                        else
                        {
                            if (isFirefox) option.style.removeProperty("text-shadow");
                            else option.style.removeProperty("font-weight");
                        }
                    }
                    
                    break;
                    
                case "newsubsitetype":
                    
                    subsiteType = (typeof message.subsitetype == "undefined") ? 0 : message.subsitetype;
                    
                    document.getElementById("popup-subsitetype").value = document.getElementById("popup-subsitetype-select").children[subsiteType].value;
                    
                    document.getElementById("popup-subsitetype").style.setProperty("color","#A000A0","");
                    document.getElementById("popup-subsitetype").style.setProperty("background-color","#FFF0FF","");
                    
                    if (subsiteType > 0)
                    {
                        document.getElementById("popup-expand").style.setProperty("display","none","");
                        document.getElementById("popup-subsite").style.setProperty("display","block","");
                    }
                    
                    break;
            }
        });
        
        chrome.tabs.query({ lastFocusedWindow: true, active: true },
        function(tabs)
        {
            chrome.tabs.getZoomSettings(tabs[0].id,
            function(zoomSettings)
            {
                if (zoomSettings.scope == "per-tab" && zoomMode == 0 && allowSubsites)
                {
                    document.getElementById("popup-expand").style.setProperty("display","block","");
                }
            });
        });
    });
}

/************************************************************************/

/* Debug click function */

function onDebug(event)
{
    if (event.target.id == "popup-subsite-1" || event.target.id == "popup-subsite-2" ||
        event.target.id == "popup-font-1" || event.target.id == "popup-font-2" ||
        event.target.id == "popup-zoom-1" || event.target.id == "popup-zoom-2")
    {
        chrome.runtime.sendMessage({ type: "debug" });
    }
}

/************************************************************************/

/* Expand click function */

function onExpand(event)
{
    document.getElementById("popup-expand").style.setProperty("display","none","");
    document.getElementById("popup-subsite").style.setProperty("display","block","");
}

/************************************************************************/

/* Button click functions */

function onSubsiteClear(event)
{
    document.getElementById("popup-subsiteclear").blur();
    
    document.getElementById("popup-subsitetype-select").selectedIndex = 0;
    
    chrome.runtime.sendMessage({ type: "subsiteclear" });
}

function onSubsiteTypeSelect(event)
{
    document.getElementById("popup-subsitetype-select").blur();
    
    if (event.target.selectedIndex == 0) chrome.runtime.sendMessage({ type: "subsiteclear" });
    else chrome.runtime.sendMessage({ type: "subsitetypeselect", subsitetype: event.target.selectedIndex });
}

function onFontReset(event)
{
    var i,select,option;
    
    document.getElementById("popup-fontreset").blur();
    
    document.getElementById("popup-fontsize-select").selectedIndex = 0;
    
    if (event.ctrlKey)
    {
        defaultSize = fontSize;
        
        chrome.storage.local.set({ "options-defaultsize": defaultSize });
        
        select = document.getElementById("popup-fontsize-select");
        
        for (i = 0; i < select.children.length; i++)
        {
            option = select.children[i];
            
            if (option.textContent == defaultSize)
            {
                if (isFirefox) option.style.setProperty("text-shadow","-1px 0px","");
                else option.style.setProperty("font-weight","bold","");
            }
            else
            {
                if (isFirefox) option.style.removeProperty("text-shadow");
                else option.style.removeProperty("font-weight");
            }
        }
    }
    else
    {
        chrome.runtime.sendMessage({ type: "fontreset" });
    }
}

function onFontSizeSelect(event)
{
    document.getElementById("popup-fontsize-select").blur();
    
    chrome.runtime.sendMessage({ type: "fontsizeselect", fontsize: +event.target.options[event.target.selectedIndex].text });
}

function onZoomReset(event)
{
    var i,select,option;
    
    document.getElementById("popup-zoomreset").blur();
    
    document.getElementById("popup-zoomlevel-select").selectedIndex = 0;
    
    if (event.ctrlKey)
    {
        if (zoomType == 0)
        {
            defaultFullLevel = zoomLevel;
            
            chrome.storage.local.set({ "options-defaultfulllevel": defaultFullLevel });
        }
        else
        {
            defaultTextLevel = zoomLevel;
        
            chrome.storage.local.set({ "options-defaulttextlevel": defaultTextLevel });
        }
        
        select = document.getElementById("popup-zoomlevel-select");
        
        for (i = 0; i < select.children.length; i++)
        {
            option = select.children[i];
            
            if ((zoomType == 0 && option.textContent == defaultFullLevel) || (zoomType == 1 && option.textContent == defaultTextLevel))
            {
                if (isFirefox) option.style.setProperty("text-shadow","-1px 0px","");
                else option.style.setProperty("font-weight","bold","");
            }
            else
            {
                if (isFirefox) option.style.removeProperty("text-shadow");
                else option.style.removeProperty("font-weight");
            }
        }
    }
    else
    {
        chrome.runtime.sendMessage({ type: "zoomreset" });
    }
}

function onZoomAutoFit(event)
{
    document.getElementById("popup-zoomautofit").blur();
    
    chrome.runtime.sendMessage({ type: "zoomautofit" });
}

function onZoomType(event)
{
    document.getElementById("popup-zoomtype").blur();
    
    chrome.runtime.sendMessage({ type: "zoomtype" });
}

function onZoomIn(event)
{
    document.getElementById("popup-zoomin").blur();
    
    chrome.runtime.sendMessage({ type: "zoomin" });
}

function onZoomOut(event)
{
    document.getElementById("popup-zoomout").blur();
    
    chrome.runtime.sendMessage({ type: "zoomout" });
}

function onZoomLevelSelect(event)
{
    document.getElementById("popup-zoomlevel-select").blur();
    
    chrome.runtime.sendMessage({ type: "zoomlevelselect", zoomlevel: +event.target.options[event.target.selectedIndex].text });
}

/************************************************************************/

/* Wheel rotate functions */

function onWheelFont(event)
{
    if (event.deltaY < 0) chrome.runtime.sendMessage({ type: "fontup" });
    else if (event.deltaY > 0) chrome.runtime.sendMessage({ type: "fontdown" });
}

function onWheelZoom(event)
{
    if (event.deltaY < 0) chrome.runtime.sendMessage({ type: "zoomin" });
    else if (event.deltaY > 0) chrome.runtime.sendMessage({ type: "zoomout" });
}

/************************************************************************/

/* Utility functions */

function zoomablePage(url)
{
    /* Can (and should) browser apply Full Zoom to this page ? */
    /* Chrome - scriptable pages */
    /* Firefox - all pages - except for a few pages that should not be zoomed */
    
    if (siteZoomablePage(url)) return true;
    
    if (isFirefox)
    {
        if (document.getElementById("popup-zoomtype").textContent == "Full" && !cssFullZoom)  /* browser full zoom */
        {
            if (url.substr(0,11) != "about:blank" &&
                url.substr(0,9) != "resource:") return true;
        }
    }
    
    return false;
}

function siteZoomablePage(url)
{
    /* Can (and should) browser apply Per-Site Full Zoom to this page ? */
    /* Chrome - scriptable pages */
    /* Firefox - scriptable, https://addons.mozilla.org and about: pages */
    
    if (scriptablePage(url)) return true;
    
    if (isFirefox)
    {
        if (document.getElementById("popup-zoomtype").textContent == "Full" && !cssFullZoom)  /* browser full zoom */
        {
            if (url.substr(0,26) == "https://addons.mozilla.org" ||
                url.substr(0,14) == "moz-extension:" ||
                (url.substr(0,6) == "about:" && url.substr(0,11) != "about:blank")) return true;
        }
    }
    
    return false;
}

function scriptablePage(url)
{
    /* Can content script be loaded into this page ? */
    /* Content script is required for Minimum Font Size, AutoFit, CSS Full Zoom and Text Zoom */
    /* Chrome & Firefox - http:, https: and file: pages - except for a few pages where content script cannot or should not be loaded */
    
    if (isFirefox)
    {
        if ((url.substr(0,5) == "http:" || url.substr(0,6) == "https:" || url.substr(0,5) == "file:") &&
            url.substr(0,26) != "https://addons.mozilla.org") return true;
    }
    else /* Chrome */
    {
        if ((url.substr(0,5) == "http:" || url.substr(0,6) == "https:" || url.substr(0,5) == "file:") &&
            url.substr(0,34) != "https://chrome.google.com/webstore" &&
            (url.substr(0,19) != "https://www.google." || url.indexOf("/_/chrome/newtab") < 0) &&
            (url.substr(0,19) != "https://www.google." || url.indexOf("sourceid=chrome-instant") < 0)) return true;
    }
    
    return false;
}

/************************************************************************/
