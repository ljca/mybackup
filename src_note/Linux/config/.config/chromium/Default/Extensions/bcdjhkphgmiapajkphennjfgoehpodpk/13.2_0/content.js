/************************************************************************/
/*                                                                      */
/*      Zoom Page WE - Generic WebExtension - Content Pages             */
/*                                                                      */
/*      Javascript for Content Pages                                    */
/*                                                                      */
/*      Last Edit - 04 Dec 2018                                         */
/*                                                                      */
/*      Copyright (C) 2014-2018 DW-dev                                  */
/*                                                                      */
/*      Distributed under the GNU General Public License version 2      */
/*      See LICENCE.txt file and http://www.gnu.org/licenses/           */
/*                                                                      */
/************************************************************************/

/************************************************************************/
/*                                                                      */
/* Refer to Google Chrome developer documentation:                      */
/*                                                                      */
/*  https://developer.chrome.com/extensions/content_scripts             */
/*  https://developer.chrome.com/extensions/messaging                   */
/*                                                                      */
/*  https://developer.chrome.com/extensions/match_patterns              */
/*                                                                      */
/*  https://developer.chrome.com/extensions/runtime                     */
/*  https://developer.chrome.com/extensions/storage                     */
/*                                                                      */
/************************************************************************/

"use strict";

/************************************************************************/

/* Global variables */

var isFirefox;

var platformOS;

var cssFullZoom;
var enableScaling,applyScaling;
var enableCtrl789,enableRightWheel;
var defaultOtherLevel,autoMinLevel,autoMaxLevel;
var adjustLineSpace,lineSpaceFactor;
var applyToDynamic;

var zoomType = 0;
var zoomLevel = 100;
var fontSize = 0;

var initialized = false;
var prepared = false;

var rightDown = false;
var wheelZoom = false;

var iterCount,iterLimit,iterString;

/************************************************************************/

/* Initialize on script load */

/* Hide document contents in case text zoom or minimum font size will be applied */

document.documentElement.style.setProperty("opacity","0.0","important");

chrome.storage.local.get(null,
function(object)
{
    /* Load environment */
    
    isFirefox = object["environment-isfirefox"];
    
    platformOS = object["environment-platformos"];
    
    /* Load options */
    
    cssFullZoom = object["options-cssfullzoom"];
    
    enableScaling = object["options-enablescaling"];
    applyScaling = object["options-applyscaling"];
    
    enableCtrl789 = object["options-enablectrl789"];
    enableRightWheel = object["options-enablerightwheel"]
    
    defaultOtherLevel = object["options-defaultotherlevel"];
    autoMinLevel = object["options-autominlevel"];
    autoMaxLevel = object["options-automaxlevel"];
    
    adjustLineSpace = object["options-adjustlinespace"];
    lineSpaceFactor = object["options-linespacefactor"];
    
    applyToDynamic = object["options-applytodynamic"];
    
    /* Add listeners */
    
    addListeners();
    
    /* Initialize document */
    
    
    chrome.runtime.sendMessage({ type: "scriptloaded", contenttype: document.contentType },
    function(object)
    {
        var prepare;
        
        if (chrome.runtime.lastError != null) prepare = false;
        else if (document.contentType == "image/svg+xml") prepare = false;
        else prepare = ((object.zoomtype == 1 && object.zoomlevel != defaultOtherLevel) || object.fontsize > 0);
        
        /* Show document contents if text zoom and minimum font size will not be applied */
        
        if (!prepare) document.documentElement.style.removeProperty("opacity");
        
        /* Wait for DOM content to load before initializing */
        
        if (document.readyState == "complete")
        {
            initializeDocument(prepare);
            
            initialized = true;
            
            chrome.runtime.sendMessage({ type: "initialized" });
            
            if (document.contentType.substr(0,5) == "image" && document.contentType != "image/svg+xml")
            {
                chrome.runtime.sendMessage({ type: "imageloaded" });
                
                if (enableScaling) scaleSmallImage();
            }
        }
        else if (document.readyState == "interactive")
        {
            initializeDocument(prepare);
            
            initialized = true;
            
            chrome.runtime.sendMessage({ type: "initialized" });
            
            window.addEventListener("load",
            function(event)
            {
                if (document.contentType.substr(0,5) == "image" && document.contentType != "image/svg+xml")
                {
                    chrome.runtime.sendMessage({ type: "imageloaded" });
                    
                    if (enableScaling) scaleSmallImage();
                }
            },false);
        }
        else  /* document.readyState == "loading" */
        {
            window.addEventListener("DOMContentLoaded",
            function(event)
            {
                initializeDocument(prepare);
                
                initialized = true;
                
                chrome.runtime.sendMessage({ type: "initialized" });
            },false);
            
            window.addEventListener("load",
            function(event)
            {
                if (!initialized)  /* in case DOMContentLoaded event missed or not fired */
                {
                    initializeDocument(prepare);
                    
                    initialized = true;
                    
                    chrome.runtime.sendMessage({ type: "initialized" });
                }
                
                if (document.contentType.substr(0,5) == "image" && document.contentType != "image/svg+xml")
                {
                    chrome.runtime.sendMessage({ type: "imageloaded" });
                    
                    if (enableScaling) scaleSmallImage();
                }
            },false);
        }
    });
});

/************************************************************************/

/* Add listeners */

function addListeners()
{
    /* Key event listeners */
    
    document.addEventListener("keydown",onKeyDown,true);
    
    /* Mouse event listeners */
    
    document.addEventListener("mousedown",onMouseDown,true);
    document.addEventListener("mouseup",onMouseUp,true);
    document.addEventListener("contextmenu",onContextMenu,true);
    document.addEventListener("wheel",onWheel,true);
    
    /* Resize event listeners */
    
    window.addEventListener("resize",onResize,true);
    
    /* Storage changed listener */
    
    chrome.storage.onChanged.addListener(
    function(changes,areaName)
    {
        chrome.storage.local.get(null,
        function(object)
        {
            cssFullZoom = object["options-cssfullzoom"];
            
            enableScaling = object["options-enablescaling"];
            applyScaling = object["options-applyscaling"];
            
            enableCtrl789 = object["options-enablectrl789"];
            enableRightWheel = object["options-enablerightwheel"]
            
            defaultOtherLevel = object["options-defaultotherlevel"];
            autoMinLevel = object["options-autominlevel"];
            autoMaxLevel = object["options-automaxlevel"];
            
            adjustLineSpace = object["options-adjustlinespace"];
            lineSpaceFactor = object["options-linespacefactor"];
            
            applyToDynamic = object["options-applytodynamic"];
            
            if ("options-enablescaling" in changes)
            {
                if (document.contentType.substr(0,5) == "image" && document.contentType != "image/svg+xml")
                {
                    document.body.children[0].removeEventListener("click",onClickSmallImage,false);
                    
                    document.body.children[0].style.removeProperty("cursor");
                    
                    if (object["options-enablescaling"])
                    {
                        document.body.children[0].addEventListener("click",onClickSmallImage,false);
                        
                        setImageCursor();
                    }
                }
            }
        });
    });
    
    /* Message received listener */
    
    chrome.runtime.onMessage.addListener(
    function(message,sender,sendResponse)
    {
        var i,style;
        
        switch (message.type)
        {
            /* Messages from background page for all frames */
            
            case "setzoomtypelevel":
                
                if (!initialized) break;
                
                zoomType = message.zoomtype;
                zoomLevel = message.zoomlevel;
                
                /* Set CSS full zoom level */
                
                style = document.getElementById("zoompage-zoomlevel-style");
                
                if (style == null && message.zoomtype == 0 && message.zoomlevel != 100 && cssFullZoom)
                {
                    /* Add style element for CSS full zoom */
                    
                    style = document.createElement("style");
                    style.id = "zoompage-zoomlevel-style";
                    style.type = "text/css";
                    document.head.appendChild(style);
                }
                
                if (style != null)
                {
                    if (message.zoomtype == 0 && cssFullZoom)
                    {
                        if (!isFirefox) style.textContent = "body { zoom: " + (message.zoomlevel/100) + "; }";
                        else style.textContent = "body { transform-origin: left top; transform: scale(" + (message.zoomlevel/100) + "," + (message.zoomlevel/100) + "); }";
                    }
                    else style.textContent = "";
                }
                
                /* Set text zoom level */
                
                style = document.getElementById("zoompage-fontsize-style");
                
                if (style == null && message.zoomtype == 1 && message.zoomlevel != defaultOtherLevel)
                {
                    /* Prepare document for text zoom and minimum font size */
                    
                    if (!prepared) prepareDocument();
                    
                    prepared = true;
                    
                    /* Add style element for text zoom and minimum font size */
                    
                    style = document.createElement("style");
                    style.id = "zoompage-fontsize-style";
                    style.type = "text/css";
                    document.head.appendChild(style);
                }
                
                if (style != null)
                {
                    style.textContent = buildFontSizeRules(message.zoomtype,message.zoomlevel,fontSize);
                }
                
                break;
                
            case "setfontsize":
                
                if (!initialized) break;
                
                fontSize = message.fontsize;
                
                /* Set minimum font size */
                
                style = document.getElementById("zoompage-fontsize-style");
                
                if (style == null && message.fontsize > 0)
                {
                    /* Prepare document for text zoom and minimum font size */
                    
                    if (!prepared) prepareDocument();
                    
                    prepared = true;
                    
                    /* Add style element for text zoom and minimum font size */
                    
                    style = document.createElement("style");
                    style.id = "zoompage-fontsize-style";
                    style.type = "text/css";
                    document.head.appendChild(style);
                }
                
                if (style != null)
                {
                    style.textContent = buildFontSizeRules(zoomType,zoomLevel,message.fontsize);
                }
                
                break;
                
            case "tabactivated":
                
                rightDown = false;
                wheelZoom = false;
                
                break;
                
            /* Messages from background page only for main frame */
            
            case "autofitstart":
                
                autofitIterate(message.setsite,true);
                
                break;
                
            case "autofititerate":
                
                autofitIterate(message.setsite,false);
                
                break;
        }
    });
}

/************************************************************************/

/* Initialize document on load */

function initializeDocument(prepare)
{
    if (prepare)
    {
        /* Prepare document for text zoom and minimum font size */
        
        prepareDocument();
        
        prepared = true;
        
        /* Show document contents */
        
        window.setTimeout(  /* allow time for CSS to be applied */
        function()
        {
            document.documentElement.style.removeProperty("opacity");
        },50);
    }
}

/************************************************************************/

/* Prepare document for text zoom and minimum font size */

function prepareDocument()
{
    var style,observer;
    var starttime,endtime;
    var elements;  /* NodeList */
    
    starttime = performance.now();
    
    /* Make list of all elements in document that can contain visible text nodes */
    
    elements = document.querySelectorAll("body, body *, frameset, frameset *");
    
    /* Add font size attribute to elements */
    
    addFontSizeAttribute(elements);
    
    /* Add mutation observer to detect added nodes in document */
    
    observer = new document.defaultView.MutationObserver(
    function(mutations)
    {
        var elementcount,starttime,endtime;
        
        elementcount = 0;
        starttime = performance.now();
        
        mutations.forEach(
        function(mutation)
        {
            var i,stylefontsize,stylepriority,origfontsize;
            var elements;  /* NodeList */
            
            for (i = 0; i < mutation.addedNodes.length; i++)
            {
                if (mutation.addedNodes[i].nodeType == 1)
                {
                    /* Remember style font-size property and priority for mutation target element */
                    
                    stylefontsize = mutation.target.style.getPropertyValue("font-size");
                    stylepriority = mutation.target.style.getPropertyPriority("font-size");
                    
                    /* Apply original font-size to mutation target element */
                    
                    if (mutation.target.hasAttribute("zoompage-fontsize"))
                    {
                        origfontsize = mutation.target.getAttribute("zoompage-fontsize");
                        mutation.target.style.setProperty("font-size",origfontsize + "px","important");
                    }
                    
                    /* Make list of elements beneath added node that can contain visible text nodes */
                    
                    elements = mutation.addedNodes[i].querySelectorAll("body, body *, frameset, frameset *");
                    
                    /* Remove font size attribute from added elements - in case they were previously part of document */
                    
                    removeFontSizeAttribute(elements);
                    removeFontSizeAttribute([mutation.addedNodes[i]]);  /* added node not included in elements */
                    
                    /* Add font size attribute to added elements */
                    
                    addFontSizeAttribute(elements);
                    addFontSizeAttribute([mutation.addedNodes[i]]);  /* added node not included in elements */
                    
                    /* Reinstate style font-size property and priority for mutation target element */
                    
                    if (stylefontsize == "") mutation.target.style.removeProperty("font-size");
                    else mutation.target.style.setProperty("font-size",stylefontsize + "px",stylepriority);
                    
                    elementcount += elements.length;
                }
            }
        });
        
        endtime = performance.now();
        
        // console.log("Mutation Time: " + (endtime-starttime).toFixed(1) + "ms  -  Element Count: " + elementcount);
    });
    
    if (applyToDynamic) observer.observe(document.body,{ childList: true, subtree: true });  /* <body> or top-level <frameset> */
    
    endtime = performance.now();
    
    // console.log("Prepare Time: " + (endtime-starttime).toFixed(1) + "ms  -  Element Count: " + elements.length);
}

/************************************************************************/

/* Auto Fit Zoom */

/************************************************************************/
/*                                                                      */
/*  innerWidth  - width of window including scrollbar if any            */
/*              - window.innerWidth                                     */
/*                                                                      */
/*  clientWidth - width of visible content excluding scrollbar if any   */
/*              - window.innerWidth less width of scrollbar if any      */
/*              - html.clientWidth or body.clientWidth                  */
/*                                                                      */
/*  scrollWidth - width of document content                             */
/*              - html.scrollWidth or body.scrollWidth                  */
/*                                                                      */
/************************************************************************/

/************************************************************************/
/*                                                                      */
/*  Firefox Browser Zoom - html.scrollWidth == or >= html.clientWidth   */
/*                       - body.scrollWidth == or >= body.clientWidth   */
/*                                                                      */
/*  Firefox CSS Zoom     - html.scrollWidth == or >= html.clientWidth   */
/*                       - body.scrollWidth always == body.clientWidth  */
/*                                                                      */
/*  Chrome Browser Zoom  - html.scrollWidth == or >= html.clientWidth   */
/*                       - body.scrollWidth always ~= body.clientWidth  */
/*                                                                      */
/*  ChromeCSS Zoom       - html.scrollWidth == or >= html.clientWidth   */
/*                       - body.scrollWidth always == body.clientWidth  */
/*                                                                      */
/************************************************************************/
    
function autofitIterate(setsite,start)
{
    var clientWidth,scrollWidth,scrollBarWidth;
    
    /* Reduce zoom level until content fits window */
    
    scrollBarWidth = Math.ceil(17/(zoomLevel/100));
    
    clientWidth = document.body.parentNode.clientWidth;
    scrollWidth = document.body.parentNode.scrollWidth;
    
    if (start)
    {
        iterCount = -1;
        iterLimit = 1;
        iterString = "";
    }
    
    iterCount++;
    iterString += iterCount + ":  " + clientWidth + " - " + scrollWidth + " - " + scrollBarWidth + " - " + zoomLevel + "% | ";
    
    /* Add scroll bar width to client width because some responsive pages assume full inner window width is available */
    
    if (iterCount == 0 && scrollWidth <= clientWidth && zoomLevel != autoMaxLevel)
    {
        iterLimit++;
        
        zoomLevel = autoMaxLevel;
        
        chrome.runtime.sendMessage({ type: "autofitrepeat", zoomlevel: zoomLevel, setsite: setsite });
    }
    else if (iterCount < iterLimit && scrollWidth > clientWidth+scrollBarWidth && zoomLevel > autoMinLevel)
    {
        /* Calculate fit-to-width zoom level */ 
        
        if (zoomType == 0 && cssFullZoom)
        {
            if (isFirefox) zoomLevel = Math.round((clientWidth/scrollWidth)*zoomLevel);
            else zoomLevel = Math.floor((clientWidth/scrollWidth)*zoomLevel*0.98);
        }
        else zoomLevel = Math.floor((clientWidth/scrollWidth)*zoomLevel*0.98);
        
        if (zoomLevel < autoMinLevel) zoomLevel = autoMinLevel;
        
        chrome.runtime.sendMessage({ type: "autofitrepeat", zoomlevel: zoomLevel, setsite: setsite });
    }
    else
    {
        // console.log(iterString);
        
        chrome.runtime.sendMessage({ type: "autofitfinish", setsite: setsite });
    }
}

/************************************************************************/

/* Text Zoom and Minimum Font Size */

function addFontSizeAttribute(elements)
{
    var i,computedStyle,size;
    
    var voidElements = new Array("area","base","br","col","command","embed","hr","img","link","menuitem","meta","param","source","track","wbr");  /* exclude frame,input,keygen */
    var skipElements = new Array("audio","canvas","noscript","object","script","style","video");
    
    for (i = elements.length-1; i >= 0; i--)
    {
        if (elements[i].hasAttribute("zoompage-fontsize")) continue;  /* element already has font size attribute */
        
        if (voidElements.indexOf(elements[i].localName) >= 0) continue;  /* void elements that cannot have text nodes */
        
        if (skipElements.indexOf(elements[i].localName) >= 0) continue;  /* skip elements with text nodes that are hidden always or hidden if element supported by browser */
        
        computedStyle = window.getComputedStyle(elements[i]);
        
        if (computedStyle != null)
        {
            size = computedStyle.getPropertyValue("font-size");
            
            size = Math.round(size.substr(0,size.length-2));
            
            elements[i].setAttribute("zoompage-fontsize",size);
        }
    }
}

function removeFontSizeAttribute(elements)
{
    var i;
    
    for (i = elements.length-1; i >= 0; i--)
    {
        elements[i].removeAttribute("zoompage-fontsize");
    }
}

function buildFontSizeRules(type,level,minsize)
{
    var rules,size;
    
    rules = "";
    
    for (size = 1; size <= 50; size++)
    {
        if (type == 1 && size < minsize)
        {
            rules += "[zoompage-fontsize=\"" + size + "\"] { font-size: " + (minsize*level/defaultOtherLevel) + "px !important;";
            if (adjustLineSpace) rules += " line-height: " + lineSpaceFactor + "em !important;";
            rules += " } ";
        }
        else if (type == 1 && size >= minsize)
        {
            rules += "[zoompage-fontsize=\"" + size + "\"] { font-size: " + (size*level/defaultOtherLevel) + "px !important;";
            if (adjustLineSpace) rules += " line-height: " + lineSpaceFactor + "em !important;";
            rules += " } ";
        }
        else if (type == 0 && size < minsize)
        {
            rules += "[zoompage-fontsize=\"" + size + "\"] { font-size: " + minsize + "px !important;";
            if (adjustLineSpace) rules += " line-height: " + lineSpaceFactor + "em !important;";
            rules += " } ";
        }
    }
    
    // console.log("Font Size Rules: " + rules);
    
    return rules;
}

/************************************************************************/

/* Small image functions */

function scaleSmallImage()
{
    window.setTimeout(
    function()
    {
        document.body.children[0].addEventListener("click",onClickSmallImage,false);
        
        if (applyScaling) onClickSmallImage();
        else setImageCursor();
    },10);
}

function onClickSmallImage(event)
{
    var image;
    
    image = document.body.children[0];
    
    if (image.naturalWidth < window.innerWidth && image.naturalHeight < window.innerHeight) 
    {
        if (image.width != image.naturalWidth || image.height != image.naturalHeight)
        {
            image.height = image.naturalHeight;
            image.width = image.naturalWidth;
            
            if (isFirefox) document.title = document.title.replace(/ - Scaled \(\d+%\)/,"");
        }
        else
        {
            if (window.innerWidth/window.innerHeight <= image.naturalWidth/image.naturalHeight)
            {
                image.width = window.innerWidth-1;
                image.height = Math.floor(image.width*(image.naturalHeight/image.naturalWidth));
            }
            else
            {
                image.height = window.innerHeight-1;
                image.width = Math.floor(image.height*(image.naturalWidth/image.naturalHeight));
            }
            
            if (isFirefox) document.title = document.title + " - Scaled (" + Math.round((image.width/image.naturalWidth)*100) + "%)";
        }
    }
    
    setImageCursor();
    
    chrome.runtime.sendMessage({ type: "imageclicked" });
}

function setImageCursor()
{
    var image;
    
    image = document.body.children[0];
    
    if (image.width < image.naturalWidth || image.height < image.naturalHeight) image.style.setProperty("cursor","zoom-in","");
    else if (image.width > image.naturalWidth || image.height > image.naturalHeight) image.style.setProperty("cursor","zoom-out","");
    else if (image.width < window.innerWidth && image.height < window.innerHeight) image.style.setProperty("cursor","zoom-in","");
    else if (image.width > window.innerWidth || image.height > window.innerHeight) image.style.setProperty("cursor","zoom-out","");
    else image.style.setProperty("cursor","auto","");
}

/************************************************************************/

/* Key event functions */

function onKeyDown(event)
{
    if ((platformOS != "mac" && event.ctrlKey) || (platformOS == "mac" && event.metaKey))
    {
        if (event.key == "=" || event.key == "+") chrome.runtime.sendMessage({ type: "zoomin" });
        else if (event.key == "-") chrome.runtime.sendMessage({ type: "zoomout" });
        else if (event.key == "0") chrome.runtime.sendMessage({ type: "zoomreset" });
        
        if (event.key == "=" || event.key == "+" || event.key == "-" || event.key == "0") event.preventDefault();
        
        if (enableCtrl789)
        {
            if (event.key == "9") chrome.runtime.sendMessage({ type: "zoomtype" });
            else if (event.key == "8") chrome.runtime.sendMessage({ type: "zoomautofit" });
            else if (event.key == "7") chrome.runtime.sendMessage({ type: "fontreset" });
            
            if (event.key == "9" || event.key == "8" || event.key == "7") event.preventDefault();
        }
    }
}

/************************************************************************/

/* Mouse event functions */

function onMouseDown(event)
{
    if (event.button == 2)
    {
        rightDown = true;
        wheelZoom = false;
    }
}

function onMouseUp(event)
{
    if (event.button == 2)
    {
        rightDown = false;
    }
}

function onContextMenu(event)
{
    if (wheelZoom)
    {
        wheelZoom = false;
        
        event.preventDefault();
    }
}

function onWheel(event)
{
    if (event.ctrlKey || (enableRightWheel && rightDown))
    {
        wheelZoom = true;
        
        if (event.deltaY < 0) chrome.runtime.sendMessage({ type: "zoomin" });
        else if (event.deltaY > 0) chrome.runtime.sendMessage({ type: "zoomout" });
        
        event.preventDefault();
    }
}

/************************************************************************/

/* Resize event functions */

function onResize(event)
{
    var image;
    
    chrome.runtime.sendMessage({ type: "resize" });
    
    if (enableScaling)
    {
        if (document.contentType.substr(0,5) == "image" && document.contentType != "image/svg+xml")
        {
            image = document.body.children[0];
            
            if (image.naturalWidth < window.innerWidth && image.naturalHeight < window.innerHeight)
            {
                if (image.width != image.naturalWidth || image.height != image.naturalHeight)
                {
                    if (window.innerWidth/window.innerHeight <= image.naturalWidth/image.naturalHeight)
                    {
                        image.width = window.innerWidth-1;
                        image.height = image.width*(image.naturalHeight/image.naturalWidth);
                    }
                    else
                    {
                        image.height = window.innerHeight-1;
                        image.width = image.height*(image.naturalWidth/image.naturalHeight);
                    }
                    
                    if (isFirefox)
                    {
                        document.title = document.title.replace(/ - Scaled \(\d+%\)/,"");
                        document.title = document.title + " - Scaled (" + Math.round((image.width/image.naturalWidth)*100) + "%)";
                    }
                }
            }
            
            setImageCursor();
        }
    }
    
    event.preventDefault();
}

/************************************************************************/
